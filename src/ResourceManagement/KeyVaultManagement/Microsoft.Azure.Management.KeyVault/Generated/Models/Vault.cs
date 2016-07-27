// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Resource information with extended details.
    /// </summary>
    public partial class Vault : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Vault class.
        /// </summary>
        public Vault() { }

        /// <summary>
        /// Initializes a new instance of the Vault class.
        /// </summary>
        /// <param name="name">The name of the key vault.</param>
        /// <param name="location">The supported Azure location where the key
        /// vault should be created.</param>
        /// <param name="properties">Properties of the vault</param>
        /// <param name="id">The Azure Resource Manager resource ID for the
        /// key vault.</param>
        /// <param name="type">The resource type of the key vault.</param>
        /// <param name="tags">The tags that will be assigned to the key
        /// vault. </param>
        public Vault(string name, string location, VaultProperties properties, string id = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(name, location, id, type, tags)
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets properties of the vault
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public VaultProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}
