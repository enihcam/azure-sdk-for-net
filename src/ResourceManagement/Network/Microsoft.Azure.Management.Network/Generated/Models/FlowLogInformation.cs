// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Azure;
    using Management;
    using Network;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information on the configuration of flow log.
    /// </summary>
    [JsonTransformation]
    public partial class FlowLogInformation
    {
        /// <summary>
        /// Initializes a new instance of the FlowLogInformation class.
        /// </summary>
        public FlowLogInformation() { }

        /// <summary>
        /// Initializes a new instance of the FlowLogInformation class.
        /// </summary>
        /// <param name="targetResourceId">The ID of the resource to configure
        /// for flow logging.</param>
        /// <param name="storageId">ID of the storage account which is used to
        /// store the flow log.</param>
        /// <param name="enabled">Flag to enable/disable flow logging.</param>
        public FlowLogInformation(string targetResourceId, string storageId, bool enabled, RetentionPolicyParameters retentionPolicy = default(RetentionPolicyParameters))
        {
            TargetResourceId = targetResourceId;
            StorageId = storageId;
            Enabled = enabled;
            RetentionPolicy = retentionPolicy;
        }

        /// <summary>
        /// Gets or sets the ID of the resource to configure for flow logging.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceId")]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// Gets or sets ID of the storage account which is used to store the
        /// flow log.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageId")]
        public string StorageId { get; set; }

        /// <summary>
        /// Gets or sets flag to enable/disable flow logging.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionPolicy")]
        public RetentionPolicyParameters RetentionPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetResourceId");
            }
            if (StorageId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageId");
            }
        }
    }
}
