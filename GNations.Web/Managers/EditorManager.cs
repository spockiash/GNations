using GNations.Models;
using GNations.Resources;
using GNations.Resources.Helpers;

namespace GNations.Web.Managers
{
    public static class EditorManager
    {
        public static void AddItem(EditorAddModel addModel, MapStateModel mapState, EditorImagesModel images, int posX, int posY)
        {
            if(addModel.AddContinent != null && images.ContinentImages != null)
            {
                var continentCounter = mapState.Continents.Count;
                var continentLimit = images.ContinentImages.Count;
                if(continentCounter < continentLimit)
                {
                    AddContinent(mapState.Continents, images.ContinentImages.ToArray(), continentCounter, posX, posY);
                    addModel.PromptMessage = $"Continent added at coordinates {posX}:{posY}";
                }
                else
                {
                    addModel.PromptMessage = $"Limit reached";
                }
            }
        }

        public static ContinentDisplayModel GetSingleContinent(EditorAddModel addModel, MapStateModel mapState, EditorImagesModel images, int posX, int posY)
        {
            if (addModel.AddContinent != null && images.ContinentImages != null)
            {
                var continentCounter = mapState.Continents.Count;
                var continentLimit = images.ContinentImages.Count;
                if (continentCounter < continentLimit)
                {
                    AddContinent(mapState.Continents, images.ContinentImages.ToArray(), continentCounter, posX, posY);
                    addModel.PromptMessage = $"Continent added at coordinates {posX}:{posY}";
                }
                else
                {
                    addModel.PromptMessage = $"Limit reached";
                }
            }

            var returnVal = mapState.Continents.Last();
            mapState.Continents.Remove(returnVal);
            return returnVal;
        }


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
                BaseScale = 1.00f,
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
