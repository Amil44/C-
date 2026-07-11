using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Unified_Modeling_Language_.House
{
    public class HomeRequirements
    {
        private string _wall;
        private string _window;
        private string _door;
        private string _roof;

        public HomeRequirements(string wall, string window, string door, string roof)
        {
            _wall = wall;
            _window = window;
            _door = door;
            _roof = roof;
        }

        public string Wall
        {
            get { return _wall; }
            set { _wall = value; }
        }

        public string Window
        {
            get { return _window; }
            set { _window = value; }
        }

        public string Door
        {
            get { return _door; }
            set { _door = value; }
        }

        public string Roof
        {
            get { return _roof; }
            set { _roof = value; }
        }
    }
}
