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
    /// Properties of the key backing a certificate.
    /// </summary>
    public partial class SecretProperties
    {
        /// <summary>
        /// Initializes a new instance of the SecretProperties class.
        /// </summary>
        public SecretProperties() { }

        /// <summary>
        /// Initializes a new instance of the SecretProperties class.
        /// </summary>
        /// <param name="contentType">The media type (MIME type).</param>
        public SecretProperties(string contentType = default(string))
        {
            ContentType = contentType;
        }

        /// <summary>
        /// Gets or sets the media type (MIME type).
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }

    }
}
