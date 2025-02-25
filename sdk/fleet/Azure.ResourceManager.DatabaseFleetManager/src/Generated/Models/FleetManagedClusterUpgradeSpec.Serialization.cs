// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DatabaseFleetManager.Models
{
    public partial class FleetManagedClusterUpgradeSpec : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(UpgradeType.ToString());
            if (Optional.IsDefined(KubernetesVersion))
            {
                writer.WritePropertyName("kubernetesVersion"u8);
                writer.WriteStringValue(KubernetesVersion);
            }
            writer.WriteEndObject();
        }

        internal static FleetManagedClusterUpgradeSpec DeserializeFleetManagedClusterUpgradeSpec(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FleetManagedClusterUpgradeType type = default;
            Optional<string> kubernetesVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new FleetManagedClusterUpgradeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kubernetesVersion"u8))
                {
                    kubernetesVersion = property.Value.GetString();
                    continue;
                }
            }
            return new FleetManagedClusterUpgradeSpec(type, kubernetesVersion.Value);
        }
    }
}
