using GNations.Models;
using GNations.Resources.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNations.Resources
{
    public static class ImageRepository
    {

        public static string GetContinentMask()
        {
            return Encoding.Default.GetString(MapResources.Continent2);
        }

        public static string GetWaypointIcon()
        {
            return Encoding.Default.GetString(MapResources.icon_waypoint);
        }

        public static List<WaypointDisplayModel> GetWaypoints()
        {
            var waypointIcon = GetWaypointIcon();
            return new List<WaypointDisplayModel>
            {
                new WaypointDisplayModel
                {
                    Id = 1,
                    Neighbors = new int[] { 2 },
                    SvgMarkup = waypointIcon,
                    Top = 171,
                    Left = 208,
                    StyleClass = GetMatchedClass(1,"waypoint")
                },
                new WaypointDisplayModel
                {
                    Id = 2,
                    Neighbors = new int[] { 1, 3 },
                    SvgMarkup = waypointIcon,
                    Top = 200,
                    Left = 400,
                    StyleClass = GetMatchedClass(2,"waypoint")
                },
                new WaypointDisplayModel
                {
                    Id = 3,
                    Neighbors = new int[] { 2 },
                    SvgMarkup = waypointIcon,
                    Top = 200,
                    Left = 400,
                    StyleClass = GetMatchedClass(3,"waypoint")
                },
            };
        }

        public static string GetHarborICon()
        {
            return Encoding.Default.GetString(MapResources.icon_anchor);
        }

        public static string GetMatchedClass(int id, string classSpecifier)
        {
            return $"{classSpecifier}-{id}";
        }

        public static List<HarborDisplayModel> GetHarbors()
        {
            var harborIcon = GetHarborICon();
            return new List<HarborDisplayModel>
            {
                new HarborDisplayModel
                {
                    Id = 1,
                    SvgMarkup = harborIcon,
                    Top = 171,
                    Left = 208,
                    StyleClass = GetMatchedClass(1,"harbor")
                },
                new HarborDisplayModel
                {
                    Id = 2,
                    SvgMarkup = harborIcon,
                    Top = 200,
                    Left = 400,
                    StyleClass = GetMatchedClass(2,"harbor")
                },
            };
        }

        public static IList<ContinentDisplayModel> GetContinents()
        {
            var result = new List<ContinentDisplayModel>();
            var styleClasses = GetStyleClassesDictionary();

            result.Add(new ContinentDisplayModel
            {
                SvgMarkup = Encoding.Default.GetString(MapResources.Continent2),
                StyleAttribute = string.Empty,
                RelativeTop = 50,
                RelativeLeft = 50,
                BaseWidth = 120,
                BaseHeight = 74,
                EnumNo = 2 });
            result.Add(new ContinentDisplayModel 
            {
                SvgMarkup = Encoding.Default.GetString(MapResources.Continent3),
                StyleAttribute = string.Empty,
                RelativeTop= 200,
                BaseWidth = 120,
                BaseHeight = 66,
                RelativeLeft = 200,
                EnumNo = 3 });

            return result;

        }

        public static Dictionary<int, string> GetStyleClassesDictionary()
        {
           return new Dictionary<int, string>()
            {
                { 2, "style='position: absolute'" },
                { 3, "continent-c3" }
            };
        }


    }
}
