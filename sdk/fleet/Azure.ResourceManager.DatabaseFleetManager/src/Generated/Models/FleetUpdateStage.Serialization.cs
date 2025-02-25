// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DatabaseFleetManager.Models
{
    public partial class FleetUpdateStage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsCollectionDefined(Groups))
            {
                writer.WritePropertyName("groups"u8);
                writer.WriteStartArray();
                foreach (var item in Groups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AfterStageWaitInSeconds))
            {
                writer.WritePropertyName("afterStageWaitInSeconds"u8);
                writer.WriteNumberValue(AfterStageWaitInSeconds.Value);
            }
            writer.WriteEndObject();
        }

        internal static FleetUpdateStage DeserializeFleetUpdateStage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<IList<FleetUpdateGroup>> groups = default;
            Optional<int> afterStageWaitInSeconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FleetUpdateGroup> array = new List<FleetUpdateGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FleetUpdateGroup.DeserializeFleetUpdateGroup(item));
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("afterStageWaitInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    afterStageWaitInSeconds = property.Value.GetInt32();
                    continue;
                }
            }
            return new FleetUpdateStage(name, Optional.ToList(groups), Optional.ToNullable(afterStageWaitInSeconds));
        }
    }
}
