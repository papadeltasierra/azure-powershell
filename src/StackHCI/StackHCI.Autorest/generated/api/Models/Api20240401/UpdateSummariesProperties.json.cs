// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Extensions;

    /// <summary>Properties of Update summaries</summary>
    public partial class UpdateSummariesProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IUpdateSummariesProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IUpdateSummariesProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IUpdateSummariesProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json ? new UpdateSummariesProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="UpdateSummariesProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="UpdateSummariesProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != (((object)this._oemFamily)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._oemFamily.ToString()) : null, "oemFamily" ,container.Add );
            AddIf( null != (((object)this._hardwareModel)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._hardwareModel.ToString()) : null, "hardwareModel" ,container.Add );
            if (null != this._packageVersion)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.XNodeArray();
                foreach( var __x in this._packageVersion )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("packageVersions",__w);
            }
            AddIf( null != (((object)this._currentVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._currentVersion.ToString()) : null, "currentVersion" ,container.Add );
            AddIf( null != (((object)this._currentSbeVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._currentSbeVersion.ToString()) : null, "currentSbeVersion" ,container.Add );
            AddIf( null != this._lastUpdated ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._lastUpdated?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastUpdated" ,container.Add );
            AddIf( null != this._lastChecked ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._lastChecked?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastChecked" ,container.Add );
            AddIf( null != (((object)this._healthState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._healthState.ToString()) : null, "healthState" ,container.Add );
            if (null != this._healthCheckResult)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.XNodeArray();
                foreach( var __s in this._healthCheckResult )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("healthCheckResult",__r);
            }
            AddIf( null != this._healthCheckDate ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._healthCheckDate?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "healthCheckDate" ,container.Add );
            AddIf( null != (((object)this._state)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject into a new instance of <see cref="UpdateSummariesProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal UpdateSummariesProperties(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_oemFamily = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("oemFamily"), out var __jsonOemFamily) ? (string)__jsonOemFamily : (string)OemFamily;}
            {_hardwareModel = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("hardwareModel"), out var __jsonHardwareModel) ? (string)__jsonHardwareModel : (string)HardwareModel;}
            {_packageVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonArray>("packageVersions"), out var __jsonPackageVersions) ? If( __jsonPackageVersions as Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IPackageVersionInfo[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IPackageVersionInfo) (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.PackageVersionInfo.FromJson(__u) )) ))() : null : PackageVersion;}
            {_currentVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("currentVersion"), out var __jsonCurrentVersion) ? (string)__jsonCurrentVersion : (string)CurrentVersion;}
            {_currentSbeVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("currentSbeVersion"), out var __jsonCurrentSbeVersion) ? (string)__jsonCurrentSbeVersion : (string)CurrentSbeVersion;}
            {_lastUpdated = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("lastUpdated"), out var __jsonLastUpdated) ? global::System.DateTime.TryParse((string)__jsonLastUpdated, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastUpdatedValue) ? __jsonLastUpdatedValue : LastUpdated : LastUpdated;}
            {_lastChecked = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("lastChecked"), out var __jsonLastChecked) ? global::System.DateTime.TryParse((string)__jsonLastChecked, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastCheckedValue) ? __jsonLastCheckedValue : LastChecked : LastChecked;}
            {_healthState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("healthState"), out var __jsonHealthState) ? (string)__jsonHealthState : (string)HealthState;}
            {_healthCheckResult = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonArray>("healthCheckResult"), out var __jsonHealthCheckResult) ? If( __jsonHealthCheckResult as Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IPrecheckResult[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IPrecheckResult) (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.PrecheckResult.FromJson(__p) )) ))() : null : HealthCheckResult;}
            {_healthCheckDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("healthCheckDate"), out var __jsonHealthCheckDate) ? global::System.DateTime.TryParse((string)__jsonHealthCheckDate, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonHealthCheckDateValue) ? __jsonHealthCheckDateValue : HealthCheckDate : HealthCheckDate;}
            {_state = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            AfterFromJson(json);
        }
    }
}