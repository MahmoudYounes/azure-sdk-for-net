// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class AutoPauseDelayTimeRange
    {
        internal static AutoPauseDelayTimeRange DeserializeAutoPauseDelayTimeRange(JsonElement element)
        {
            Optional<int> minValue = default;
            Optional<int> maxValue = default;
            Optional<int> stepSize = default;
            Optional<int> @default = default;
            Optional<PauseDelayTimeUnit> unit = default;
            Optional<int> doNotPauseValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minValue"))
                {
                    minValue = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxValue"))
                {
                    maxValue = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("stepSize"))
                {
                    stepSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("default"))
                {
                    @default = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = new PauseDelayTimeUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("doNotPauseValue"))
                {
                    doNotPauseValue = property.Value.GetInt32();
                    continue;
                }
            }
            return new AutoPauseDelayTimeRange(Optional.ToNullable(minValue), Optional.ToNullable(maxValue), Optional.ToNullable(stepSize), Optional.ToNullable(@default), Optional.ToNullable(unit), Optional.ToNullable(doNotPauseValue));
        }
    }
}