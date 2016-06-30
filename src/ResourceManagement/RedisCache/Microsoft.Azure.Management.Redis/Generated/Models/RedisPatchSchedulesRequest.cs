// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Parameters to set patch schedules for redis cache.
    /// </summary>
    [JsonTransformation]
    public partial class RedisPatchSchedulesRequest
    {
        /// <summary>
        /// Initializes a new instance of the RedisPatchSchedulesRequest class.
        /// </summary>
        public RedisPatchSchedulesRequest() { }

        /// <summary>
        /// Initializes a new instance of the RedisPatchSchedulesRequest class.
        /// </summary>
        public RedisPatchSchedulesRequest(IList<ScheduleEntry> scheduleEntries)
        {
            ScheduleEntries = scheduleEntries;
        }

        /// <summary>
        /// Gets or sets list of patch schedules for redis cache.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scheduleEntries")]
        public IList<ScheduleEntry> ScheduleEntries { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (ScheduleEntries == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ScheduleEntries");
            }
            if (this.ScheduleEntries != null)
            {
                foreach (var element in this.ScheduleEntries)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
