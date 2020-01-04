﻿using ChartJs.Blazor.ChartJS.Common.Enums.JsonConverter;
using System.Text.Json.Serialization;

namespace ChartJs.Blazor.ChartJS.Common.Enums
{
    /// <summary>
    /// Specifies the border cap style.
    /// <para>As per documentation here https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineCap </para>
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumReader<BorderCapStyle>))]
    public sealed class BorderCapStyle : StringEnum
    {
        /// <summary>
        /// The ends of lines are squared off at the endpoints.
        /// </summary>
        public static BorderCapStyle Butt => new BorderCapStyle("butt");

        /// <summary>
        /// The ends of lines are rounded.
        /// </summary>
        public static BorderCapStyle Round => new BorderCapStyle("round");

        /// <summary>
        /// The ends of lines are squared off by adding a box with an equal width and half the height of the line's thickness.
        /// </summary>
        public static BorderCapStyle Square => new BorderCapStyle("square");

        /// <summary>
        /// Creates a new instance of the <see cref="BorderCapStyle"/> class.
        /// </summary>
        /// <param name="stringValue">The <see cref="string"/> value to set.</param>
        private BorderCapStyle(string stringValue) : base(stringValue) { }
    }
}
