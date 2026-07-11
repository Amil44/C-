using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Unified_Modeling_Language_.House
{
    public class HomeWithFancyStatues : HomeRequirements
    {
        public HomeWithFancyStatues(string wall, string window, string door, string roof, bool hasSatatues) : base(wall, window, door, roof)
        {
            this.hasSatatues = hasSatatues;
        }

        public bool hasSatatues { get; set; }
        public override string ToString() =>
$@"Wall : {Wall}
Window : {Window}
Door : {Door}
Roof : {Roof}
Satatues : {hasSatatues}
";
    }
}
