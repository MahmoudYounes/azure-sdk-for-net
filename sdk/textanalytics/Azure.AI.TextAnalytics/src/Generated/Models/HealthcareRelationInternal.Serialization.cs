// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    internal partial class HealthcareRelationInternal
    {
        internal static HealthcareRelationInternal DeserializeHealthcareRelationInternal(JsonElement element)
        {
            string relationType = default;
            bool bidirectional = default;
            string source = default;
            string target = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relationType"))
                {
                    relationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bidirectional"))
                {
                    bidirectional = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
            }
            return new HealthcareRelationInternal(relationType, bidirectional, source, target);
        }
    }
}
