// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Resources.Models
{
    /// <summary> An error response for a resource management request. </summary>
    public partial class CloudError
    {
        /// <summary> Initializes a new instance of CloudError. </summary>
        internal CloudError()
        {
        }

        /// <summary> Initializes a new instance of CloudError. </summary>
        /// <param name="error"> The resource management error response. </param>
        internal CloudError(ErrorResponse error)
        {
            Error = error;
        }

        /// <summary> The resource management error response. </summary>
        public ErrorResponse Error { get; }
    }
}
