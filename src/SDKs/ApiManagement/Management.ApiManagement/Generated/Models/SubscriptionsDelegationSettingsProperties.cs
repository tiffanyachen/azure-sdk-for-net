// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Subscriptions delegation settings properties.
    /// </summary>
    public partial class SubscriptionsDelegationSettingsProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SubscriptionsDelegationSettingsProperties class.
        /// </summary>
        public SubscriptionsDelegationSettingsProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SubscriptionsDelegationSettingsProperties class.
        /// </summary>
        /// <param name="enabled">Enable or disable delegation for
        /// subscriptions.</param>
        public SubscriptionsDelegationSettingsProperties(bool? enabled = default(bool?))
        {
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets enable or disable delegation for subscriptions.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

    }
}
