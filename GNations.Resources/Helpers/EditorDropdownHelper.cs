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
            returnItem.Selection = selection.Item1;
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

            return returnItem;
        }
    }
}
