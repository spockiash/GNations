using GNations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNations.Resources.Helpers
{
    public static class DisplayHelper
    {
        public static Tuple<int, int> CalculateRelativePosition(int relativeTop, int relativeLeft, int containerWidth, int containerHeight)
        {
            float topCoefficient = (float)containerHeight / (float)GameConstants.RelativeTopSize;
            float leftCoefficient = (float)containerWidth / (float)GameConstants.RelativeLeftSize;
            return new Tuple<int, int>((int)Math.Round(topCoefficient * relativeTop), (int)Math.Round(leftCoefficient * relativeLeft));
        }

        public static IEnumerable<ContinentDisplayModel> AssignStyleAttributes(IList<ContinentDisplayModel> continents)
        {
            foreach(var continent in continents)
            {
                continent.StyleAttribute = GetStyleAttributesForPosition(continent.PositionTop, continent.PositionLeft);
                yield return continent;
            }
        }

        public static string GetStyleAttributesForPosition(int top, int left)
        {
            return $"position: absolute; top: {top}px !important; left: {left}px !important;";
        }
    }
}
