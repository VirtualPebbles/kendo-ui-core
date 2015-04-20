using Kendo.Mvc.Extensions;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI RadialGaugePointerCapSettings class
    /// </summary>
    public partial class RadialGaugePointerCapSettings 
    {
        public string Color { get; set; }

        public double? Size { get; set; }


        public RadialGauge RadialGauge { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (Size.HasValue)
            {
                settings["size"] = Size;
            }

            return settings;
        }
    }
}
