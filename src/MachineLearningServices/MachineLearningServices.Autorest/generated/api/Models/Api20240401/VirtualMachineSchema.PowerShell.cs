// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(VirtualMachineSchemaTypeConverter))]
    public partial class VirtualMachineSchema
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.VirtualMachineSchema"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchema"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchema DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualMachineSchema(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.VirtualMachineSchema"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchema"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchema DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualMachineSchema(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualMachineSchema" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VirtualMachineSchema" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchema FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.VirtualMachineSchema"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualMachineSchema(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.VirtualMachineSchemaPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AdministratorAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccount = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSshCredentials) content.GetValueForProperty("AdministratorAccount",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccount, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.VirtualMachineSshCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Size"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).Size = (string) content.GetValueForProperty("Size",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).Size, global::System.Convert.ToString);
            }
            if (content.Contains("SshPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).SshPort = (int?) content.GetValueForProperty("SshPort",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).SshPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("NotebookServerPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).NotebookServerPort = (int?) content.GetValueForProperty("NotebookServerPort",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).NotebookServerPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Address"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).Address = (string) content.GetValueForProperty("Address",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).Address, global::System.Convert.ToString);
            }
            if (content.Contains("IsNotebookInstanceCompute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).IsNotebookInstanceCompute = (bool?) content.GetValueForProperty("IsNotebookInstanceCompute",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).IsNotebookInstanceCompute, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AdministratorAccountUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountUsername = (string) content.GetValueForProperty("AdministratorAccountUsername",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountUsername, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorAccountPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountPassword = (string) content.GetValueForProperty("AdministratorAccountPassword",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountPassword, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorAccountPublicKeyData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountPublicKeyData = (string) content.GetValueForProperty("AdministratorAccountPublicKeyData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountPublicKeyData, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorAccountPrivateKeyData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountPrivateKeyData = (string) content.GetValueForProperty("AdministratorAccountPrivateKeyData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountPrivateKeyData, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.VirtualMachineSchema"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualMachineSchema(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.VirtualMachineSchemaPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AdministratorAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccount = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSshCredentials) content.GetValueForProperty("AdministratorAccount",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccount, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.VirtualMachineSshCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Size"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).Size = (string) content.GetValueForProperty("Size",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).Size, global::System.Convert.ToString);
            }
            if (content.Contains("SshPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).SshPort = (int?) content.GetValueForProperty("SshPort",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).SshPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("NotebookServerPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).NotebookServerPort = (int?) content.GetValueForProperty("NotebookServerPort",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).NotebookServerPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Address"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).Address = (string) content.GetValueForProperty("Address",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).Address, global::System.Convert.ToString);
            }
            if (content.Contains("IsNotebookInstanceCompute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).IsNotebookInstanceCompute = (bool?) content.GetValueForProperty("IsNotebookInstanceCompute",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).IsNotebookInstanceCompute, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AdministratorAccountUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountUsername = (string) content.GetValueForProperty("AdministratorAccountUsername",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountUsername, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorAccountPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountPassword = (string) content.GetValueForProperty("AdministratorAccountPassword",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountPassword, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorAccountPublicKeyData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountPublicKeyData = (string) content.GetValueForProperty("AdministratorAccountPublicKeyData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountPublicKeyData, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorAccountPrivateKeyData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountPrivateKeyData = (string) content.GetValueForProperty("AdministratorAccountPrivateKeyData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSchemaInternal)this).AdministratorAccountPrivateKeyData, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineSchemaTypeConverter))]
    public partial interface IVirtualMachineSchema

    {

    }
}