// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ApplicationInsights.Query.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An events query result.
    /// </summary>
    public partial class EventsResults
    {
        /// <summary>
        /// Initializes a new instance of the EventsResults class.
        /// </summary>
        public EventsResults()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventsResults class.
        /// </summary>
        /// <param name="odatacontext">OData context metadata endpoint for this
        /// response</param>
        /// <param name="aimessages">OData messages for this response.</param>
        /// <param name="value">Contents of the events query result.</param>
        public EventsResults(string odatacontext = default(string), IList<ErrorInfo> aimessages = default(IList<ErrorInfo>), IList<EventsResultData> value = default(IList<EventsResultData>))
        {
            Odatacontext = odatacontext;
            Aimessages = aimessages;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets oData context metadata endpoint for this response
        /// </summary>
        [JsonProperty(PropertyName = "@odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets oData messages for this response.
        /// </summary>
        [JsonProperty(PropertyName = "@ai.messages")]
        public IList<ErrorInfo> Aimessages { get; set; }

        /// <summary>
        /// Gets or sets contents of the events query result.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<EventsResultData> Value { get; set; }

    }
}
