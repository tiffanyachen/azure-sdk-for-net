// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of the file system to mount on the compute cluster nodes.
    /// </summary>
    public partial class UnmanagedFileSystemReference
    {
        /// <summary>
        /// Initializes a new instance of the UnmanagedFileSystemReference
        /// class.
        /// </summary>
        public UnmanagedFileSystemReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UnmanagedFileSystemReference
        /// class.
        /// </summary>
        /// <param name="mountCommand">Command used to mount the unmanaged file
        /// system.</param>
        /// <param name="relativeMountPath">Specifies the relative path on the
        /// compute cluster node where the file system will be mounted.</param>
        public UnmanagedFileSystemReference(string mountCommand, string relativeMountPath)
        {
            MountCommand = mountCommand;
            RelativeMountPath = relativeMountPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets command used to mount the unmanaged file system.
        /// </summary>
        [JsonProperty(PropertyName = "mountCommand")]
        public string MountCommand { get; set; }

        /// <summary>
        /// Gets or sets specifies the relative path on the compute cluster
        /// node where the file system will be mounted.
        /// </summary>
        /// <remarks>
        /// Note that all cluster level unmanaged file system will be mounted
        /// under $AZ_BATCHAI_MOUNT_ROOT location and job level unmanaged file
        /// system will be mounted under $AZ_BATCHAI_JOB_MOUNT_ROOT.
        /// </remarks>
        [JsonProperty(PropertyName = "relativeMountPath")]
        public string RelativeMountPath { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MountCommand == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MountCommand");
            }
            if (RelativeMountPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RelativeMountPath");
            }
        }
    }
}
