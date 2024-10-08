// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>Represents an operation returned by the GetOperations request.</summary>
    public partial class Operation :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperation,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationInternal
    {

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationInfo _display;

        /// <summary>Display name of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationInfo Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.OperationInfo()); set => this._display = value; }

        /// <summary>Description of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string DisplayDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationInfoInternal)Display).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationInfoInternal)Display).Description = value ?? null; }

        /// <summary>Name of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationInfoInternal)Display).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationInfoInternal)Display).Operation = value ?? null; }

        /// <summary>Name of the provider</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationInfoInternal)Display).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationInfoInternal)Display).Provider = value ?? null; }

        /// <summary>Name of the resource type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationInfoInternal)Display).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationInfoInternal)Display).Resource = value ?? null; }

        /// <summary>Backing field for <see cref="IsDataAction" /> property.</summary>
        private bool? _isDataAction;

        /// <summary>
        /// This Boolean is used to determine if the operation is a data plane action or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public bool? IsDataAction { get => this._isDataAction; set => this._isDataAction = value; }

        /// <summary>Internal Acessors for Display</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationInfo Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationInternal.Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.OperationInfo()); set { {_display = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Origin" /> property.</summary>
        private string _origin;

        /// <summary>Origin of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string Origin { get => this._origin; set => this._origin = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAny _property;

        /// <summary>Properties of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAny Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.Any()); set => this._property = value; }

        /// <summary>Creates an new <see cref="Operation" /> instance.</summary>
        public Operation()
        {

        }
    }
    /// Represents an operation returned by the GetOperations request.
    public partial interface IOperation :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable
    {
        /// <summary>Description of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Description of the operation",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>Name of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the operation",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get; set; }
        /// <summary>Name of the provider</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the provider",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get; set; }
        /// <summary>Name of the resource type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the resource type",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get; set; }
        /// <summary>
        /// This Boolean is used to determine if the operation is a data plane action or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This Boolean is used to determine if the operation is a data plane action or not.",
        SerializedName = @"isDataAction",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDataAction { get; set; }
        /// <summary>Name of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the operation.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Origin of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Origin of the operation.",
        SerializedName = @"origin",
        PossibleTypes = new [] { typeof(string) })]
        string Origin { get; set; }
        /// <summary>Properties of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Properties of the operation.",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAny Property { get; set; }

    }
    /// Represents an operation returned by the GetOperations request.
    internal partial interface IOperationInternal

    {
        /// <summary>Display name of the operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IOperationInfo Display { get; set; }
        /// <summary>Description of the operation</summary>
        string DisplayDescription { get; set; }
        /// <summary>Name of the operation</summary>
        string DisplayOperation { get; set; }
        /// <summary>Name of the provider</summary>
        string DisplayProvider { get; set; }
        /// <summary>Name of the resource type</summary>
        string DisplayResource { get; set; }
        /// <summary>
        /// This Boolean is used to determine if the operation is a data plane action or not.
        /// </summary>
        bool? IsDataAction { get; set; }
        /// <summary>Name of the operation.</summary>
        string Name { get; set; }
        /// <summary>Origin of the operation.</summary>
        string Origin { get; set; }
        /// <summary>Properties of the operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAny Property { get; set; }

    }
}