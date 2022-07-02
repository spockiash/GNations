
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
            return Encoding.Default.GetString(MapResources.C2_Out);
        }
    }
}
