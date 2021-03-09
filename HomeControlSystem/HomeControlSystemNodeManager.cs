using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HomeControlSystem
{
    class HomeControlSystemNodeManager : CustomNodeManager2
    {
        public HomeControlSystemNodeManager(IServerInternal server, ApplicationConfiguration configuration)
            :
            base(server, configuration)
        {
            SystemContext.NodeIdFactory = this;

            //set one namespace for the type model and one names for dynamically created nodes.
            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = HomeControlSystem.Namespaces.HomeControlSystem;
            namespaceUrls[1] = HomeControlSystem.Namespaces.HomeControlSystem + "/Instance";
            SetNamespaces(namespaceUrls);

            //get the configuration for the node manager.
            m_configuration = configuration.ParseExtension<HomeControlSystemServerConfiguration>();

            //use suitable defaults if no configuration exists.
            if (m_configuration == null)
            {
                m_configuration = new HomeControlSystemServerConfiguration();
            }
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                "C:/Users/Vince/source/repos/HomeControlSystem/HomeControlSystem/HomeControlSystem.PredefinedNodes.uanodes",
                typeof(HomeControlSystemNodeManager).GetTypeInfo().Assembly,
                true);

            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);

                //find the untyped Home Control System 1 node that was created when the model was loaded.
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(HomeControlSystem.Objects.HomeControlSystem1, NamespaceIndexes[0]), typeof(BaseObjectState));

                //convert the untyped node to a typed node that can be manipulated within the server
                m_homeControlSystem1 = new HomeControlSystemState(null);
                m_homeControlSystem1.Create(SystemContext, passiveNode);

                //replaces the untyped predefined nodes with their strongly typed versions.
                AddPredefinedNode(SystemContext, m_homeControlSystem1);

                //methods if needed

                //State 
                var critical = m_homeControlSystem1.TemperatureSensor.TemperatureCritical;
                critical.SetEnableState(SystemContext, true);
                critical.SetAcknowledgedState(SystemContext, false);
                critical.SetConfirmedState(SystemContext, false);
                critical.SetActiveState(SystemContext, true);
                critical.OnAcknowledge += AcknowledgeAlarm;
                critical.OnEnableDisable += EnableToggle;

                m_homeControlSystem1.TemperatureSensor.Output.AccessLevel = AccessLevels.CurrentReadOrWrite | AccessLevels.HistoryReadOrWrite;
                m_homeControlSystem1.TemperatureSensor.Output.UserAccessLevel = AccessLevels.CurrentReadOrWrite | AccessLevels.HistoryReadOrWrite;

                var measurements = new[] { 0.2, 0.7, 1.2, 0.345 };
                critical.WriteAttribute(SystemContext, Attributes.Value, new NumericRange(1,10), new DataValue(new Variant(measurements)));
                
                //timer for simulation
                m_simulationTimer = new System.Threading.Timer(DoSimulation, null, 1000, 1000);
            }
        }
        /*
        protected override void HistoryRead(ServerSystemContext context, HistoryReadDetails details, TimestampsToReturn timestampsToReturn, bool releaseContinuationPoints, IList<HistoryReadValueId> nodesToRead, IList<HistoryReadResult> results, IList<ServiceResult> errors, List<NodeHandle> nodesToProcess, IDictionary<NodeId, NodeState> cache)
        {
            base.HistoryRead(context, details, timestampsToReturn, releaseContinuationPoints, nodesToRead, results, errors, nodesToProcess, cache);
        }
        protected override void HistoryReadAtTime(ServerSystemContext context, ReadAtTimeDetails details, TimestampsToReturn timestampsToReturn, IList<HistoryReadValueId> nodesToRead, IList<HistoryReadResult> results, IList<ServiceResult> errors, List<NodeHandle> nodesToProcess, IDictionary<NodeId, NodeState> cache)
        {
            base.HistoryReadAtTime(context, details, timestampsToReturn, nodesToRead, results, errors, nodesToProcess, cache);
        }
        */
        public void DoSimulation(object state)
        {
            var sensor = m_homeControlSystem1.TemperatureSensor;

            sensor.Output.Value = i++;
            sensor.Output.ClearChangeMasks(SystemContext, false);

            if (sensor.Output.Value < 15)
            {
                sensor.TemperatureCritical.SetSeverity(SystemContext, EventSeverity.Min);
                sensor.TemperatureCritical.SetEnableState(SystemContext, false);
            }
            else if (sensor.Output.Value == 15)
            {
                Console.WriteLine("15");
                TranslationInfo message = new TranslationInfo("Message",
                    "en-US",
                    "Temperature is critical");

                /*
                TranslationInfo conditionClassName = new TranslationInfo("ConditionClassName",
                    "en-US",
                    "AlarmCondition");*/

                byte[] eventID = Encoding.ASCII.GetBytes("eventIdCx");
                //AuditConditionEnableEventState e = new AuditConditionEnableEventState(null);
                //e.Initialize(SystemContext, null, EventSeverity.Medium, new LocalizedText(message));
                sensor.TemperatureCritical.SetSeverity(SystemContext, EventSeverity.Medium);
                sensor.TemperatureCritical.Message.Value = new LocalizedText(message);
                sensor.TemperatureCritical.SourceNode.Value = sensor.Output.NodeId;
                sensor.TemperatureCritical.SourceName.Value = sensor.Output.SymbolicName;
                sensor.TemperatureCritical.EventId.Value = eventID;
                sensor.TemperatureCritical.EventType.Value = sensor.TemperatureCritical.TypeDefinitionId;
                sensor.TemperatureCritical.ConditionName.Value = "HI_LO";
                sensor.TemperatureCritical.ConditionClassName.Value = new LocalizedText("CriticalCondition");
                sensor.TemperatureCritical.ConditionClassId.Value = m_homeControlSystem1.CriticalCondition.NodeId;
                sensor.TemperatureCritical.InputNode.Value = sensor.Output.NodeId;
                sensor.TemperatureCritical.BranchId.Value = m_homeControlSystem1.CriticalCondition.NodeId;
                sensor.TemperatureCritical.Retain.Value = true;
                sensor.TemperatureCritical.Time.Value = DateTime.UtcNow;
                sensor.TemperatureCritical.ReceiveTime.Value = DateTime.UtcNow;
                sensor.TemperatureCritical.SetEnableState(SystemContext, true);
                sensor.TemperatureCritical.ReportEvent(SystemContext, sensor.TemperatureCritical);
            }
        }

        protected override void HistoryReadRawModified(ServerSystemContext context, ReadRawModifiedDetails details, TimestampsToReturn timestampsToReturn, IList<HistoryReadValueId> nodesToRead, IList<HistoryReadResult> results, IList<ServiceResult> errors, List<NodeHandle> nodesToProcess, IDictionary<NodeId, NodeState> cache)
        {
            HistoryReadValueId hr = new HistoryReadValueId();
            nodesToRead.Add(new HistoryReadValueId());
            results.Add(new HistoryReadResult());
            nodesToProcess.Add(new NodeHandle(m_homeControlSystem1.TemperatureSensor.Output.NodeId, m_homeControlSystem1.TemperatureSensor.Output));
        }

        private ServiceResult EnableToggle(ISystemContext context, ConditionState condition, bool isSomething)
        {
            //m_homeControlSystem1.TemperatureSensor.TemperatureCritical.SetAcknowledgedState(SystemContext, true);
            Console.WriteLine("Toggle");
            return ServiceResult.Good;
        }

        private ServiceResult AcknowledgeAlarm(ISystemContext context, ConditionState condition, byte[] eventId, LocalizedText comment)
        {
            //m_homeControlSystem1.TemperatureSensor.TemperatureCritical.SetAcknowledgedState(SystemContext, true);
            Console.WriteLine("Hello");
            return ServiceResult.Good;
        }

        private HomeControlSystemServerConfiguration m_configuration;
        private static HomeControlSystemState m_homeControlSystem1;
        private System.Threading.Timer m_simulationTimer;
        private int i = 0;

    }
}