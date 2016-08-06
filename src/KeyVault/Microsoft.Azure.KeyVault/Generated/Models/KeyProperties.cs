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
    /// Properties of the key pair backing a certificate.
    /// </summary>
    public partial class KeyProperties
    {
        /// <summary>
        /// Initializes a new instance of the KeyProperties class.
        /// </summary>
        public KeyProperties() { }

        /// <summary>
        /// Initializes a new instance of the KeyProperties class.
        /// </summary>
        /// <param name="exportable">Indicates if the private key can be
        /// exported.</param>
        /// <param name="keyType">The key type.</param>
        /// <param name="keySize">The key size in bytes. e.g. 1024 or
        /// 2048.</param>
        /// <param name="reuseKey">Indicates if the same key pair will be used
        /// on certificate renewal.</param>
        public KeyProperties(bool? exportable = default(bool?), string keyType = default(string), int? keySize = default(int?), bool? reuseKey = default(bool?))
        {
            Exportable = exportable;
            KeyType = keyType;
            KeySize = keySize;
            ReuseKey = reuseKey;
        }

        /// <summary>
        /// Gets or sets indicates if the private key can be exported.
        /// </summary>
        [JsonProperty(PropertyName = "exportable")]
        public bool? Exportable { get; set; }

        /// <summary>
        /// Gets or sets the key type.
        /// </summary>
        [JsonProperty(PropertyName = "kty")]
        public string KeyType { get; set; }

        /// <summary>
        /// Gets or sets the key size in bytes. e.g. 1024 or 2048.
        /// </summary>
        [JsonProperty(PropertyName = "key_size")]
        public int? KeySize { get; set; }

        /// <summary>
        /// Gets or sets indicates if the same key pair will be used on
        /// certificate renewal.
        /// </summary>
        [JsonProperty(PropertyName = "reuse_key")]
        public bool? ReuseKey { get; set; }

    }
}