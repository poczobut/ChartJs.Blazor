﻿
using ChartJs.Blazor.ChartJS.Common.Enums.JsonConverter;
using System.Text.Json.Serialization;

namespace ChartJs.Blazor.ChartJS.Common.Enums
{
    /// <summary>
    /// As per documentation here https://www.chartjs.org/docs/latest/axes/cartesian/time.html#scale-distribution
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumReader<TimeDistribution>))]
    public sealed class TimeDistribution : StringEnum
    {
        /// <summary>
        /// Data are spread according to their time (distances can vary)
        /// </summary>
        public static TimeDistribution Linear => new TimeDistribution("linear");
        
        /// <summary>
        /// Data are spread at the same distance from each other
        /// </summary>
        public static TimeDistribution Series => new TimeDistribution("series");


        private TimeDistribution(string stringRep) : base(stringRep) { }
    }
}
