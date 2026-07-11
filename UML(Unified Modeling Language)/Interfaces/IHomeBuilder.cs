using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Unified_Modeling_Language_.House;

namespace UML_Unified_Modeling_Language_.Interfaces
{
    public interface IHomeBuilder
    {
        void BuildWalls(string item);
        void BuildDoors(string item);
        void BuildWindows(string item);
        void BuildRoofs(string item);
    }

    public interface IBuilderGarage
    {
        void BuildGarage(bool item);
    }
    public interface IBuilderGarden
    {
        void BuildGarden(bool item);
    }
    public interface IBuilderFancyStatues
    {
        void BuildFancyStatues(bool item);
    }
    public interface IBuilderSwimmingPool
    {
        void BuildSwimmingPool(bool item);
    }

    public class ClassHomeBuilderGarage : HomeWithGarage, IHomeBuilder, IBuilderGarage
    {
        public ClassHomeBuilderGarage(string wall, string window, string door, string roof, bool hasGarage) : base(wall, window, door, roof, hasGarage)
        {
        }

        public void BuildDoors(string door)
        {
            Console.WriteLine($"Building {door}");
        }

        public void BuildGarage(bool hasGarage)
        {
            Console.WriteLine($"Building {hasGarage}");
        }

        public void BuildRoofs(string roof)
        {
            Console.WriteLine($"Building {roof}");
        }

        public void BuildWalls(string wall)
        {
            Console.WriteLine($"Building {wall}");
        }

        public void BuildWindows(string window)
        {
            Console.WriteLine($"Building {window}");
        }
    }
    public class ClassHomeBuilderGarden : HomeWithGarden, IHomeBuilder, IBuilderGarden
    {
        public ClassHomeBuilderGarden(string wall, string window, string door, string roof, bool hasGarden) : base(wall, window, door, roof, hasGarden)
        {
        }

        public void BuildDoors(string door)
        {
            Console.WriteLine($"Building {door}");
        }

        public void BuildGarden(bool hasGarden)
        {
            Console.WriteLine($"Building {hasGarden}");
        }

        public void BuildRoofs(string roof)
        {
            Console.WriteLine($"Building {roof}");
        }

        public void BuildWalls(string wall)
        {
            Console.WriteLine($"Building {wall}");
        }

        public void BuildWindows(string window)
        {
            Console.WriteLine($"Building {window}");
        }
    }
    public class ClassHomeBuilderFancyStatues : HomeWithFancyStatues, IHomeBuilder, IBuilderFancyStatues
    {
        public ClassHomeBuilderFancyStatues(string wall, string window, string door, string roof, bool hasSatatues) : base(wall, window, door, roof, hasSatatues)
        {
        }

        public void BuildDoors(string door)
        {
            Console.WriteLine($"Building {door}");
        }

        public void BuildFancyStatues(bool hasSatatues)
        {
            Console.WriteLine($"Building {hasSatatues}");
        }

        public void BuildRoofs(string roof)
        {
            Console.WriteLine($"Building {roof}");
        }

        public void BuildWalls(string wall)
        {
            Console.WriteLine($"Building {wall}");
        }

        public void BuildWindows(string window)
        {
            Console.WriteLine($"Building {window}");
        }
    }
    public class ClassHomeBuilderSwimmingPool : HomeWithSwimmingPool, IHomeBuilder, IBuilderSwimmingPool
    {
        public ClassHomeBuilderSwimmingPool(string wall, string window, string door, string roof, bool hasSwimmingPool) : base(wall, window, door, roof, hasSwimmingPool)
        {
        }

        public void BuildDoors(string door)
        {
            Console.WriteLine($"Building {door}");
        }

        public void BuildRoofs(string roof)
        {
            Console.WriteLine($"Building {roof}");
        }

        public void BuildSwimmingPool(bool hasSwimmingPool)
        {
            Console.WriteLine($"Building Swimming Pool: {hasSwimmingPool}");
        }

        public void BuildWalls(string wall)
        {
            Console.WriteLine($"Building {wall}");
        }

        public void BuildWindows(string window)
        {
            Console.WriteLine($"Building {window}");
        }
    }

}
