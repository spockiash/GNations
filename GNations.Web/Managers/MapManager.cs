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
    }
}
