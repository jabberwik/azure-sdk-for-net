// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DatabaseFleetManager.Models
{
    internal partial class NodeImageSelectionStatus
    {
        internal static NodeImageSelectionStatus DeserializeNodeImageSelectionStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<NodeImageVersion>> selectedNodeImageVersions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedNodeImageVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NodeImageVersion> array = new List<NodeImageVersion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NodeImageVersion.DeserializeNodeImageVersion(item));
                    }
                    selectedNodeImageVersions = array;
                    continue;
                }
            }
            return new NodeImageSelectionStatus(Optional.ToList(selectedNodeImageVersions));
        }
    }
}
