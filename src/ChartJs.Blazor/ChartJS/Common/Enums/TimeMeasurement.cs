﻿using ChartJs.Blazor.ChartJS.Common.Enums.JsonConverter;
using System.Text.Json.Serialization;

namespace ChartJs.Blazor.ChartJS.Common.Enums
{
    /// <summary>
    /// As per documentation here https://www.chartjs.org/docs/latest/axes/cartesian/time.html#time-units
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumReader<TimeMeasurement>))]
    public sealed class TimeMeasurement : StringEnum
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static TimeMeasurement Millisecond => new TimeMeasurement("millisecond");
        public static TimeMeasurement Second => new TimeMeasurement("second");
        public static TimeMeasurement Minute => new TimeMeasurement("minute");
        public static TimeMeasurement Hour => new TimeMeasurement("hour");
        public static TimeMeasurement Day => new TimeMeasurement("day");
        public static TimeMeasurement Week => new TimeMeasurement("week");
        public static TimeMeasurement Month => new TimeMeasurement("month");
        public static TimeMeasurement Quarter => new TimeMeasurement("quarter");
        public static TimeMeasurement Year => new TimeMeasurement("year");
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        private TimeMeasurement(string stringRep) : base(stringRep) { }
    }
}