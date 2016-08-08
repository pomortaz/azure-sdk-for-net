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
    /// An array of 0 to 16 identities that have access to the key vault. All
    /// identities in the array must use the same tenant ID as the key
    /// vault's tenant ID.
    /// </summary>
    public partial class AccessPolicyEntry
    {
        /// <summary>
        /// Initializes a new instance of the AccessPolicyEntry class.
        /// </summary>
        public AccessPolicyEntry() { }

        /// <summary>
        /// Initializes a new instance of the AccessPolicyEntry class.
        /// </summary>
        /// <param name="tenantId">The Azure Active Directory tenant ID that
        /// should be used for authenticating requests to the key
        /// vault.</param>
        /// <param name="objectId">The object ID of a user or service
        /// principal in the Azure Active Directory tenant for the vault. The
        /// object ID must be unique for the list of access policies.</param>
        /// <param name="permissions">Permissions the identity has for keys
        /// and secrets</param>
        /// <param name="applicationId"> Application ID of the client making
        /// request on behalf of a principal</param>
        public AccessPolicyEntry(Guid tenantId, Guid objectId, Permissions permissions, Guid? applicationId = default(Guid?))
        {
            TenantId = tenantId;
            ObjectId = objectId;
            ApplicationId = applicationId;
            Permissions = permissions;
        }

        /// <summary>
        /// Gets or sets the Azure Active Directory tenant ID that should be
        /// used for authenticating requests to the key vault.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the object ID of a user or service principal in the
        /// Azure Active Directory tenant for the vault. The object ID must
        /// be unique for the list of access policies.
        /// </summary>
        [JsonProperty(PropertyName = "objectId")]
        public Guid ObjectId { get; set; }

        /// <summary>
        /// Gets or sets  Application ID of the client making request on
        /// behalf of a principal
        /// </summary>
        [JsonProperty(PropertyName = "applicationId")]
        public Guid? ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets permissions the identity has for keys, secrets and
        /// certificates
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public Permissions Permissions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Permissions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Permissions");
            }
        }
    }
}
