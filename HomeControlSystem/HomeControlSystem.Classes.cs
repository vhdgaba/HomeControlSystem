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
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TemperatureCriticalType_ShelvingState_TimedShelve = 600;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TemperatureCriticalType_ShelvingState_Unshelve = 602;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TemperatureCriticalType_ShelvingState_OneShotShelve = 603;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Disable Method.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_Disable = 79;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Enable Method.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_Enable = 80;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_AddComment Method.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_AddComment = 81;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Acknowledge Method.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_Acknowledge = 101;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ShelvingState_TimedShelve = 148;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ShelvingState_Unshelve = 150;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ShelvingState_OneShotShelve = 151;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Disable Method.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_Disable = 221;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Enable Method.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_Enable = 222;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_AddComment Method.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_AddComment = 223;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Acknowledge Method.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_Acknowledge = 243;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve = 290;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_Unshelve = 292;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_OneShotShelve = 293;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Disable Method.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_Disable = 675;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Enable Method.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_Enable = 676;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_AddComment Method.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_AddComment = 677;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Disable Method.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_Disable = 712;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Enable Method.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_Enable = 713;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_AddComment Method.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_AddComment = 714;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Disable Method.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_Disable = 363;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Enable Method.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_Enable = 364;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_AddComment Method.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_AddComment = 365;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Acknowledge Method.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_Acknowledge = 385;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve = 432;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_Unshelve = 434;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_OneShotShelve = 435;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Disable Method.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_Disable = 749;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Enable Method.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_Enable = 750;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_AddComment Method.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_AddComment = 751;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Disable Method.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_Disable = 786;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Enable Method.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_Enable = 787;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_AddComment Method.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_AddComment = 788;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical Object.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical = 44;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor Object.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor = 18;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical Object.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical = 45;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition Object.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition = 642;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition Object.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition = 679;

        /// <summary>
        /// The identifier for the HomeControlSystem1 Object.
        /// </summary>
        public const uint HomeControlSystem1 = 35;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor Object.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor = 36;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical Object.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical = 46;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition Object.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition = 716;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition Object.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition = 753;
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
        /// The identifier for the TemperatureCriticalType ObjectType.
        /// </summary>
        public const uint TemperatureCriticalType = 491;

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
        /// The identifier for the TemperatureCriticalType_EnabledState_Id Variable.
        /// </summary>
        public const uint TemperatureCriticalType_EnabledState_Id = 512;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TemperatureCriticalType_Quality_SourceTimestamp = 521;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TemperatureCriticalType_LastSeverity_SourceTimestamp = 523;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TemperatureCriticalType_Comment_SourceTimestamp = 525;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TemperatureCriticalType_AddComment_InputArguments = 530;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint TemperatureCriticalType_ConditionRefresh_InputArguments = 532;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint TemperatureCriticalType_ConditionRefresh2_InputArguments = 534;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_AckedState_Id Variable.
        /// </summary>
        public const uint TemperatureCriticalType_AckedState_Id = 536;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TemperatureCriticalType_ConfirmedState_Id = 545;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TemperatureCriticalType_Acknowledge_InputArguments = 554;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TemperatureCriticalType_Confirm_InputArguments = 556;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ActiveState_Id Variable.
        /// </summary>
        public const uint TemperatureCriticalType_ActiveState_Id = 558;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_SuppressedState_Id Variable.
        /// </summary>
        public const uint TemperatureCriticalType_SuppressedState_Id = 568;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TemperatureCriticalType_OutOfServiceState_Id = 577;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TemperatureCriticalType_ShelvingState_CurrentState = 586;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TemperatureCriticalType_ShelvingState_CurrentState_Id = 587;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TemperatureCriticalType_ShelvingState_LastTransition_Id = 592;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TemperatureCriticalType_ShelvingState_UnshelveTime = 599;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TemperatureCriticalType_ShelvingState_TimedShelve_InputArguments = 601;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_SilenceState_Id Variable.
        /// </summary>
        public const uint TemperatureCriticalType_SilenceState_Id = 612;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_LatchedState_Id Variable.
        /// </summary>
        public const uint TemperatureCriticalType_LatchedState_Id = 625;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_IsAveragePerMonth Variable.
        /// </summary>
        public const uint TemperatureCriticalType_IsAveragePerMonth = 492;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_MyName Variable.
        /// </summary>
        public const uint TemperatureCriticalType_MyName = 493;

        /// <summary>
        /// The identifier for the TemperatureCriticalType_MyNumber Variable.
        /// </summary>
        public const uint TemperatureCriticalType_MyNumber = 494;

        /// <summary>
        /// The identifier for the TemperatureSensorType_Output_EURange Variable.
        /// </summary>
        public const uint TemperatureSensorType_Output_EURange = 14;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_EventId Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_EventId = 47;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_EventType Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_EventType = 48;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_SourceNode Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_SourceNode = 49;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_SourceName Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_SourceName = 50;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Time Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_Time = 51;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ReceiveTime Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ReceiveTime = 52;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Message Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_Message = 54;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Severity Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_Severity = 55;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ConditionClassId Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ConditionClassId = 56;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ConditionClassName Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ConditionClassName = 57;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ConditionName Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ConditionName = 60;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_BranchId Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_BranchId = 61;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Retain Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_Retain = 62;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_EnabledState Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_EnabledState = 63;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_EnabledState_Id Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_EnabledState_Id = 64;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Quality Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_Quality = 72;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_Quality_SourceTimestamp = 73;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_LastSeverity Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_LastSeverity = 74;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_LastSeverity_SourceTimestamp = 75;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Comment Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_Comment = 76;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_Comment_SourceTimestamp = 77;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ClientUserId Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ClientUserId = 78;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_AddComment_InputArguments = 82;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_AckedState Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_AckedState = 83;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_AckedState_Id Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_AckedState_Id = 84;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ConfirmedState_Id = 93;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_Acknowledge_InputArguments = 102;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_Confirm_InputArguments = 104;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ActiveState Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ActiveState = 105;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ActiveState_Id Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ActiveState_Id = 106;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_InputNode Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_InputNode = 114;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_SuppressedState_Id Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_SuppressedState_Id = 116;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_OutOfServiceState_Id = 125;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ShelvingState_CurrentState = 134;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ShelvingState_CurrentState_Id = 135;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ShelvingState_LastTransition_Id = 140;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ShelvingState_UnshelveTime = 147;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_ShelvingState_TimedShelve_InputArguments = 149;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_SuppressedOrShelved Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_SuppressedOrShelved = 152;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_SilenceState_Id Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_SilenceState_Id = 160;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_LatchedState_Id Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_LatchedState_Id = 173;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_IsAveragePerMonth Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_IsAveragePerMonth = 476;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_MyName Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_MyName = 479;

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_MyNumber Variable.
        /// </summary>
        public const uint TemperatureSensorType_TemperatureCritical_MyNumber = 480;

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
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_EventId Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_EventId = 189;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_EventType Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_EventType = 190;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_SourceNode Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_SourceNode = 191;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_SourceName Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_SourceName = 192;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Time Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_Time = 193;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ReceiveTime Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ReceiveTime = 194;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Message Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_Message = 196;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Severity Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_Severity = 197;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConditionClassId Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConditionClassId = 198;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConditionClassName Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConditionClassName = 199;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConditionName Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConditionName = 202;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_BranchId Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_BranchId = 203;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Retain Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_Retain = 204;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_EnabledState Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_EnabledState = 205;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_EnabledState_Id Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_EnabledState_Id = 206;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Quality Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_Quality = 214;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_Quality_SourceTimestamp = 215;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_LastSeverity Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_LastSeverity = 216;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_LastSeverity_SourceTimestamp = 217;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Comment Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_Comment = 218;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_Comment_SourceTimestamp = 219;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ClientUserId Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ClientUserId = 220;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_AddComment_InputArguments Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_AddComment_InputArguments = 224;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_AckedState Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_AckedState = 225;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_AckedState_Id Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_AckedState_Id = 226;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConfirmedState_Id Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConfirmedState_Id = 235;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_Acknowledge_InputArguments = 244;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Confirm_InputArguments Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_Confirm_InputArguments = 246;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ActiveState Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ActiveState = 247;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ActiveState_Id Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ActiveState_Id = 248;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_InputNode Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_InputNode = 256;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_SuppressedState_Id Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_SuppressedState_Id = 258;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_OutOfServiceState_Id = 267;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState = 276;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState_Id = 277;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_LastTransition_Id = 282;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_UnshelveTime = 289;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve_InputArguments = 291;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_SuppressedOrShelved Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_SuppressedOrShelved = 294;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_SilenceState_Id Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_SilenceState_Id = 302;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_LatchedState_Id Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_LatchedState_Id = 315;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_IsAveragePerMonth Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_IsAveragePerMonth = 477;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_MyName Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_MyName = 481;

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_MyNumber Variable.
        /// </summary>
        public const uint HomeControlSystemType_TemperatureSensor_TemperatureCritical_MyNumber = 482;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_EventId Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_EventId = 643;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_EventType Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_EventType = 644;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_SourceNode Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_SourceNode = 645;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_SourceName Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_SourceName = 646;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Time Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_Time = 647;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_ReceiveTime Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_ReceiveTime = 648;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Message Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_Message = 650;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Severity Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_Severity = 651;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_ConditionClassId Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_ConditionClassId = 652;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_ConditionClassName Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_ConditionClassName = 653;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_ConditionName Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_ConditionName = 656;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_BranchId Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_BranchId = 657;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Retain Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_Retain = 658;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_EnabledState Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_EnabledState = 659;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_EnabledState_Id Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_EnabledState_Id = 660;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Quality Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_Quality = 668;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_Quality_SourceTimestamp = 669;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_LastSeverity Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_LastSeverity = 670;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_LastSeverity_SourceTimestamp = 671;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Comment Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_Comment = 672;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_Comment_SourceTimestamp = 673;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_ClientUserId Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_ClientUserId = 674;

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_AddComment_InputArguments Variable.
        /// </summary>
        public const uint HomeControlSystemType_NormalCondition_AddComment_InputArguments = 678;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_EventId Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_EventId = 680;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_EventType Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_EventType = 681;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_SourceNode Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_SourceNode = 682;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_SourceName Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_SourceName = 683;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Time Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_Time = 684;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_ReceiveTime Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_ReceiveTime = 685;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Message Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_Message = 687;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Severity Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_Severity = 688;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_ConditionClassId Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_ConditionClassId = 689;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_ConditionClassName Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_ConditionClassName = 690;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_ConditionName Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_ConditionName = 693;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_BranchId Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_BranchId = 694;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Retain Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_Retain = 695;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_EnabledState Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_EnabledState = 696;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_EnabledState_Id Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_EnabledState_Id = 697;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Quality Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_Quality = 705;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_Quality_SourceTimestamp = 706;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_LastSeverity Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_LastSeverity = 707;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_LastSeverity_SourceTimestamp = 708;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Comment Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_Comment = 709;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_Comment_SourceTimestamp = 710;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_ClientUserId Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_ClientUserId = 711;

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_AddComment_InputArguments Variable.
        /// </summary>
        public const uint HomeControlSystemType_CriticalCondition_AddComment_InputArguments = 715;

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

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_EventId Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_EventId = 331;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_EventType Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_EventType = 332;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_SourceNode Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_SourceNode = 333;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_SourceName Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_SourceName = 334;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Time Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_Time = 335;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ReceiveTime Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ReceiveTime = 336;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Message Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_Message = 338;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Severity Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_Severity = 339;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConditionClassId Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConditionClassId = 340;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConditionClassName Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConditionClassName = 341;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConditionName Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConditionName = 344;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_BranchId Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_BranchId = 345;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Retain Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_Retain = 346;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_EnabledState Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_EnabledState = 347;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_EnabledState_Id Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_EnabledState_Id = 348;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Quality Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_Quality = 356;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_Quality_SourceTimestamp = 357;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_LastSeverity Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_LastSeverity = 358;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_LastSeverity_SourceTimestamp = 359;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Comment Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_Comment = 360;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_Comment_SourceTimestamp = 361;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ClientUserId Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ClientUserId = 362;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_AddComment_InputArguments Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_AddComment_InputArguments = 366;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_AckedState Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_AckedState = 367;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_AckedState_Id Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_AckedState_Id = 368;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConfirmedState_Id Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConfirmedState_Id = 377;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_Acknowledge_InputArguments = 386;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Confirm_InputArguments Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_Confirm_InputArguments = 388;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ActiveState Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ActiveState = 389;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ActiveState_Id Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ActiveState_Id = 390;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_InputNode Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_InputNode = 398;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_SuppressedState_Id Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_SuppressedState_Id = 400;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_OutOfServiceState_Id = 409;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState = 418;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState_Id = 419;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_LastTransition_Id = 424;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_UnshelveTime = 431;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve_InputArguments = 433;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_SuppressedOrShelved Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_SuppressedOrShelved = 436;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_SilenceState_Id Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_SilenceState_Id = 444;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_LatchedState_Id Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_LatchedState_Id = 457;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_IsAveragePerMonth Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_IsAveragePerMonth = 478;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_MyName Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_MyName = 483;

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_MyNumber Variable.
        /// </summary>
        public const uint HomeControlSystem1_TemperatureSensor_TemperatureCritical_MyNumber = 484;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_EventId Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_EventId = 717;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_EventType Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_EventType = 718;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_SourceNode Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_SourceNode = 719;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_SourceName Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_SourceName = 720;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Time Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_Time = 721;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_ReceiveTime Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_ReceiveTime = 722;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Message Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_Message = 724;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Severity Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_Severity = 725;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_ConditionClassId Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_ConditionClassId = 726;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_ConditionClassName Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_ConditionClassName = 727;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_ConditionName Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_ConditionName = 730;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_BranchId Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_BranchId = 731;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Retain Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_Retain = 732;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_EnabledState Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_EnabledState = 733;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_EnabledState_Id Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_EnabledState_Id = 734;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Quality Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_Quality = 742;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_Quality_SourceTimestamp = 743;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_LastSeverity Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_LastSeverity = 744;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_LastSeverity_SourceTimestamp = 745;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Comment Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_Comment = 746;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_Comment_SourceTimestamp = 747;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_ClientUserId Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_ClientUserId = 748;

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_AddComment_InputArguments Variable.
        /// </summary>
        public const uint HomeControlSystem1_NormalCondition_AddComment_InputArguments = 752;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_EventId Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_EventId = 754;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_EventType Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_EventType = 755;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_SourceNode Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_SourceNode = 756;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_SourceName Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_SourceName = 757;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Time Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_Time = 758;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_ReceiveTime Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_ReceiveTime = 759;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Message Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_Message = 761;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Severity Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_Severity = 762;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_ConditionClassId Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_ConditionClassId = 763;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_ConditionClassName Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_ConditionClassName = 764;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_ConditionName Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_ConditionName = 767;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_BranchId Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_BranchId = 768;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Retain Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_Retain = 769;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_EnabledState Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_EnabledState = 770;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_EnabledState_Id Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_EnabledState_Id = 771;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Quality Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_Quality = 779;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_Quality_SourceTimestamp = 780;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_LastSeverity Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_LastSeverity = 781;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_LastSeverity_SourceTimestamp = 782;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Comment Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_Comment = 783;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_Comment_SourceTimestamp = 784;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_ClientUserId Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_ClientUserId = 785;

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_AddComment_InputArguments Variable.
        /// </summary>
        public const uint HomeControlSystem1_CriticalCondition_AddComment_InputArguments = 789;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_ShelvingState_TimedShelve = new ExpandedNodeId(HomeControlSystem.Methods.TemperatureCriticalType_ShelvingState_TimedShelve, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_ShelvingState_Unshelve = new ExpandedNodeId(HomeControlSystem.Methods.TemperatureCriticalType_ShelvingState_Unshelve, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_ShelvingState_OneShotShelve = new ExpandedNodeId(HomeControlSystem.Methods.TemperatureCriticalType_ShelvingState_OneShotShelve, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_Disable = new ExpandedNodeId(HomeControlSystem.Methods.TemperatureSensorType_TemperatureCritical_Disable, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_Enable = new ExpandedNodeId(HomeControlSystem.Methods.TemperatureSensorType_TemperatureCritical_Enable, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_AddComment = new ExpandedNodeId(HomeControlSystem.Methods.TemperatureSensorType_TemperatureCritical_AddComment, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_Acknowledge = new ExpandedNodeId(HomeControlSystem.Methods.TemperatureSensorType_TemperatureCritical_Acknowledge, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ShelvingState_TimedShelve = new ExpandedNodeId(HomeControlSystem.Methods.TemperatureSensorType_TemperatureCritical_ShelvingState_TimedShelve, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ShelvingState_Unshelve = new ExpandedNodeId(HomeControlSystem.Methods.TemperatureSensorType_TemperatureCritical_ShelvingState_Unshelve, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ShelvingState_OneShotShelve = new ExpandedNodeId(HomeControlSystem.Methods.TemperatureSensorType_TemperatureCritical_ShelvingState_OneShotShelve, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_Disable = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystemType_TemperatureSensor_TemperatureCritical_Disable, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_Enable = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystemType_TemperatureSensor_TemperatureCritical_Enable, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_AddComment = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystemType_TemperatureSensor_TemperatureCritical_AddComment, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_Acknowledge = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystemType_TemperatureSensor_TemperatureCritical_Acknowledge, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_Unshelve = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_Unshelve, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_OneShotShelve = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_OneShotShelve, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_Disable = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystemType_NormalCondition_Disable, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_Enable = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystemType_NormalCondition_Enable, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_AddComment = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystemType_NormalCondition_AddComment, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_Disable = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystemType_CriticalCondition_Disable, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_Enable = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystemType_CriticalCondition_Enable, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_AddComment = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystemType_CriticalCondition_AddComment, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_Disable = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystem1_TemperatureSensor_TemperatureCritical_Disable, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_Enable = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystem1_TemperatureSensor_TemperatureCritical_Enable, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_AddComment = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystem1_TemperatureSensor_TemperatureCritical_AddComment, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_Acknowledge = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystem1_TemperatureSensor_TemperatureCritical_Acknowledge, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_Unshelve = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_Unshelve, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_OneShotShelve = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_OneShotShelve, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_Disable = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystem1_NormalCondition_Disable, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_Enable = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystem1_NormalCondition_Enable, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_AddComment = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystem1_NormalCondition_AddComment, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_Disable = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystem1_CriticalCondition_Disable, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_Enable = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystem1_CriticalCondition_Enable, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_AddComment = new ExpandedNodeId(HomeControlSystem.Methods.HomeControlSystem1_CriticalCondition_AddComment, HomeControlSystem.Namespaces.HomeControlSystem);
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
        /// The identifier for the TemperatureSensorType_TemperatureCritical Object.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical = new ExpandedNodeId(HomeControlSystem.Objects.TemperatureSensorType_TemperatureCritical, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor Object.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor = new ExpandedNodeId(HomeControlSystem.Objects.HomeControlSystemType_TemperatureSensor, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical Object.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical = new ExpandedNodeId(HomeControlSystem.Objects.HomeControlSystemType_TemperatureSensor_TemperatureCritical, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition Object.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition = new ExpandedNodeId(HomeControlSystem.Objects.HomeControlSystemType_NormalCondition, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition Object.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition = new ExpandedNodeId(HomeControlSystem.Objects.HomeControlSystemType_CriticalCondition, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1 Object.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1 = new ExpandedNodeId(HomeControlSystem.Objects.HomeControlSystem1, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor Object.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor = new ExpandedNodeId(HomeControlSystem.Objects.HomeControlSystem1_TemperatureSensor, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical Object.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical = new ExpandedNodeId(HomeControlSystem.Objects.HomeControlSystem1_TemperatureSensor_TemperatureCritical, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition Object.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition = new ExpandedNodeId(HomeControlSystem.Objects.HomeControlSystem1_NormalCondition, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition Object.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition = new ExpandedNodeId(HomeControlSystem.Objects.HomeControlSystem1_CriticalCondition, HomeControlSystem.Namespaces.HomeControlSystem);
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
        /// The identifier for the TemperatureCriticalType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType = new ExpandedNodeId(HomeControlSystem.ObjectTypes.TemperatureCriticalType, HomeControlSystem.Namespaces.HomeControlSystem);

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
        /// The identifier for the TemperatureCriticalType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_EnabledState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_EnabledState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_Quality_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_Quality_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_LastSeverity_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_LastSeverity_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_Comment_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_Comment_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_AddComment_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_AddComment_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_ConditionRefresh_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_ConditionRefresh_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_ConditionRefresh2_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_ConditionRefresh2_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_AckedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_AckedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_ConfirmedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_ConfirmedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_Acknowledge_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_Acknowledge_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_Confirm_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_Confirm_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_ActiveState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_ActiveState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_SuppressedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_SuppressedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_OutOfServiceState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_OutOfServiceState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_ShelvingState_CurrentState = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_ShelvingState_CurrentState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_ShelvingState_CurrentState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_ShelvingState_CurrentState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_ShelvingState_LastTransition_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_ShelvingState_LastTransition_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_ShelvingState_UnshelveTime = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_ShelvingState_UnshelveTime, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_ShelvingState_TimedShelve_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_SilenceState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_SilenceState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_LatchedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_LatchedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_IsAveragePerMonth Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_IsAveragePerMonth = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_IsAveragePerMonth, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_MyName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_MyName = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_MyName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureCriticalType_MyNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureCriticalType_MyNumber = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureCriticalType_MyNumber, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_Output_EURange = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_Output_EURange, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_EventId = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_EventId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_EventType = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_EventType, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_SourceNode = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_SourceNode, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_SourceName = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_SourceName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_Time = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_Time, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ReceiveTime = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_ReceiveTime, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_Message = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_Message, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_Severity = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_Severity, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ConditionClassId = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_ConditionClassId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ConditionClassName = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_ConditionClassName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ConditionName = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_ConditionName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_BranchId = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_BranchId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_Retain = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_Retain, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_EnabledState = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_EnabledState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_EnabledState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_EnabledState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_Quality = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_Quality, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_Quality_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_Quality_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_LastSeverity = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_LastSeverity, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_LastSeverity_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_LastSeverity_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_Comment = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_Comment, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_Comment_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_Comment_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ClientUserId = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_ClientUserId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_AddComment_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_AddComment_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_AckedState = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_AckedState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_AckedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_AckedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ConfirmedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_ConfirmedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_Acknowledge_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_Acknowledge_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_Confirm_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_Confirm_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ActiveState = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_ActiveState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ActiveState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_ActiveState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_InputNode = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_InputNode, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_SuppressedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_SuppressedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_OutOfServiceState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_OutOfServiceState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ShelvingState_CurrentState = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_ShelvingState_CurrentState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ShelvingState_CurrentState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_ShelvingState_CurrentState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ShelvingState_LastTransition_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_ShelvingState_LastTransition_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ShelvingState_UnshelveTime = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_ShelvingState_UnshelveTime, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_ShelvingState_TimedShelve_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_SuppressedOrShelved = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_SuppressedOrShelved, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_SilenceState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_SilenceState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_LatchedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_LatchedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_IsAveragePerMonth Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_IsAveragePerMonth = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_IsAveragePerMonth, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_MyName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_MyName = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_MyName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the TemperatureSensorType_TemperatureCritical_MyNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensorType_TemperatureCritical_MyNumber = new ExpandedNodeId(HomeControlSystem.Variables.TemperatureSensorType_TemperatureCritical_MyNumber, HomeControlSystem.Namespaces.HomeControlSystem);

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
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_EventId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_EventId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_EventType = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_EventType, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_SourceNode = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_SourceNode, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_SourceName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_SourceName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_Time = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_Time, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ReceiveTime = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ReceiveTime, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_Message = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_Message, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_Severity = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_Severity, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConditionClassId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConditionClassId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConditionClassName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConditionClassName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConditionName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConditionName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_BranchId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_BranchId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_Retain = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_Retain, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_EnabledState = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_EnabledState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_EnabledState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_EnabledState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_Quality = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_Quality, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_Quality_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_Quality_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_LastSeverity = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_LastSeverity, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_LastSeverity_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_LastSeverity_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_Comment = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_Comment, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_Comment_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_Comment_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ClientUserId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ClientUserId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_AddComment_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_AddComment_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_AckedState = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_AckedState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_AckedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_AckedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConfirmedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ConfirmedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_Acknowledge_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_Acknowledge_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_Confirm_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_Confirm_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ActiveState = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ActiveState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ActiveState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ActiveState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_InputNode = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_InputNode, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_SuppressedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_SuppressedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_OutOfServiceState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_OutOfServiceState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_LastTransition_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_LastTransition_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_UnshelveTime = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_UnshelveTime, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_SuppressedOrShelved = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_SuppressedOrShelved, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_SilenceState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_SilenceState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_LatchedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_LatchedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_IsAveragePerMonth Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_IsAveragePerMonth = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_IsAveragePerMonth, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_MyName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_MyName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_MyName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_TemperatureSensor_TemperatureCritical_MyNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_TemperatureSensor_TemperatureCritical_MyNumber = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_TemperatureSensor_TemperatureCritical_MyNumber, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_EventId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_EventId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_EventType = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_EventType, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_SourceNode = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_SourceNode, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_SourceName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_SourceName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_Time = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_Time, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_ReceiveTime = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_ReceiveTime, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_Message = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_Message, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_Severity = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_Severity, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_ConditionClassId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_ConditionClassId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_ConditionClassName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_ConditionClassName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_ConditionName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_ConditionName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_BranchId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_BranchId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_Retain = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_Retain, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_EnabledState = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_EnabledState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_EnabledState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_EnabledState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_Quality = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_Quality, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_Quality_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_Quality_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_LastSeverity = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_LastSeverity, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_LastSeverity_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_LastSeverity_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_Comment = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_Comment, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_Comment_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_Comment_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_ClientUserId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_ClientUserId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_NormalCondition_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_NormalCondition_AddComment_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_NormalCondition_AddComment_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_EventId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_EventId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_EventType = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_EventType, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_SourceNode = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_SourceNode, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_SourceName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_SourceName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_Time = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_Time, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_ReceiveTime = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_ReceiveTime, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_Message = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_Message, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_Severity = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_Severity, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_ConditionClassId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_ConditionClassId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_ConditionClassName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_ConditionClassName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_ConditionName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_ConditionName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_BranchId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_BranchId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_Retain = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_Retain, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_EnabledState = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_EnabledState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_EnabledState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_EnabledState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_Quality = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_Quality, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_Quality_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_Quality_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_LastSeverity = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_LastSeverity, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_LastSeverity_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_LastSeverity_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_Comment = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_Comment, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_Comment_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_Comment_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_ClientUserId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_ClientUserId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystemType_CriticalCondition_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystemType_CriticalCondition_AddComment_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystemType_CriticalCondition_AddComment_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

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

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_EventId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_EventId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_EventType = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_EventType, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_SourceNode = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_SourceNode, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_SourceName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_SourceName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_Time = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_Time, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ReceiveTime = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ReceiveTime, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_Message = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_Message, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_Severity = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_Severity, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConditionClassId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConditionClassId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConditionClassName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConditionClassName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConditionName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConditionName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_BranchId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_BranchId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_Retain = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_Retain, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_EnabledState = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_EnabledState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_EnabledState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_EnabledState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_Quality = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_Quality, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_Quality_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_Quality_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_LastSeverity = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_LastSeverity, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_LastSeverity_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_LastSeverity_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_Comment = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_Comment, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_Comment_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_Comment_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ClientUserId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ClientUserId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_AddComment_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_AddComment_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_AckedState = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_AckedState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_AckedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_AckedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConfirmedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ConfirmedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_Acknowledge_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_Acknowledge_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_Confirm_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_Confirm_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ActiveState = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ActiveState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ActiveState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ActiveState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_InputNode = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_InputNode, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_SuppressedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_SuppressedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_OutOfServiceState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_OutOfServiceState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_CurrentState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_LastTransition_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_LastTransition_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_UnshelveTime = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_UnshelveTime, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_ShelvingState_TimedShelve_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_SuppressedOrShelved = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_SuppressedOrShelved, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_SilenceState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_SilenceState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_LatchedState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_LatchedState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_IsAveragePerMonth Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_IsAveragePerMonth = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_IsAveragePerMonth, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_MyName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_MyName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_MyName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_TemperatureSensor_TemperatureCritical_MyNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_TemperatureSensor_TemperatureCritical_MyNumber = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_TemperatureSensor_TemperatureCritical_MyNumber, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_EventId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_EventId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_EventType = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_EventType, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_SourceNode = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_SourceNode, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_SourceName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_SourceName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_Time = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_Time, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_ReceiveTime = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_ReceiveTime, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_Message = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_Message, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_Severity = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_Severity, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_ConditionClassId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_ConditionClassId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_ConditionClassName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_ConditionClassName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_ConditionName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_ConditionName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_BranchId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_BranchId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_Retain = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_Retain, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_EnabledState = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_EnabledState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_EnabledState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_EnabledState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_Quality = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_Quality, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_Quality_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_Quality_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_LastSeverity = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_LastSeverity, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_LastSeverity_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_LastSeverity_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_Comment = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_Comment, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_Comment_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_Comment_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_ClientUserId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_ClientUserId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_NormalCondition_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_NormalCondition_AddComment_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_NormalCondition_AddComment_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_EventId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_EventId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_EventType = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_EventType, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_SourceNode = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_SourceNode, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_SourceName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_SourceName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_Time = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_Time, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_ReceiveTime = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_ReceiveTime, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_Message = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_Message, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_Severity = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_Severity, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_ConditionClassId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_ConditionClassId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_ConditionClassName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_ConditionClassName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_ConditionName = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_ConditionName, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_BranchId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_BranchId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_Retain = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_Retain, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_EnabledState = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_EnabledState, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_EnabledState_Id = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_EnabledState_Id, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_Quality = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_Quality, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_Quality_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_Quality_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_LastSeverity = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_LastSeverity, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_LastSeverity_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_LastSeverity_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_Comment = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_Comment, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_Comment_SourceTimestamp = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_Comment_SourceTimestamp, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_ClientUserId = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_ClientUserId, HomeControlSystem.Namespaces.HomeControlSystem);

        /// <summary>
        /// The identifier for the HomeControlSystem1_CriticalCondition_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId HomeControlSystem1_CriticalCondition_AddComment_InputArguments = new ExpandedNodeId(HomeControlSystem.Variables.HomeControlSystem1_CriticalCondition_AddComment_InputArguments, HomeControlSystem.Namespaces.HomeControlSystem);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the CriticalCondition component.
        /// </summary>
        public const string CriticalCondition = "CriticalCondition";

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
        /// The BrowseName for the IsAveragePerMonth component.
        /// </summary>
        public const string IsAveragePerMonth = "IsAveragePerMonth";

        /// <summary>
        /// The BrowseName for the MyName component.
        /// </summary>
        public const string MyName = "MyName";

        /// <summary>
        /// The BrowseName for the MyNumber component.
        /// </summary>
        public const string MyNumber = "MyNumber";

        /// <summary>
        /// The BrowseName for the NormalCondition component.
        /// </summary>
        public const string NormalCondition = "NormalCondition";

        /// <summary>
        /// The BrowseName for the Output component.
        /// </summary>
        public const string Output = "Output";

        /// <summary>
        /// The BrowseName for the TemperatureCritical component.
        /// </summary>
        public const string TemperatureCritical = "TempCritical";

        /// <summary>
        /// The BrowseName for the TemperatureCriticalType component.
        /// </summary>
        public const string TemperatureCriticalType = "TemperatureCriticalType";

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
           "AAABABkAAABHZW5lcmljU2Vuc29yVHlwZUluc3RhbmNlAQEBAAEBAQABAAAA/////wIAAAAVYokKAgAA" +
           "AAEABgAAAE91dHB1dAEBAgAALwEAQAkCAAAAAAv/////AwMB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAQYAAC4ARAYAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQEIAAAu" +
           "AEQIAAAAAAz/////AwP/////AAAAAA==";
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

    #region TemperatureCriticalState Class
    #if (!OPCUA_EXCLUDE_TemperatureCriticalState)
    /// <summary>
    /// Stores an instance of the TemperatureCriticalType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TemperatureCriticalState : DiscreteAlarmState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TemperatureCriticalState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(HomeControlSystem.ObjectTypes.TemperatureCriticalType, HomeControlSystem.Namespaces.HomeControlSystem, namespaceUris);
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
           "AAABAB8AAABUZW1wZXJhdHVyZUNyaXRpY2FsVHlwZUluc3RhbmNlAQHrAQEB6wHrAQAA/////x0AAAAV" +
           "YIkKAgAAAAAABwAAAEV2ZW50SWQBAe8BAC4ARO8BAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkA" +
           "AABFdmVudFR5cGUBAfABAC4ARPABAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VO" +
           "b2RlAQHxAQAuAETxAQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB8gEA" +
           "LgBE8gEAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAfMBAC4ARPMBAAABACYB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQH0AQAuAET0AQAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAQH2AQAuAET2AQAAABX/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAIAAAAU2V2ZXJpdHkBAfcBAC4ARPcBAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABD" +
           "b25kaXRpb25DbGFzc0lkAQH4AQAuAET4AQAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NOYW1lAQH5AQAuAET5AQAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29u" +
           "ZGl0aW9uTmFtZQEB/AEALgBE/AEAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElk" +
           "AQH9AQAuAET9AQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQH+AQAuAET+AQAA" +
           "AAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQH/AQAvAQAjI/8BAAAAFf//" +
           "//8BAQUAAAABACwjAAEBFwIBACwjAAEBIAIBACwjAAEBLQIBACwjAAEBNwIBACwjAAEBSQIBAAAAFWCJ" +
           "CgIAAAAAAAIAAABJZAEBAAIALgBEAAIAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1YWxp" +
           "dHkBAQgCAC8BACojCAIAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBCQIALgBECQIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5AQEK" +
           "AgAvAQAqIwoCAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAQsC" +
           "AC4ARAsCAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAQwCAC8BACojDAIA" +
           "AAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBDQIALgBEDQIAAAEA" +
           "JgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQEOAgAuAEQOAgAAAAz/////" +
           "AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBDwIALwEARCMPAgAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQEQAgAvAQBDIxACAAABAQEAAAABAPkLAAEA8woAAAAABGGC" +
           "CgQAAAAAAAoAAABBZGRDb21tZW50AQERAgAvAQBFIxECAAABAQEAAAABAPkLAAEADQsBAAAAF2CpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBEgIALgBEEgIAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50SWQA" +
           "D/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEA" +
           "KgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0" +
           "aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAAAAAoAAABBY2tlZFN0" +
           "YXRlAQEXAgAvAQAjIxcCAAAAFf////8BAQEAAAABACwjAQEB/wEBAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "GAIALgBEGAIAAAAB/////wEB/////wAAAAAEYYIKBAAAAAAACwAAAEFja25vd2xlZGdlAQEpAgAvAQCX" +
           "IykCAAABAQEAAAABAPkLAAEA8CIBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBKgIALgBE" +
           "KgIAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZp" +
           "ZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMA" +
           "AAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAAB" +
           "Af////8AAAAAFWCJCgIAAAAAAAsAAABBY3RpdmVTdGF0ZQEBLQIALwEAIyMtAgAAABX/////AQEBAAAA" +
           "AQAsIwEBAf8BAQAAABVgiQoCAAAAAAACAAAASWQBAS4CAC4ARC4CAAAAAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAkAAABJbnB1dE5vZGUBATYCAC4ARDYCAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABMA" +
           "AABTdXBwcmVzc2VkT3JTaGVsdmVkAQFcAgAuAERcAgAAAAH/////AQH/////AAAAABVgiQoCAAAAAQAR" +
           "AAAASXNBdmVyYWdlUGVyTW9udGgBAewBAC4AROwBAAAAAf////8BAf////8AAAAAFWCJCgIAAAABAAYA" +
           "AABNeU5hbWUBAe0BAC4ARO0BAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAgAAABNeU51bWJlcgEB" +
           "7gEALgBE7gEAAAAL/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<bool> IsAveragePerMonth
        {
            get
            {
                return m_isAveragePerMonth;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isAveragePerMonth, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isAveragePerMonth = value;
            }
        }

        /// <remarks />
        public PropertyState<string> MyName
        {
            get
            {
                return m_myName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_myName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_myName = value;
            }
        }

        /// <remarks />
        public PropertyState<double> MyNumber
        {
            get
            {
                return m_myNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_myNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_myNumber = value;
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
            if (m_isAveragePerMonth != null)
            {
                children.Add(m_isAveragePerMonth);
            }

            if (m_myName != null)
            {
                children.Add(m_myName);
            }

            if (m_myNumber != null)
            {
                children.Add(m_myNumber);
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
                case HomeControlSystem.BrowseNames.IsAveragePerMonth:
                {
                    if (createOrReplace)
                    {
                        if (IsAveragePerMonth == null)
                        {
                            if (replacement == null)
                            {
                                IsAveragePerMonth = new PropertyState<bool>(this);
                            }
                            else
                            {
                                IsAveragePerMonth = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsAveragePerMonth;
                    break;
                }

                case HomeControlSystem.BrowseNames.MyName:
                {
                    if (createOrReplace)
                    {
                        if (MyName == null)
                        {
                            if (replacement == null)
                            {
                                MyName = new PropertyState<string>(this);
                            }
                            else
                            {
                                MyName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = MyName;
                    break;
                }

                case HomeControlSystem.BrowseNames.MyNumber:
                {
                    if (createOrReplace)
                    {
                        if (MyNumber == null)
                        {
                            if (replacement == null)
                            {
                                MyNumber = new PropertyState<double>(this);
                            }
                            else
                            {
                                MyNumber = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = MyNumber;
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
        private PropertyState<bool> m_isAveragePerMonth;
        private PropertyState<string> m_myName;
        private PropertyState<double> m_myNumber;
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
           "AAABAB0AAABUZW1wZXJhdHVyZVNlbnNvclR5cGVJbnN0YW5jZQEBCQABAQkACQAAAAEAAAAAMAABASwA" +
           "AwAAABViiQoCAAAAAQAGAAAAT3V0cHV0AQEKAAAvAQBACQoAAAAAC/////8DAwH/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBDgAALgBEDgAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAA" +
           "VW5pdHMBARAAAC4ARBAAAAAADP////8DA/////8AAAAAJGDACgEAAAATAAAAVGVtcGVyYXR1cmVDcml0" +
           "aWNhbAEADAAAAFRlbXBDcml0aWNhbAEBLAADAAAAACUAAABDcml0aWNhbCBjb25kaXRvbiBvZiB0aGUg" +
           "dGVtcGVyYXR1cmUuAC8BAesBLAAAAAEAAAAAMAEBAQkAHQAAABVgiQoCAAAAAAAHAAAARXZlbnRJZAEB" +
           "LwAALgBELwAAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBMAAALgBEMAAA" +
           "AAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBATEAAC4ARDEAAAAAEf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQEyAAAuAEQyAAAAAAz/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAEAAAAVGltZQEBMwAALgBEMwAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAL" +
           "AAAAUmVjZWl2ZVRpbWUBATQAAC4ARDQAAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAE1l" +
           "c3NhZ2UBATYAAC4ARDYAAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABTZXZlcml0eQEBNwAA" +
           "LgBENwAAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBATgAAC4A" +
           "RDgAAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFzc05hbWUBATkAAC4A" +
           "RDkAAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQE8AAAuAEQ8AAAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAT0AAC4ARD0AAAAAEf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAT4AAC4ARD4AAAAAAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAwAAABFbmFibGVkU3RhdGUBAT8AAC8BACMjPwAAAAAV/////wEBBQAAAAEALCMAAQFTAAEALCMA" +
           "AQFcAAEALCMAAQFpAAEALCMAAQFzAAEALCMAAQGFAAEAAAAVYIkKAgAAAAAAAgAAAElkAQFAAAAuAERA" +
           "AAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEBSAAALwEAKiNIAAAAABP/////" +
           "AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFJAAAuAERJAAAAAQAmAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkBAUoAAC8BACojSgAAAAAF/////wEB////" +
           "/wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBSwAALgBESwAAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBTAAALwEAKiNMAAAAABX/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFNAAAuAERNAAAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAwAAABDbGllbnRVc2VySWQBAU4AAC4ARE4AAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcA" +
           "AABEaXNhYmxlAQFPAAAvAQBEI08AAAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFi" +
           "bGUBAVAAAC8BAEMjUAAAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQB" +
           "AVEAAC8BAEUjUQAAAAEBAQAAAAEA+QsAAQANCwEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRz" +
           "AQFSAAAuAERSAAAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUg" +
           "aWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf//" +
           "//8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAAB" +
           "AAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAAACgAAAEFja2VkU3RhdGUBAVMAAC8BACMjUwAAAAAV////" +
           "/wEBAQAAAAEALCMBAQE/AAEAAAAVYIkKAgAAAAAAAgAAAElkAQFUAAAuAERUAAAAAAH/////AQH/////" +
           "AAAAAARhggoEAAAAAAALAAAAQWNrbm93bGVkZ2UBAWUAAC8BAJcjZQAAAAEBAQAAAAEA+QsAAQDwIgEA" +
           "AAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFmAAAuAERmAAAAlgIAAAABACoBAUYAAAAHAAAA" +
           "RXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNv" +
           "bW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8g" +
           "YWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAAACwAA" +
           "AEFjdGl2ZVN0YXRlAQFpAAAvAQAjI2kAAAAAFf////8BAQEAAAABACwjAQEBPwABAAAAFWCJCgIAAAAA" +
           "AAIAAABJZAEBagAALgBEagAAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAElucHV0Tm9kZQEB" +
           "cgAALgBEcgAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEwAAAFN1cHByZXNzZWRPclNoZWx2ZWQB" +
           "AZgAAC4ARJgAAAAAAf////8BAf////8AAAAAFWCJCgIAAAABABEAAABJc0F2ZXJhZ2VQZXJNb250aAEB" +
           "3AEALgBE3AEAAAAB/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAE15TmFtZQEB3wEALgBE3wEAAAAM" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEACAAAAE15TnVtYmVyAQHgAQAuAETgAQAAAAv/////AQH/////" +
           "AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public TemperatureCriticalState TemperatureCritical
        {
            get
            {
                return m_temperatureCritical;
            }

            set
            {
                if (!Object.ReferenceEquals(m_temperatureCritical, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_temperatureCritical = value;
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
            if (m_temperatureCritical != null)
            {
                children.Add(m_temperatureCritical);
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
                case HomeControlSystem.BrowseNames.TemperatureCritical:
                {
                    if (createOrReplace)
                    {
                        if (TemperatureCritical == null)
                        {
                            if (replacement == null)
                            {
                                TemperatureCritical = new TemperatureCriticalState(this);
                            }
                            else
                            {
                                TemperatureCritical = (TemperatureCriticalState)replacement;
                            }
                        }
                    }

                    instance = TemperatureCritical;
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
        private TemperatureCriticalState m_temperatureCritical;
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
           "AwAAAIRgwAoBAAAAEQAAAFRlbXBlcmF0dXJlU2Vuc29yAQAFAAAAVFMwMDEBARIAAC8BAQkAEgAAAAEC" +
           "AAAAADABAQERAAAwAAEBLQADAAAAFWKJCgIAAAABAAYAAABPdXRwdXQBARMAAC8BAEAJEwAAAAAL////" +
           "/wMDAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEXAAAuAEQXAAAAAQB0A/////8BAf////8A" +
           "AAAAFWCJCgIAAAABAAUAAABVbml0cwEBGQAALgBEGQAAAAAM/////wMD/////wAAAAAkYMAKAQAAABMA" +
           "AABUZW1wZXJhdHVyZUNyaXRpY2FsAQAMAAAAVGVtcENyaXRpY2FsAQEtAAMAAAAAJQAAAENyaXRpY2Fs" +
           "IGNvbmRpdG9uIG9mIHRoZSB0ZW1wZXJhdHVyZS4ALwEB6wEtAAAAAQAAAAAwAQEBEgAdAAAAFWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQG9AAAuAES9AAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZl" +
           "bnRUeXBlAQG+AAAuAES+AAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB" +
           "vwAALgBEvwAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAcAAAC4ARMAA" +
           "AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQHBAAAuAETBAAAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBwgAALgBEwgAAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBxAAALgBExAAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CAAAAFNldmVyaXR5AQHFAAAuAETFAAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0" +
           "aW9uQ2xhc3NJZAEBxgAALgBExgAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlv" +
           "bkNsYXNzTmFtZQEBxwAALgBExwAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlv" +
           "bk5hbWUBAcoAAC4ARMoAAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBywAA" +
           "LgBEywAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBzAAALgBEzAAAAAAB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBzQAALwEAIyPNAAAAABX/////AQEF" +
           "AAAAAQAsIwABAeEAAQAsIwABAeoAAQAsIwABAfcAAQAsIwABAQEBAQAsIwABARMBAQAAABVgiQoCAAAA" +
           "AAACAAAASWQBAc4AAC4ARM4AAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQHW" +
           "AAAvAQAqI9YAAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAdcA" +
           "AC4ARNcAAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEB2AAALwEA" +
           "KiPYAAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQHZAAAuAETZ" +
           "AAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQHaAAAvAQAqI9oAAAAAFf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAdsAAC4ARNsAAAABACYB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB3AAALgBE3AAAAAAM/////wEB////" +
           "/wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAd0AAC8BAEQj3QAAAAEBAQAAAAEA+QsAAQDzCgAAAAAE" +
           "YYIKBAAAAAAABgAAAEVuYWJsZQEB3gAALwEAQyPeAAAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAA" +
           "AAAKAAAAQWRkQ29tbWVudAEB3wAALwEARSPfAAAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoCAAAAAAAO" +
           "AAAASW5wdXRBcmd1bWVudHMBAeAAAC4AROAAAACWAgAAAAEAKgEBRgAAAAcAAABFdmVudElkAA//////" +
           "AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIA" +
           "AAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNv" +
           "bmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAAAKAAAAQWNrZWRTdGF0ZQEB" +
           "4QAALwEAIyPhAAAAABX/////AQEBAAAAAQAsIwEBAc0AAQAAABVgiQoCAAAAAAACAAAASWQBAeIAAC4A" +
           "ROIAAAAAAf////8BAf////8AAAAABGGCCgQAAAAAAAsAAABBY2tub3dsZWRnZQEB8wAALwEAlyPzAAAA" +
           "AQEBAAAAAQD5CwABAPAiAQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAfQAAC4ARPQAAACW" +
           "AgAAAAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZv" +
           "ciB0aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQA" +
           "AABUaGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAABVgiQoCAAAAAAALAAAAQWN0aXZlU3RhdGUBAfcAAC8BACMj9wAAAAAV/////wEBAQAAAAEALCMB" +
           "AQHNAAEAAAAVYIkKAgAAAAAAAgAAAElkAQH4AAAuAET4AAAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAJAAAASW5wdXROb2RlAQEAAQAuAEQAAQAAABH/////AQH/////AAAAABVgiQoCAAAAAAATAAAAU3Vw" +
           "cHJlc3NlZE9yU2hlbHZlZAEBJgEALgBEJgEAAAAB/////wEB/////wAAAAAVYIkKAgAAAAEAEQAAAElz" +
           "QXZlcmFnZVBlck1vbnRoAQHdAQAuAETdAQAAAAH/////AQH/////AAAAABVgiQoCAAAAAQAGAAAATXlO" +
           "YW1lAQHhAQAuAEThAQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAIAAAATXlOdW1iZXIBAeIBAC4A" +
           "ROIBAAAAC/////8BAf////8AAAAABGCACgEAAAABAA8AAABOb3JtYWxDb25kaXRpb24BAYICAC8BAN4K" +
           "ggIAAP////8VAAAAFWCJCgIAAAAAAAcAAABFdmVudElkAQGDAgAuAESDAgAAAA//////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQGEAgAuAESEAgAAABH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAKAAAAU291cmNlTm9kZQEBhQIALgBEhQIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNv" +
           "dXJjZU5hbWUBAYYCAC4ARIYCAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQGHAgAu" +
           "AESHAgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBiAIALgBEiAIA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBigIALgBEigIAAAAV/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVyaXR5AQGLAgAuAESLAgAAAAX/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBjAIALgBEjAIAAAAR/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFtZQEBjQIALgBEjQIAAAAV/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAADQAAAENvbmRpdGlvbk5hbWUBAZACAC4ARJACAAAADP////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAgAAABCcmFuY2hJZAEBkQIALgBEkQIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFp" +
           "bgEBkgIALgBEkgIAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBkwIA" +
           "LwEAIyOTAgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZQCAC4ARJQCAAAAAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQGcAgAvAQAqI5wCAAAAE/////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAZ0CAC4ARJ0CAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEBngIALwEAKiOeAgAAAAX/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQGfAgAuAESfAgAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABDb21tZW50AQGgAgAvAQAqI6ACAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAaECAC4ARKECAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENs" +
           "aWVudFVzZXJJZAEBogIALgBEogIAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUB" +
           "AaMCAC8BAEQjowIAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBpAIALwEA" +
           "QyOkAgAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBpQIALwEARSOl" +
           "AgAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaYCAC4ARKYC" +
           "AACWAgAAAAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVy" +
           "IGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAA" +
           "ACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/" +
           "////AAAAAARggAoBAAAAAQARAAAAQ3JpdGljYWxDb25kaXRpb24BAacCAC8BAN4KpwIAAP////8VAAAA" +
           "FWCJCgIAAAAAAAcAAABFdmVudElkAQGoAgAuAESoAgAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJ" +
           "AAAARXZlbnRUeXBlAQGpAgAuAESpAgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNl" +
           "Tm9kZQEBqgIALgBEqgIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAasC" +
           "AC4ARKsCAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQGsAgAuAESsAgAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBrQIALgBErQIAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBrwIALgBErwIAAAAV/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACAAAAFNldmVyaXR5AQGwAgAuAESwAgAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAA" +
           "Q29uZGl0aW9uQ2xhc3NJZAEBsQIALgBEsQIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENv" +
           "bmRpdGlvbkNsYXNzTmFtZQEBsgIALgBEsgIAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENv" +
           "bmRpdGlvbk5hbWUBAbUCAC4ARLUCAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJ" +
           "ZAEBtgIALgBEtgIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBtwIALgBEtwIA" +
           "AAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBuAIALwEAIyO4AgAAABX/" +
           "////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAbkCAC4ARLkCAAAAAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABRdWFsaXR5AQHBAgAvAQAqI8ECAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABAcICAC4ARMICAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAA" +
           "AExhc3RTZXZlcml0eQEBwwIALwEAKiPDAgAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQHEAgAuAETEAgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21t" +
           "ZW50AQHFAgAvAQAqI8UCAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAcYCAC4ARMYCAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB" +
           "xwIALgBExwIAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAcgCAC8BAEQjyAIA" +
           "AAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEByQIALwEAQyPJAgAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBygIALwEARSPKAgAAAQEBAAAAAQD5" +
           "CwABAA0LAQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAcsCAC4ARMsCAACWAgAAAAEAKgEB" +
           "RgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZl" +
           "bnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29t" +
           "bWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";
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

        /// <remarks />
        public ConditionState NormalCondition
        {
            get
            {
                return m_normalCondition;
            }

            set
            {
                if (!Object.ReferenceEquals(m_normalCondition, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_normalCondition = value;
            }
        }

        /// <remarks />
        public ConditionState CriticalCondition
        {
            get
            {
                return m_criticalCondition;
            }

            set
            {
                if (!Object.ReferenceEquals(m_criticalCondition, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_criticalCondition = value;
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

            if (m_normalCondition != null)
            {
                children.Add(m_normalCondition);
            }

            if (m_criticalCondition != null)
            {
                children.Add(m_criticalCondition);
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

                case HomeControlSystem.BrowseNames.NormalCondition:
                {
                    if (createOrReplace)
                    {
                        if (NormalCondition == null)
                        {
                            if (replacement == null)
                            {
                                NormalCondition = new ConditionState(this);
                            }
                            else
                            {
                                NormalCondition = (ConditionState)replacement;
                            }
                        }
                    }

                    instance = NormalCondition;
                    break;
                }

                case HomeControlSystem.BrowseNames.CriticalCondition:
                {
                    if (createOrReplace)
                    {
                        if (CriticalCondition == null)
                        {
                            if (replacement == null)
                            {
                                CriticalCondition = new ConditionState(this);
                            }
                            else
                            {
                                CriticalCondition = (ConditionState)replacement;
                            }
                        }
                    }

                    instance = CriticalCondition;
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
        private ConditionState m_normalCondition;
        private ConditionState m_criticalCondition;
        #endregion
    }
    #endif
    #endregion
}