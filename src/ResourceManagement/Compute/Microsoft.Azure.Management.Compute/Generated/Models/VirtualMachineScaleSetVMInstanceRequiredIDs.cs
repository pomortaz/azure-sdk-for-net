// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Specifies the list of virtual machine scale set instance IDs.
    /// </summary>
    public partial class VirtualMachineScaleSetVMInstanceRequiredIDs
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMInstanceRequiredIDs class.
        /// </summary>
        public VirtualMachineScaleSetVMInstanceRequiredIDs() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMInstanceRequiredIDs class.
        /// </summary>
        public VirtualMachineScaleSetVMInstanceRequiredIDs(IList<string> instanceIds)
        {
            InstanceIds = instanceIds;
        }

        /// <summary>
        /// the virtual machine scale set instance ids.
        /// </summary>
        [JsonProperty(PropertyName = "instanceIds")]
        public IList<string> InstanceIds { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (InstanceIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InstanceIds");
            }
        }
    }
}
