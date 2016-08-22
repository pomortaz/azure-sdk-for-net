// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
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
    /// Parameters for creating or updating a vault
    /// </summary>
    public partial class VaultCreateOrUpdateParameters : IResource
    {
        /// <summary>
        /// Initializes a new instance of the VaultCreateOrUpdateParameters
        /// class.
        /// </summary>
        public VaultCreateOrUpdateParameters()
        {
            Properties = new VaultProperties();
        }

        /// <summary>
        /// Initializes a new instance of the VaultCreateOrUpdateParameters
        /// class.
        /// </summary>
        /// <param name="location">The supported Azure location where the key
        /// vault should be created.</param>
        /// <param name="properties">Properties of the vault</param>
        /// <param name="tags">The tags that will be assigned to the key
        /// vault. </param>
        public VaultCreateOrUpdateParameters(string location, VaultProperties properties, IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Properties = new VaultProperties();
            Location = location;
            Tags = tags;
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the supported Azure location where the key vault
        /// should be created.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the tags that will be assigned to the key vault.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

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
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
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
