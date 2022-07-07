using GNations.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNations.Resources.Helpers
{
    public static class DisplayHelper
    {
        public static int MapSizeResolver(int viewportWidth, int viewportHeight)
        {
            var viewportRatio = (float)viewportHeight / (float)viewportWidth;
            if(viewportRatio <  0.65f)
            {
                float heigth = (float)viewportWidth * 0.5625f;
                return (int)Math.Round(heigth * 0.75f);
            }
            else
            {
                float heigth = (float)viewportWidth * 0.75f;
                return (int)Math.Round(heigth * 0.75f);
            }
        }
        public static Tuple<int, int> CalculateRelativePosition(int relativeTop, int relativeLeft, int containerWidth, int containerHeight)
        {
            float topCoefficient = (float)containerHeight / (float)GameConstants.RelativeTopSize;
            float leftCoefficient = (float)containerWidth / (float)GameConstants.RelativeLeftSize;
            return new Tuple<int, int>((int)Math.Round(topCoefficient * relativeTop), (int)Math.Round(leftCoefficient * relativeLeft));
        }

        public static Tuple<float, float> CalculateRelativeTransformation(int containerWidth, int containerHeight)
        {
            float topCoefficient = (float)containerHeight / (float)GameConstants.RelativeTopSize;
            float leftCoefficient = (float)containerWidth / (float)GameConstants.RelativeLeftSize;
            return new Tuple<float, float>(topCoefficient, leftCoefficient);
        }

        public static IEnumerable<ContinentDisplayModel> AssignStyleAttributes(IList<ContinentDisplayModel> continents)
        {
            foreach(var continent in continents)
            {
                var sb = new StringBuilder();
                sb.Append(GetStyleAttributesForPosition(continent.PositionTop, continent.PositionLeft));
                sb.Append(GetStyleAttributesForScaling(continent.ScaleTop, continent.ScaleLeft));
                continent.StyleAttribute = sb.ToString();
                yield return continent;
            }
        }

        public static string GetStyleAttributesForPosition(int top, int left)
        {
            return $"position: absolute; top: {top}px !important; left: {left}px !important;";
        }
        public static string GetStyleAttributesForScaling(float scaleTop, float scaleLeft)
        {
            //return $" transform-origin: 0 0; transform: scale({scaleLeft.ToString("F2", new CultureInfo("en-US"))}, {scaleTop.ToString("F2", new CultureInfo("en-US"))}) ;";
            return $" transform-origin: 0 0; transform: scale({scaleTop.ToString("F2", new CultureInfo("en-US"))}) ;";
        }
    }
}
