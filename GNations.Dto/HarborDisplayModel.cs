using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNations.Models
{
    public class HarborDisplayModel
    {
        public int Id { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }
        public string SvgMarkup { get; set; }
        public string StyleAttribute { get; set; }
    }
}
