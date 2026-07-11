using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Unified_Modeling_Language_.House
{
    public class HomeWithSwimmingPool : HomeRequirements
    {
        public HomeWithSwimmingPool(string wall, string window, string door, string roof, bool hasSwimmingPool) : base(wall, window, door, roof)
        {
            this.hasSwimmingPool = hasSwimmingPool;
        }
        public bool hasSwimmingPool { get; set; }

        public override string ToString() =>
$@"Wall : {Wall}
Window : {Window}
Door : {Door}
Roof : {Roof}
SwimmingPool : {hasSwimmingPool}
";
    }
}
