using GNations.Dto;
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

        public static List<WaypointDisplayDto> GetWaypoints()
        {
            var waypointIcon = GetWaypointIcon();
            return new List<WaypointDisplayDto>
            {
                new WaypointDisplayDto
                {
                    Id = 1,
                    Neighbors = new int[] { 2 },
                    SvgMarkup = waypointIcon,
                    Top = 171,
                    Left = 208,
                    StyleClass = GetMatchedClass(1,"waypoint")
                },
                new WaypointDisplayDto
                {
                    Id = 2,
                    Neighbors = new int[] { 1, 3 },
                    SvgMarkup = waypointIcon,
                    Top = 200,
                    Left = 400,
                    StyleClass = GetMatchedClass(2,"waypoint")
                },
                new WaypointDisplayDto
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

        public static List<HarborDisplayDto> GetHarbors()
        {
            var harborIcon = GetHarborICon();
            return new List<HarborDisplayDto>
            {
                new HarborDisplayDto
                {
                    Id = 1,
                    SvgMarkup = harborIcon,
                    Top = 171,
                    Left = 208,
                    StyleClass = GetMatchedClass(1,"harbor")
                },
                new HarborDisplayDto
                {
                    Id = 2,
                    SvgMarkup = harborIcon,
                    Top = 200,
                    Left = 400,
                    StyleClass = GetMatchedClass(2,"harbor")
                },
            };
        }

        public static IList<ContinentDisplayDto> GetContinents()
        {
            var result = new List<ContinentDisplayDto>();
            var styleClasses = GetStyleClassesDictionary();

            result.Add(new ContinentDisplayDto
            {
                SvgMarkup = Encoding.Default.GetString(MapResources.Continent2),
                StyleClas = styleClasses.GetValueOrDefault(2),
                RelativeTop = 50,
                RelativeLeft = 50,
                EnumNo = 2 });
            result.Add(new ContinentDisplayDto 
            {
                SvgMarkup = Encoding.Default.GetString(MapResources.Continent3),
                StyleClas = styleClasses.GetValueOrDefault(3),
                RelativeTop= 200,
                RelativeLeft = 200,
                EnumNo = 3 });

            return result;

        }

        public static Dictionary<int, string> GetStyleClassesDictionary()
        {
           return new Dictionary<int, string>()
            {
                { 2, "continent-c2" },
                { 3, "continent-c3" }
            };
        }


    }
}
