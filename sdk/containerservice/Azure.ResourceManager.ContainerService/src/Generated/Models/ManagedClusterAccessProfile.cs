// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Managed cluster Access Profile. </summary>
    public partial class ManagedClusterAccessProfile : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ManagedClusterAccessProfile. </summary>
        /// <param name="location"> The location. </param>
        public ManagedClusterAccessProfile(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ManagedClusterAccessProfile. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="kubeConfig"> Base64-encoded Kubernetes configuration file. </param>
        internal ManagedClusterAccessProfile(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, byte[] kubeConfig) : base(id, name, resourceType, systemData, tags, location)
        {
            KubeConfig = kubeConfig;
        }

        /// <summary> Base64-encoded Kubernetes configuration file. </summary>
        public byte[] KubeConfig { get; set; }
    }
}
