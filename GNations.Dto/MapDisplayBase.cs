using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNations.Models
{
    public class MapDisplayBase
    {
        public string? SvgMarkup { get; set; }
        public string? StyleAttribute { get; set; }
        public int RelativeTop { get; set; }
        public int RelativeLeft { get; set; }
        public int PositionTop { get; set; }
        public int PositionLeft { get; set; }
        public float BaseScale { get; set; }
        public bool DisplayScaleInput { get; set; }
    }
}
