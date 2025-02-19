// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningSharedPrivateLinkResource. </summary>
    public partial class MachineLearningSharedPrivateLinkResource
    {
        /// <summary> Initializes a new instance of MachineLearningSharedPrivateLinkResource. </summary>
        public MachineLearningSharedPrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningSharedPrivateLinkResource. </summary>
        /// <param name="name"> Unique name of the private link. </param>
        /// <param name="groupId"> group id of the private link. </param>
        /// <param name="privateLinkResourceId"> the resource id that private link links to. </param>
        /// <param name="requestMessage"> Request message. </param>
        /// <param name="status"> Connection status of the service consumer with the service provider. </param>
        internal MachineLearningSharedPrivateLinkResource(string name, string groupId, ResourceIdentifier privateLinkResourceId, string requestMessage, MachineLearningPrivateEndpointServiceConnectionStatus? status)
        {
            Name = name;
            GroupId = groupId;
            PrivateLinkResourceId = privateLinkResourceId;
            RequestMessage = requestMessage;
            Status = status;
        }

        /// <summary> Unique name of the private link. </summary>
        public string Name { get; set; }
        /// <summary> group id of the private link. </summary>
        public string GroupId { get; set; }
        /// <summary> the resource id that private link links to. </summary>
        public ResourceIdentifier PrivateLinkResourceId { get; set; }
        /// <summary> Request message. </summary>
        public string RequestMessage { get; set; }
        /// <summary> Connection status of the service consumer with the service provider. </summary>
        public MachineLearningPrivateEndpointServiceConnectionStatus? Status { get; set; }
    }
}
