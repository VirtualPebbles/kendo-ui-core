using Kendo.Mvc.Extensions;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI RadialGauge component
    /// </summary>
    public partial class RadialGauge 
    {
        public RadialGaugeGaugeAreaSettings GaugeArea { get; } = new RadialGaugeGaugeAreaSettings();

        public List<RadialGaugePointer> Pointer { get; set; } = new List<RadialGaugePointer>();

        public RadialGaugeScaleSettings Scale { get; } = new RadialGaugeScaleSettings();

        public bool? Transitions { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            var gaugeArea = GaugeArea.Serialize();
            if (gaugeArea.Any())
            {
                settings["gaugeArea"] = gaugeArea;
            }

            var pointer = Pointer.Select(i => i.Serialize());
            if (pointer.Any())
            {
                settings["pointer"] = pointer;
            }

            var scale = Scale.Serialize();
            if (scale.Any())
            {
                settings["scale"] = scale;
            }

            if (Transitions.HasValue)
            {
                settings["transitions"] = Transitions;
            }

            return settings;
        }
    }
}
