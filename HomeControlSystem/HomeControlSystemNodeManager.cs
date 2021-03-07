using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            m_homeControlSystem1.TemperatureSensor.Output.Value = 34;
        //    m_homeControlSystem1.TemperatureSensor.Output.Historizing = true;
        }

        private HomeControlSystemServerConfiguration m_configuration;
        private static HomeControlSystemState m_homeControlSystem1;
        private System.Threading.Timer m_simulationTimer;

    }
}
