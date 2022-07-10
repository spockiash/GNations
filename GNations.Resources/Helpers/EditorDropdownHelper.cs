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
                RelativeTop = continent.RelativeTop,
                BaseScale = continent.BaseScale,
                DisplayScaleInput = true
            };
        }

        public static MapDisplayBase HarborToBase(HarborDisplayModel harbor)
        {
            return new MapDisplayBase()
            {
                RelativeLeft = harbor.Left,
                RelativeTop = harbor.Top,
                DisplayScaleInput = false
            };
        }

        public static ContinentDisplayModel UpdateContinent(ContinentDisplayModel continent, MapDisplayBase baseModel)
        {
            var sb = new StringBuilder();
            sb.Append(DisplayHelper.GetStyleAttributesForPosition(baseModel.RelativeTop, baseModel.RelativeLeft));
            sb.Append(DisplayHelper.GetStyleAttributesForScaling(baseModel.BaseScale, 0));
            continent.RelativeLeft = baseModel.RelativeLeft;
            continent.PositionLeft = baseModel.RelativeLeft;
            continent.RelativeTop = baseModel.RelativeTop;
            continent.PositionTop = baseModel.RelativeTop;
            continent.StyleAttribute = sb.ToString();
            return continent;
        }
    }
}
