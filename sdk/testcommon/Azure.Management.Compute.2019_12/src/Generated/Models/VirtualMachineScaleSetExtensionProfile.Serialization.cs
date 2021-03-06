// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class VirtualMachineScaleSetExtensionProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Extensions != null)
            {
                writer.WritePropertyName("extensions");
                writer.WriteStartArray();
                foreach (var item in Extensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetExtensionProfile DeserializeVirtualMachineScaleSetExtensionProfile(JsonElement element)
        {
            IList<VirtualMachineScaleSetExtension> extensions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extensions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineScaleSetExtension> array = new List<VirtualMachineScaleSetExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(VirtualMachineScaleSetExtension.DeserializeVirtualMachineScaleSetExtension(item));
                        }
                    }
                    extensions = array;
                    continue;
                }
            }
            return new VirtualMachineScaleSetExtensionProfile(extensions);
        }
    }
}
