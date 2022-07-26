// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Defines the parameters for RequestScheme match conditions</summary>
    public partial class RequestSchemeMatchConditionParameters
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRequestSchemeMatchConditionParameters.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRequestSchemeMatchConditionParameters.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRequestSchemeMatchConditionParameters FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json ? new RequestSchemeMatchConditionParameters(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject into a new instance of <see cref="RequestSchemeMatchConditionParameters" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal RequestSchemeMatchConditionParameters(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_typeName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString>("typeName"), out var __jsonTypeName) ? (string)__jsonTypeName : (string)TypeName;}
            {_operator = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString>("operator"), out var __jsonOperator) ? (string)__jsonOperator : (string)Operator;}
            {_negateCondition = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonBoolean>("negateCondition"), out var __jsonNegateCondition) ? (bool?)__jsonNegateCondition : NegateCondition;}
            {_transform = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonArray>("transforms"), out var __jsonTransforms) ? If( __jsonTransforms as Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform) (__u is Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString __t ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform)(__t.ToString()) : ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform)""))) ))() : null : Transform;}
            {_matchValue = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonArray>("matchValues"), out var __jsonMatchValues) ? If( __jsonMatchValues as Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : MatchValue;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="RequestSchemeMatchConditionParameters" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RequestSchemeMatchConditionParameters" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._typeName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString(this._typeName.ToString()) : null, "typeName" ,container.Add );
            AddIf( null != (((object)this._operator)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString(this._operator.ToString()) : null, "operator" ,container.Add );
            AddIf( null != this._negateCondition ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonBoolean((bool)this._negateCondition) : null, "negateCondition" ,container.Add );
            if (null != this._transform)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.XNodeArray();
                foreach( var __x in this._transform )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("transforms",__w);
            }
            if (null != this._matchValue)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.XNodeArray();
                foreach( var __s in this._matchValue )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("matchValues",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}