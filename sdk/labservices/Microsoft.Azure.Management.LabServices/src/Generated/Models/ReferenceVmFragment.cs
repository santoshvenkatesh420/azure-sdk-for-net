// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of a Reference Vm
    /// </summary>
    public partial class ReferenceVmFragment
    {
        /// <summary>
        /// Initializes a new instance of the ReferenceVmFragment class.
        /// </summary>
        public ReferenceVmFragment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReferenceVmFragment class.
        /// </summary>
        /// <param name="userName">The username of the virtual machine</param>
        /// <param name="password">The password of the virtual machine. This
        /// will be set to null in GET resource API</param>
        public ReferenceVmFragment(string userName = default(string), string password = default(string))
        {
            UserName = userName;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the username of the virtual machine
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password of the virtual machine. This will be set
        /// to null in GET resource API
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

    }
}