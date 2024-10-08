// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Additional information for the MAB workload-specific job.
    /// </summary>
    public partial class MabJobExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the MabJobExtendedInfo class.
        /// </summary>
        public MabJobExtendedInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MabJobExtendedInfo class.
        /// </summary>

        /// <param name="tasksList">List of tasks for this job.
        /// </param>

        /// <param name="propertyBag">The job properties.
        /// </param>

        /// <param name="dynamicErrorMessage">Non localized error message specific to this job.
        /// </param>
        public MabJobExtendedInfo(System.Collections.Generic.IList<MabJobTaskDetails> tasksList = default(System.Collections.Generic.IList<MabJobTaskDetails>), System.Collections.Generic.IDictionary<string, string> propertyBag = default(System.Collections.Generic.IDictionary<string, string>), string dynamicErrorMessage = default(string))

        {
            this.TasksList = tasksList;
            this.PropertyBag = propertyBag;
            this.DynamicErrorMessage = dynamicErrorMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets list of tasks for this job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tasksList")]
        public System.Collections.Generic.IList<MabJobTaskDetails> TasksList {get; set; }

        /// <summary>
        /// Gets or sets the job properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "propertyBag")]
        public System.Collections.Generic.IDictionary<string, string> PropertyBag {get; set; }

        /// <summary>
        /// Gets or sets non localized error message specific to this job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dynamicErrorMessage")]
        public string DynamicErrorMessage {get; set; }
    }
}