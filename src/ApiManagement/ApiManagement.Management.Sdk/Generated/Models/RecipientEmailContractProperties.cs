// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Recipient Email Contract Properties.
    /// </summary>
    public partial class RecipientEmailContractProperties
    {
        /// <summary>
        /// Initializes a new instance of the RecipientEmailContractProperties class.
        /// </summary>
        public RecipientEmailContractProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecipientEmailContractProperties class.
        /// </summary>

        /// <param name="email">User Email subscribed to notification.
        /// </param>
        public RecipientEmailContractProperties(string email = default(string))

        {
            this.Email = email;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets user Email subscribed to notification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "email")]
        public string Email {get; set; }
    }
}