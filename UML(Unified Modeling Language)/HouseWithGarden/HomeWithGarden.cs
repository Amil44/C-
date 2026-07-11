using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Unified_Modeling_Language_.House
{
    public class HomeWithGarden : HomeRequirements
    {
        public HomeWithGarden(string wall, string window, string door, string roof, bool hasGarden) : base(wall, window, door, roof)
        {
            this.hasGarden = hasGarden;
        }
        public bool hasGarden { get; set; }
        public override string ToString() =>
$@"Wall : {Wall}
Window : {Window}
Door : {Door}
Roof : {Roof}
Garden : {hasGarden}
";
    }
}
