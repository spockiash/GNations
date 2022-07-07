using GNations.Models;
using GNations.Resources;
using GNations.Resources.Helpers;

namespace GNations.Web.Managers
{
    public static class EditorManager
    {
        public static void AddContinent(List<ContinentDisplayModel> continents, int posX, int posY)
        {

            continents.Add(new ContinentDisplayModel()
            {
                SvgMarkup = ImageRepository.GetSingleContinentImage(),
                StyleAttribute = DisplayHelper.GetStyleAttributesForPosition(posY, posX),
                RelativeLeft = posX,
                RelativeTop = posY,
                PositionLeft = posX,
                PositionTop = posY,
            });

        }
    }
}
