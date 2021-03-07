/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace HomeControlSystem
{
    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor Object.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor = 18;

        /// <summary>
        /// The identifier for the HomeControlSystem1 Object.
        /// </summary>
        public const uint HomeControlSystem1 = 35;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor Object.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor = 36;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the GenericSensorType ObjectType.
        /// </summary>
        public const uint GenericSensorType = 1;

        /// <summary>
        /// The identifier for the TemperatureSensorType ObjectType.
        /// </summary>
        public const uint TemperatureSensorType = 9;

        /// <summary>
        /// The identifier for the HomeControlSystemType ObjectType.
        /// </summary>
        public const uint HomeControlSystemType = 17;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the GenericSensorType_Output Variable.
        /// </summary>
        public const uint GenericSensorType_Output = 2;

        /// <summary>
        /// The identifier for the GenericSensorType_Output_EURange Variable.
        /// </summary>
        public const uint GenericSensorType_Output_EURange = 6;

        /// <summary>
        /// The identifier for the GenericSensorType_Units Variable.
        /// </summary>
        public const uint GenericSensorType_Units = 8;

        /// <summary>
        /// The identifier for the TemperatureSensorType_Output_EURange Variable.
        /// </summary>
        public const uint TemperatureSensorType_Output_EURange = 14;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_Output Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_Output = 19;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_Output_EURange Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_Output_EURange = 23;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_Units Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_Units = 25;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_Output Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_Output = 37;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_Output_EURange Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_Output_EURange = 41;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_Units Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_Units = 43;
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor Object.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor = new ExpandedNodeId(HomeControlSystem.Objects.HomeControlSystemType_TemperatureSensor, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1 Object.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1 = new ExpandedNodeId(HomeControlSystem.Objects.HomeControlSystem1, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor Object.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor = new ExpandedNodeId(HomeControlSystem.Objects.HomeControlSystem1_TemperatureSensor, HomeControlSystem.Namespaces.HomeControlSystem);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the GenericSensorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType = new ExpandedNodeId(HomeControlSystem.ObjectTypes.GenericSensorType, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType = new ExpandedNodeId(HomeControlSystem.ObjectTypes.TemperatureSensorType, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType = new ExpandedNodeId(HomeControlSystem.ObjectTypes.HomeControlSystemType, HomeControlSystem.Namespaces.HomeControlSystem);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the GenericSensorType_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Output = new ExpandedNodeId(HomeControlSystem.Variables.GenericSensorType_Output, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the GenericSensorType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Output_EURange = new ExpandedNodeId(HomeControlSystem.Variables.GenericSensorType_Output_EURange, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the GenericSensorType_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Units = new ExpandedNodeId(HomeControlSystem.Variables.GenericSensorType_Units, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_Output_EURange = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_Output_EURange, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_Output = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_Output, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_Output_EURange = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_Output_EURange, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_Units = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_Units, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_Output = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_Output, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_Output_EURange = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_Output_EURange, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_Units = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_Units, HomeControlSystem.Namespaces.HomeControlSystem);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the GenericSensorType component.
        /// </summary>
        public const string GenericSensorType = "GenericSensorType";

        /// <summary>
        /// The BrowseName for the HomeControlSystem1 component.
        /// </summary>
        public const string HomeControlSystem1 = "Home Control System";

        /// <summary>
        /// The BrowseName for the HomeControlSystemType component.
        /// </summary>
        public const string HomeControlSystemType = "HomeControlSystemType";

        /// <summary>
        /// The BrowseName for the Output component.
        /// </summary>
        public const string Output = "Output";

        /// <summary>
        /// The BrowseName for the TemperatureSensor component.
        /// </summary>
        public const string TemperatureSensor = "TS001";

        /// <summary>
        /// The BrowseName for the TemperatureSensorType component.
        /// </summary>
        public const string TemperatureSensorType = "TemperatureSensorType";

        /// <summary>
        /// The BrowseName for the Units component.
        /// </summary>
        public const string Units = "Units";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the HomeControlSystem namespace (.NET code namespace is 'HomeControlSystem').
        /// </summary>
        public const string HomeControlSystem = "http://opcfoundation.org/HomeControlSystem";
    }
    #endregion

    #region GenericSensorState Class
    #if (!OPCUA_EXCLUDE_GenericSensorState)
    /// <summary>
    /// Stores an instance of the GenericSensorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericSensorState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericSensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(HomeControlSystem.ObjectTypes.GenericSensorType, HomeControlSystem.Namespaces.HomeControlSystem, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACoAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvSG9tZUNvbnRyb2xTeXN0ZW3/////BGCAAgEA" +
           "AAABABkAAABHZW5lcmljU2Vuc29yVHlwZUluc3RhbmNlAQEBAAEBAQABAAAA/////wIAAAAVYIkKAgAA" +
           "AAEABgAAAE91dHB1dAEBAgAALwEAQAkCAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVS" +
           "YW5nZQEBBgAALgBEBgAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBAQgAAC4A" +
           "RAgAAAAADP////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Units
        {
            get
            {
                return m_units;
            }

            set
            {
                if (!Object.ReferenceEquals(m_units, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_units = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_output != null)
            {
                children.Add(m_output);
            }

            if (m_units != null)
            {
                children.Add(m_units);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case HomeControlSystem.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Output = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }

                case HomeControlSystem.BrowseNames.Units:
                {
                    if (createOrReplace)
                    {
                        if (Units == null)
                        {
                            if (replacement == null)
                            {
                                Units = new PropertyState<string>(this);
                            }
                            else
                            {
                                Units = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Units;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_output;
        private PropertyState<string> m_units;
        #endregion
    }
    #endif
    #endregion

    #region TemperatureSensorState Class
    #if (!OPCUA_EXCLUDE_TemperatureSensorState)
    /// <summary>
    /// Stores an instance of the TemperatureSensorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TemperatureSensorState : GenericSensorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TemperatureSensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(HomeControlSystem.ObjectTypes.TemperatureSensorType, HomeControlSystem.Namespaces.HomeControlSystem, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACoAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvSG9tZUNvbnRyb2xTeXN0ZW3/////BGCAAgEA" +
           "AAABAB0AAABUZW1wZXJhdHVyZVNlbnNvclR5cGVJbnN0YW5jZQEBCQABAQkACQAAAP////8CAAAAFWCJ" +
           "CgIAAAABAAYAAABPdXRwdXQBAQoAAC8BAEAJCgAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAQ4AAC4ARA4AAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQEQ" +
           "AAAuAEQQAAAAAAz/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region HomeControlSystemState Class
    #if (!OPCUA_EXCLUDE_HomeControlSystemState)
    /// <summary>
    /// Stores an instance of the HomeControlSystemType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class HomeControlSystemState : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public HomeControlSystemState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(HomeControlSystem.ObjectTypes.HomeControlSystemType, HomeControlSystem.Namespaces.HomeControlSystem, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACoAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvSG9tZUNvbnRyb2xTeXN0ZW3/////BGCAAgEA" +
           "AAABAB0AAABIb21lQ29udHJvbFN5c3RlbVR5cGVJbnN0YW5jZQEBEQABAREAEQAAAAEAAAAAMAABARIA" +
           "AQAAAIRgwAoBAAAAEQAAAFRlbXBlcmF0dXJlU2Vuc29yAQAFAAAAVFMwMDEBARIAAC8BAQkAEgAAAAEB" +
           "AAAAADABAQERAAIAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBEwAALwEAQAkTAAAAAAv/////AQH/////" +
           "AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBFwAALgBEFwAAAAEAdAP/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAFAAAAVW5pdHMBARkAAC4ARBkAAAAADP////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public TemperatureSensorState TemperatureSensor
        {
            get
            {
                return m_temperatureSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_temperatureSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_temperatureSensor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_temperatureSensor != null)
            {
                children.Add(m_temperatureSensor);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case HomeControlSystem.BrowseNames.TemperatureSensor:
                {
                    if (createOrReplace)
                    {
                        if (TemperatureSensor == null)
                        {
                            if (replacement == null)
                            {
                                TemperatureSensor = new TemperatureSensorState(this);
                            }
                            else
                            {
                                TemperatureSensor = (TemperatureSensorState)replacement;
                            }
                        }
                    }

                    instance = TemperatureSensor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private TemperatureSensorState m_temperatureSensor;
        #endregion
    }
    #endif
    #endregion
}