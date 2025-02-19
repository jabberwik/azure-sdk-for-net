// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class DeliveryConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DeliveryMode))
            {
                writer.WritePropertyName("deliveryMode"u8);
                writer.WriteStringValue(DeliveryMode.Value.ToString());
            }
            if (Optional.IsDefined(Queue))
            {
                writer.WritePropertyName("queue"u8);
                writer.WriteObjectValue(Queue);
            }
            writer.WriteEndObject();
        }

        internal static DeliveryConfiguration DeserializeDeliveryConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DeliveryMode> deliveryMode = default;
            Optional<QueueInfo> queue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deliveryMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deliveryMode = new DeliveryMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queue = QueueInfo.DeserializeQueueInfo(property.Value);
                    continue;
                }
            }
            return new DeliveryConfiguration(Optional.ToNullable(deliveryMode), queue.Value);
        }
    }
}
