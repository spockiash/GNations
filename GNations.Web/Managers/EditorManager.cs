using GNations.Models;
using GNations.Resources;
using GNations.Resources.Helpers;

namespace GNations.Web.Managers
{
    public static class EditorManager
    {
        public static void AddContinent(List<ContinentDisplayModel> continents, string[] continentImages, int counter, int posX, int posY)
        {

            continents.Add(new ContinentDisplayModel()
            {
                SvgMarkup = continentImages[counter],
                StyleAttribute = DisplayHelper.GetStyleAttributesForPosition(posY, posX),
                RelativeLeft = posX,
                RelativeTop = posY,
                PositionLeft = posX,
                PositionTop = posY,
            });

        }

        public static List<DropdownSelectorModel> GetAddOptions()
        {
            return new List<DropdownSelectorModel>() 
            {
                new DropdownSelectorModel()
                {
                    Id = 1,
                    Name = "AddContinent",
                    Description = "Add Continent"
                },
                new DropdownSelectorModel()
                {
                    Id = 2,
                    Name = "AddHarbor",
                    Description = "Add Harbor"
                },
                new DropdownSelectorModel()
                {
                    Id = 3,
                    Name = "AddWaypoint",
                    Description = "Add Waypoint"
                },
                new DropdownSelectorModel()
                {
                    Id = 4,
                    Name = "AddIsland",
                    Description = "Add Island"
                },
            };
        }
    }
}
