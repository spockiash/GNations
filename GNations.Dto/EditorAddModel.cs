using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNations.Models
{
    public class EditorAddModel
    {
        public EditorAddModel()
        {
        }
        public EditorAddModel(ContinentDisplayModel addContinent)
        {
            AddContinent = addContinent;
        }

        public EditorAddModel(HarborDisplayModel addHarbor)
        {
            AddHarbor = addHarbor;
        }

        public EditorAddModel(WaypointDisplayModel addWaypoint)
        {
            AddWaypoint = addWaypoint;
        }

        public ContinentDisplayModel? AddContinent { get; private set; }
        public HarborDisplayModel? AddHarbor { get; private set; }
        public WaypointDisplayModel? AddWaypoint { get; private set; }
        public int Selection { get; set; }
        public string? PromptMessage { get; set; }
    }
}
