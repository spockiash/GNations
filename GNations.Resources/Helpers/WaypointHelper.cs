using GNations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNations.Resources.Helpers
{
    public static class WaypointHelper
    {
        public static void GetWaypointLineCoordinates(IList<WaypointDisplayModel> waypoints)
        {
            var lines = new List<string>();

            foreach (var waypoint in waypoints)
            {
                var x0 = waypoint.Left + 15;
                var y0 = waypoint.Top + 15;

                var nearestNeighbor = waypoints.Where(i => waypoint.Neighbors.Contains(i.Id));

                foreach(var neighbor in nearestNeighbor)
                {
                    var x1 = neighbor.Left + 15;
                    var y1 = neighbor.Top + 15;
                    var lineMarkup = $"<line x1='{x0}' y1='{y1}' x2='{x1}' y2='{y1}'/>";
                    if (!lines.Contains(lineMarkup))
                    {
                        lines.Add(lineMarkup);
                    }
                }

                var xzx = 1;
            }

            var x = waypoints.Select(w => new
            {
                w.Top,
                w.Left,
                w.Neighbors
            });
        }
    }
}
