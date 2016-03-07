using Kendo.Mvc.Extensions;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GridSortableSettings class
    /// </summary>
    public partial class GridSortableSettings<T> where T : class 
    {
        public bool? AllowUnsort { get; set; }

        public GridSortMode? SortMode { get; set; }

        public bool? Enabled { get; set; }

        public Grid<T> Grid { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (AllowUnsort.HasValue)
            {
                settings["allowUnsort"] = AllowUnsort;
            }

            return settings;
        }
    }
}
