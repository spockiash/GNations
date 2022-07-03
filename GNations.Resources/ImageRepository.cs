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

        public static IList<ContinentImageDto> GetContinents()
        {
            var result = new List<ContinentImageDto>();
            var styleClasses = GetStyleClassesDictionary();

            result.Add(new ContinentImageDto 
            { 
                SvgMarkup = Encoding.Default.GetString(MapResources.Continent2),
                StyleClas = styleClasses.GetValueOrDefault(2),
                EnumNo = 2 });
            result.Add(new ContinentImageDto 
            {
                SvgMarkup = Encoding.Default.GetString(MapResources.Continent3),
                StyleClas = styleClasses.GetValueOrDefault(3),
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
