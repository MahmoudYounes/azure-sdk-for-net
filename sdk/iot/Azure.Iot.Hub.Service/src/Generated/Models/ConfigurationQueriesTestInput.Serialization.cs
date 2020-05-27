// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class ConfigurationQueriesTestInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (TargetCondition != null)
            {
                writer.WritePropertyName("targetCondition");
                writer.WriteStringValue(TargetCondition);
            }
            if (CustomMetricQueries != null)
            {
                writer.WritePropertyName("customMetricQueries");
                writer.WriteStartObject();
                foreach (var item in CustomMetricQueries)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }
    }
}