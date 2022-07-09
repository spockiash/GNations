using GNations.Models;
using GNations.Resources.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNations.Resources.Helpers
{
    public static class EditorDropdownHelper
    {
        public static EditorAddModel ResolveAddDropdownSelection(Tuple<int, string?> selection)
        {
            var selectedOption = (EditorDropdownEnum)selection.Item1;
            var returnItem = new EditorAddModel();
            switch (selectedOption)
            {
                case EditorDropdownEnum.AddContinent:
                    returnItem = new EditorAddModel(new ContinentDisplayModel());
                    break;
                case EditorDropdownEnum.AddHarbor:
                    returnItem = new EditorAddModel(new HarborDisplayModel());
                    break;
                case EditorDropdownEnum.AddWaypoint:
                    returnItem = new EditorAddModel(new WaypointDisplayModel());
                    break;
                case EditorDropdownEnum.AddIsland:
                    returnItem = new EditorAddModel(new ContinentDisplayModel());
                    break;
            }
            returnItem.Selection = selection.Item1;
            return returnItem;
        }


        public static MapDisplayBase ContinentToBase(ContinentDisplayModel continent)
        {
            return new MapDisplayBase()
            {
                RelativeLeft = continent.RelativeLeft,
                RelativeTop = continent.RelativeTop
            };
        }

        public static void UpdateContinent(ContinentDisplayModel continent, MapDisplayBase baseModel)
        {
            continent.RelativeLeft = baseModel.RelativeLeft;
            continent.PositionLeft = baseModel.RelativeLeft;
            continent.RelativeTop = baseModel.RelativeTop;
            continent.PositionTop = baseModel.RelativeTop;
            continent.StyleAttribute = DisplayHelper.GetStyleAttributesForPosition(baseModel.RelativeTop, baseModel.RelativeLeft);
        }
    }
}
