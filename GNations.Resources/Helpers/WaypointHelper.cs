using GNations.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNations.Resources.Helpers
{
    public static class WaypointHelper
    {
        public static Tuple<int, int, int, int> GetCoordinatePairs(int x1, int y1, int x2, int y2)
        {
            return Tuple.Create(x1, y1, x2, y2);
        }

        public static List<Tuple<int, int, int, int>> GetWaypointLineCoordinates(IList<WaypointDisplayDto> waypoints)
        {
            var lines = new List<string>();
            var coordinates = new List<Tuple<int, int, int, int>>();

            foreach (var waypoint in waypoints)
            {
                var x0 = waypoint.Left + 15;
                var y0 = waypoint.Top + 15;



                var neighbors = waypoints.Where(i => waypoint.Neighbors.Contains(i.Id));

                foreach (var neighbor in neighbors)
                {
                    var x1 = neighbor.Left + 15;
                    var y1 = neighbor.Top + 15;
                    var next = GetCoordinatePairs(x0, y0, x1, y1);
                    if(!coordinates.Contains(next) && !IsSame(next))
                    {
                        coordinates.Add(next);
                    }
                }

                //foreach(var neighbor in neighbors)
                //{
                //    var x1 = neighbor.Left + 15;
                //    var y1 = neighbor.Top + 15;
                //    var lineMarkup = $"<line x1='{x0}' y1='{y1}' x2='{x1}' y2='{y1}'/>";
                //    if (!lines.Contains(lineMarkup))
                //    {
                //        lines.Add(lineMarkup);
                //    }
                //}

                var xzx = 1;
            }

            var x = waypoints.Select(w => new
            {
                w.Top,
                w.Left,
                w.Neighbors
            });

            return coordinates;
        }

        private static bool IsSame(Tuple<int, int, int, int> coordinates)
        {
            var x0 = coordinates.Item1;
            var y0 = coordinates.Item2;
            var x1 = coordinates.Item3;
            var y1 = coordinates.Item4;

            if(x0 == x1 && y0 == y1)
            {
                return true;
            }

            return false;
        }
    }
}
