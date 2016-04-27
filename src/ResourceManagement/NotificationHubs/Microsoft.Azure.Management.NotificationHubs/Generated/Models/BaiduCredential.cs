// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Description of a NotificationHub BaiduCredential.
    /// </summary>
    public partial class BaiduCredential
    {
        /// <summary>
        /// Initializes a new instance of the BaiduCredential class.
        /// </summary>
        public BaiduCredential() { }

        /// <summary>
        /// Initializes a new instance of the BaiduCredential class.
        /// </summary>
        public BaiduCredential(BaiduCredentialProperties properties = default(BaiduCredentialProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets properties of NotificationHub BaiduCredential.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public BaiduCredentialProperties Properties { get; set; }

    }
}
