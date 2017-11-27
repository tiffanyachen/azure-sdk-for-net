// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using System.Linq;

    /// <summary>
    /// The shared keys for a workspace.
    /// </summary>
    public partial class SharedKeys
    {
        /// <summary>
        /// Initializes a new instance of the SharedKeys class.
        /// </summary>
        public SharedKeys() { }

        /// <summary>
        /// Initializes a new instance of the SharedKeys class.
        /// </summary>
        /// <param name="primarySharedKey">The primary shared key of a
        /// workspace.</param>
        /// <param name="secondarySharedKey">The secondary shared key of a
        /// workspace.</param>
        public SharedKeys(string primarySharedKey = default(string), string secondarySharedKey = default(string))
        {
            PrimarySharedKey = primarySharedKey;
            SecondarySharedKey = secondarySharedKey;
        }

        /// <summary>
        /// Gets or sets the primary shared key of a workspace.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "primarySharedKey")]
        public string PrimarySharedKey { get; set; }

        /// <summary>
        /// Gets or sets the secondary shared key of a workspace.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "secondarySharedKey")]
        public string SecondarySharedKey { get; set; }

    }
}