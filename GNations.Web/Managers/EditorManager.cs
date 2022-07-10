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

        public static HarborDisplayModel GetHarborModel(int posX, int posY)
        {
            var imageMarkup = ImageRepository.GetHarborICon();
            var styleAttribute = DisplayHelper.GetStyleAttributesForPosition(posY, posX);
            return new HarborDisplayModel()
            {
                Id = 0,
                Left = posX,
                Top = posY,
                SvgMarkup = imageMarkup,
                StyleAttribute = styleAttribute
            };
        }

        public static void RepositionHarbor(HarborDisplayModel harbor, int posX, int posY)
        {
            harbor.Left = posX;
            harbor.Top = posY;
            harbor.StyleAttribute = DisplayHelper.GetStyleAttributesForPosition(posY, posX);
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
                EnumNo = 8
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
