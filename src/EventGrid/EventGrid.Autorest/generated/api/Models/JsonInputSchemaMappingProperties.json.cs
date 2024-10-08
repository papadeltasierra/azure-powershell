// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>
    /// This can be used to map properties of a source schema (or default values, for certain supported properties) to properties
    /// of the EventGridEvent schema.
    /// </summary>
    public partial class JsonInputSchemaMappingProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IJsonInputSchemaMappingProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IJsonInputSchemaMappingProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IJsonInputSchemaMappingProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject json ? new JsonInputSchemaMappingProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject into a new instance of <see cref="JsonInputSchemaMappingProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal JsonInputSchemaMappingProperties(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject>("id"), out var __jsonId) ? Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.JsonField.FromJson(__jsonId) : _id;}
            {_topic = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject>("topic"), out var __jsonTopic) ? Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.JsonField.FromJson(__jsonTopic) : _topic;}
            {_eventTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject>("eventTime"), out var __jsonEventTime) ? Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.JsonField.FromJson(__jsonEventTime) : _eventTime;}
            {_eventType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject>("eventType"), out var __jsonEventType) ? Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.JsonFieldWithDefault.FromJson(__jsonEventType) : _eventType;}
            {_subject = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject>("subject"), out var __jsonSubject) ? Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.JsonFieldWithDefault.FromJson(__jsonSubject) : _subject;}
            {_dataVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject>("dataVersion"), out var __jsonDataVersion) ? Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.JsonFieldWithDefault.FromJson(__jsonDataVersion) : _dataVersion;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="JsonInputSchemaMappingProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="JsonInputSchemaMappingProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._id ? (Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode) this._id.ToJson(null,serializationMode) : null, "id" ,container.Add );
            AddIf( null != this._topic ? (Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode) this._topic.ToJson(null,serializationMode) : null, "topic" ,container.Add );
            AddIf( null != this._eventTime ? (Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode) this._eventTime.ToJson(null,serializationMode) : null, "eventTime" ,container.Add );
            AddIf( null != this._eventType ? (Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode) this._eventType.ToJson(null,serializationMode) : null, "eventType" ,container.Add );
            AddIf( null != this._subject ? (Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode) this._subject.ToJson(null,serializationMode) : null, "subject" ,container.Add );
            AddIf( null != this._dataVersion ? (Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode) this._dataVersion.ToJson(null,serializationMode) : null, "dataVersion" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}