// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.EventHub.Models
{
    /// <summary> Properties to configure Identity for Bring your Own Keys. </summary>
    public partial class Identity
    {
        /// <summary> Initializes a new instance of Identity. </summary>
        public Identity()
        {
            Type = "SystemAssigned";
        }

        /// <summary> Initializes a new instance of Identity. </summary>
        /// <param name="principalId"> ObjectId from the KeyVault. </param>
        /// <param name="tenantId"> TenantId from the KeyVault. </param>
        /// <param name="type"> Enumerates the possible value Identity type, which currently supports only &apos;SystemAssigned&apos;. </param>
        internal Identity(string principalId, string tenantId, string type)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
        }

        /// <summary> ObjectId from the KeyVault. </summary>
        public string PrincipalId { get; set; }
        /// <summary> TenantId from the KeyVault. </summary>
        public string TenantId { get; set; }
        /// <summary> Enumerates the possible value Identity type, which currently supports only &apos;SystemAssigned&apos;. </summary>
        public string Type { get; set; }
    }
}
