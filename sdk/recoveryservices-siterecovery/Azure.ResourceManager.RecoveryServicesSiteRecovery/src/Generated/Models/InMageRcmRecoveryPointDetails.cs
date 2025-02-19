// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm provider specific recovery point details. </summary>
    public partial class InMageRcmRecoveryPointDetails : ProviderSpecificRecoveryPointDetails
    {
        /// <summary> Initializes a new instance of InMageRcmRecoveryPointDetails. </summary>
        internal InMageRcmRecoveryPointDetails()
        {
            InstanceType = "InMageRcm";
        }

        /// <summary> Initializes a new instance of InMageRcmRecoveryPointDetails. </summary>
        /// <param name="instanceType"> Gets the provider type. </param>
        /// <param name="isMultiVmSyncPoint"> A value indicating whether the recovery point is multi VM consistent. </param>
        internal InMageRcmRecoveryPointDetails(string instanceType, string isMultiVmSyncPoint) : base(instanceType)
        {
            IsMultiVmSyncPoint = isMultiVmSyncPoint;
            InstanceType = instanceType ?? "InMageRcm";
        }

        /// <summary> A value indicating whether the recovery point is multi VM consistent. </summary>
        public string IsMultiVmSyncPoint { get; }
    }
}
