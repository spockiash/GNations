using GNations.Resources;
using System.Text;

namespace GNations.Web.Managers
{
    public static class MapManager
    {
        public static Tuple<int, int> GetMapDimensions(int width, int height)
        {
            var newHeight = height * 0.85;
            return new Tuple<int, int>(width, (int)Math.Round(newHeight));
        }

        public static string GetWaypointLines(int width, int heigth)
        {
            var waypoints = ImageRepository.GetWaypoints();

            var sb = new StringBuilder();
            sb.Append($"<svg viewBox='0 0 {width} {heigth}' xmlns='http://www.w3.org/2000/svg'>");
            sb.Append("<g fill='black' stroke='black' stroke-width='0.25'>");

            foreach(var point in waypoints)
            {

            }

            sb.Append("</g>");
            sb.Append("</svg>");



            return string.Empty;
        }

        public static string GetMapGrid(int width, int heigth, int upperPos, int leftPos)
        {
            var cellHeight = heigth / GameConstants.gridHorizontalLines;
            var cellWidth = width / GameConstants.gridVerticalLines;

            var sb = new StringBuilder();
            sb.Append($"<svg viewBox='0 0 {width} {heigth}' xmlns='http://www.w3.org/2000/svg'>");
            sb.Append("<g fill='black' stroke='black' stroke-width='0.25'>");
            //number of vertical cells
            var horPos = 0;
            for (int i = 0; i < GameConstants.gridHorizontalLines - 1; i++)
            {
                horPos += cellHeight;
                sb.Append($"<line x1='0' y1='{horPos}' x2='{width}' y2='{horPos}'/>");
            }
            var vertPos = 0;
            for(int i = 0; i < GameConstants.gridVerticalLines - 1; i++)
            {
                vertPos += cellWidth;
                sb.Append($"<line x1='{vertPos}' y1='0' x2='{vertPos}' y2='{heigth}'/>");
            }
            sb.Append("</g>");
            sb.Append("</svg>");

            return sb.ToString();
        }
    
        public static string GetWaypointLines(List<Tuple<int, int, int, int>> coordinates, int width, int heigth)
        {
            var sb = new StringBuilder();
            sb.Append($"<svg height='{heigth}' width='{width}' viewBox='0 0 {width} {heigth}' xmlns='http://www.w3.org/2000/svg'>");
            sb.Append("<g fill='black' stroke='black' stroke-width='0.25'>");
            //number of vertical cells
            foreach(var coord in coordinates)
            {
                var x0 = coord.Item1;
                var y0 = coord.Item2;
                var x1 = coord.Item3;
                var y1 = coord.Item4;

                sb.Append($"<line x1='{x0}' y1='{y0}' x2='{x1}' y2='{y1}'/>");
            }
            sb.Append("</g>");
            sb.Append("</svg>");

            return sb.ToString();
        }
    }
}
