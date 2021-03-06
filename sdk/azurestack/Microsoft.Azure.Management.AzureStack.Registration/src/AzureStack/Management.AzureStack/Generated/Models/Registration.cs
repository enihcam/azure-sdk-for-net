// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureStack.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Registration information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Registration : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Registration class.
        /// </summary>
        public Registration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Registration class.
        /// </summary>
        /// <param name="id">ID of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of Resource.</param>
        /// <param name="tags">Custom tags for the resource.</param>
        /// <param name="etag">The entity tag used for optimistic concurrency
        /// when modifying the resource.</param>
        /// <param name="objectId">The object identifier associated with the
        /// Azure Stack connecting to Azure.</param>
        /// <param name="cloudId">The identifier of the registered Azure
        /// Stack.</param>
        /// <param name="billingModel">Specifies the billing mode for the Azure
        /// Stack registration.</param>
        public Registration(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), string objectId = default(string), string cloudId = default(string), string billingModel = default(string))
            : base(id, name, type, tags, etag)
        {
            ObjectId = objectId;
            CloudId = cloudId;
            BillingModel = billingModel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the object identifier associated with the Azure Stack
        /// connecting to Azure.
        /// </summary>
        [JsonProperty(PropertyName = "properties.objectId")]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the registered Azure Stack.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cloudId")]
        public string CloudId { get; set; }

        /// <summary>
        /// Gets or sets specifies the billing mode for the Azure Stack
        /// registration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingModel")]
        public string BillingModel { get; set; }

    }
}
