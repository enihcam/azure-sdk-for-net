// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Custom domain analysis.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class CustomHostnameAnalysisResultInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CustomHostnameAnalysisResultInner class.
        /// </summary>
        public CustomHostnameAnalysisResultInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// CustomHostnameAnalysisResultInner class.
        /// </summary>
        /// <param name="isHostnameAlreadyVerified"><code>true</code> if
        /// hostname is already verified; otherwise,
        /// <code>false</code>.</param>
        /// <param name="customDomainVerificationTest">DNS verification test
        /// result. Possible values include: 'Passed', 'Failed',
        /// 'Skipped'</param>
        /// <param name="customDomainVerificationFailureInfo">Raw failure
        /// information if DNS verification fails.</param>
        /// <param name="hasConflictOnScaleUnit"><code>true</code> if there is
        /// a conflict on a scale unit; otherwise, <code>false</code>.</param>
        /// <param name="hasConflictAcrossSubscription"><code>true</code> if
        /// htere is a conflict across subscriptions; otherwise,
        /// <code>false</code>.</param>
        /// <param name="conflictingAppResourceId">Name of the conflicting app
        /// on scale unit if it's within the same subscription.</param>
        /// <param name="cNameRecords">CName records controller can see for
        /// this hostname.</param>
        /// <param name="txtRecords">TXT records controller can see for this
        /// hostname.</param>
        /// <param name="aRecords">A records controller can see for this
        /// hostname.</param>
        /// <param name="alternateCNameRecords">Alternate CName records
        /// controller can see for this hostname.</param>
        /// <param name="alternateTxtRecords">Alternate TXT records controller
        /// can see for this hostname.</param>
        public CustomHostnameAnalysisResultInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), bool? isHostnameAlreadyVerified = default(bool?), DnsVerificationTestResult? customDomainVerificationTest = default(DnsVerificationTestResult?), ErrorEntity customDomainVerificationFailureInfo = default(ErrorEntity), bool? hasConflictOnScaleUnit = default(bool?), bool? hasConflictAcrossSubscription = default(bool?), string conflictingAppResourceId = default(string), System.Collections.Generic.IList<string> cNameRecords = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> txtRecords = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> aRecords = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> alternateCNameRecords = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> alternateTxtRecords = default(System.Collections.Generic.IList<string>))
            : base(location, id, name, type, tags)
        {
            IsHostnameAlreadyVerified = isHostnameAlreadyVerified;
            CustomDomainVerificationTest = customDomainVerificationTest;
            CustomDomainVerificationFailureInfo = customDomainVerificationFailureInfo;
            HasConflictOnScaleUnit = hasConflictOnScaleUnit;
            HasConflictAcrossSubscription = hasConflictAcrossSubscription;
            ConflictingAppResourceId = conflictingAppResourceId;
            CNameRecords = cNameRecords;
            TxtRecords = txtRecords;
            ARecords = aRecords;
            AlternateCNameRecords = alternateCNameRecords;
            AlternateTxtRecords = alternateTxtRecords;
        }

        /// <summary>
        /// Gets &lt;code&gt;true&lt;/code&gt; if hostname is already
        /// verified; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isHostnameAlreadyVerified")]
        public bool? IsHostnameAlreadyVerified { get; private set; }

        /// <summary>
        /// Gets DNS verification test result. Possible values include:
        /// 'Passed', 'Failed', 'Skipped'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.customDomainVerificationTest")]
        public DnsVerificationTestResult? CustomDomainVerificationTest { get; private set; }

        /// <summary>
        /// Gets raw failure information if DNS verification fails.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.customDomainVerificationFailureInfo")]
        public ErrorEntity CustomDomainVerificationFailureInfo { get; private set; }

        /// <summary>
        /// Gets &lt;code&gt;true&lt;/code&gt; if there is a conflict on a
        /// scale unit; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.hasConflictOnScaleUnit")]
        public bool? HasConflictOnScaleUnit { get; private set; }

        /// <summary>
        /// Gets &lt;code&gt;true&lt;/code&gt; if htere is a conflict across
        /// subscriptions; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.hasConflictAcrossSubscription")]
        public bool? HasConflictAcrossSubscription { get; private set; }

        /// <summary>
        /// Gets name of the conflicting app on scale unit if it's within the
        /// same subscription.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.conflictingAppResourceId")]
        public string ConflictingAppResourceId { get; private set; }

        /// <summary>
        /// Gets or sets cName records controller can see for this hostname.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.cNameRecords")]
        public System.Collections.Generic.IList<string> CNameRecords { get; set; }

        /// <summary>
        /// Gets or sets TXT records controller can see for this hostname.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.txtRecords")]
        public System.Collections.Generic.IList<string> TxtRecords { get; set; }

        /// <summary>
        /// Gets or sets a records controller can see for this hostname.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.aRecords")]
        public System.Collections.Generic.IList<string> ARecords { get; set; }

        /// <summary>
        /// Gets or sets alternate CName records controller can see for this
        /// hostname.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.alternateCNameRecords")]
        public System.Collections.Generic.IList<string> AlternateCNameRecords { get; set; }

        /// <summary>
        /// Gets or sets alternate TXT records controller can see for this
        /// hostname.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.alternateTxtRecords")]
        public System.Collections.Generic.IList<string> AlternateTxtRecords { get; set; }

    }
}