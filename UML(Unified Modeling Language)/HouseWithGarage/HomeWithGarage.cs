using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Unified_Modeling_Language_.House
{
    public class HomeWithGarage : HomeRequirements
    {
        public HomeWithGarage(string wall, string window, string door, string roof, bool hasGarage) : base(wall, window, door, roof)
        {
            this.hasGarage = hasGarage;
        }
        public bool hasGarage { get; set; }
        public override string ToString() =>
$@"Wall : {Wall}
Window : {Window}
Door : {Door}
Roof : {Roof}
Garage : {hasGarage}
";
    }
}
