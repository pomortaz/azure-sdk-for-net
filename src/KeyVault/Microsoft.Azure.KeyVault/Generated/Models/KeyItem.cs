// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The key item containing key metadata
    /// </summary>
    public partial class KeyItem
    {
        /// <summary>
        /// Initializes a new instance of the KeyItem class.
        /// </summary>
        public KeyItem() { }

        /// <summary>
        /// Initializes a new instance of the KeyItem class.
        /// </summary>
        /// <param name="kid">Key Identifier</param>
        /// <param name="attributes">The key management attributes</param>
        /// <param name="tags">Application-specific metadata in the form of
        /// key-value pairs</param>
        public KeyItem(string kid = default(string), KeyAttributes attributes = default(KeyAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Kid = kid;
            Attributes = attributes;
            Tags = tags;
        }

        /// <summary>
        /// Gets or sets key Identifier
        /// </summary>
        [JsonProperty(PropertyName = "kid")]
        public string Kid { get; set; }

        /// <summary>
        /// Gets or sets the key management attributes
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public KeyAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets application-specific metadata in the form of
        /// key-value pairs
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}