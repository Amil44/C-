using UML_Unified_Modeling_Language_.House;
using UML_Unified_Modeling_Language_.Interfaces;

List<ClassHomeBuilderGarage> homeBuilderGarage = new List<ClassHomeBuilderGarage>()
{
    new ClassHomeBuilderGarage("5 Wall","3 Normal Window","1 Black Door","Triangle Roof", true),
    new ClassHomeBuilderGarage("6 Wall","2 Tinted Window","2 Metal Door","Flat Roof", false),
};

List<ClassHomeBuilderGarden> homeBuilderGarden = new List<ClassHomeBuilderGarden>()
{
    new ClassHomeBuilderGarden("4 Wall","3 White Window","2 Blue Door","Circle Roof", true),
    new ClassHomeBuilderGarden("4 Wall","2 Wide Window","4 Brown Door","Square Roof", false),
};

List<ClassHomeBuilderFancyStatues> homeBuilderFancyStatues = new List<ClassHomeBuilderFancyStatues>()
{
    new ClassHomeBuilderFancyStatues("4 Wall","4 Normal Window","5 Red Door","Triangle Roof", true),
    new ClassHomeBuilderFancyStatues("5 Wall","5 Tinted Window","1 Wooden Door","Flat Roof", false),
};

List<ClassHomeBuilderSwimmingPool> homeBuilderSwimmingPool = new List<ClassHomeBuilderSwimmingPool>()
{
    new ClassHomeBuilderSwimmingPool("4 Wall","3 White Window","2 Blue Door","Circle Roof", true),
    new ClassHomeBuilderSwimmingPool("4 Wall","2 Wide Window","4 Brown Door","Square Roof", false),
};

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("=========== Home With Garage ===========");
Console.ResetColor();
foreach (var houese in homeBuilderGarage)
{
    Console.WriteLine(houese);
    houese.BuildDoors(homeBuilderGarage[0].Door);
    houese.BuildWalls(homeBuilderGarage[0].Wall);
    houese.BuildWindows(homeBuilderGarage[0].Window);
    houese.BuildRoofs(homeBuilderGarage[0].Roof);
    houese.BuildGarage(homeBuilderGarage[0].hasGarage);
    Console.WriteLine("==============================================");
}


Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("=========== Home With Garden ===========");
Console.ResetColor();
foreach (var houese in homeBuilderGarden)
{
    Console.WriteLine(houese);
    houese.BuildDoors(homeBuilderGarden[0].Door);
    houese.BuildWalls(homeBuilderGarden[0].Wall);
    houese.BuildWindows(homeBuilderGarden[0].Window);
    houese.BuildRoofs(homeBuilderGarden[0].Roof);
    houese.BuildGarden(homeBuilderGarden[0].hasGarden);
    Console.WriteLine("==============================================");
}

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("=========== Home With Fancy Statues ===========");
Console.ResetColor();
foreach (var houese in homeBuilderFancyStatues)
{ 
    Console.WriteLine(houese);
    houese.BuildDoors(homeBuilderFancyStatues[0].Door);
    houese.BuildWalls(homeBuilderFancyStatues[0].Wall);
    houese.BuildWindows(homeBuilderFancyStatues[0].Window);
    houese.BuildRoofs(homeBuilderFancyStatues[0].Roof);
    houese.BuildFancyStatues(homeBuilderFancyStatues[0].hasSatatues);
    Console.WriteLine("==============================================");
}

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("=========== Home With Swimming Pool ===========");
Console.ResetColor();
foreach (var houese in homeBuilderSwimmingPool)
{ 
    Console.WriteLine(houese);
    houese.BuildDoors(homeBuilderSwimmingPool[0].Door);
    houese.BuildWalls(homeBuilderSwimmingPool[0].Wall);
    houese.BuildWindows(homeBuilderSwimmingPool[0].Window);
    houese.BuildRoofs(homeBuilderSwimmingPool[0].Roof);
    houese.BuildSwimmingPool(homeBuilderSwimmingPool[0].hasSwimmingPool);
    Console.WriteLine("==============================================");
}

// Problem: https://refactoring.guru/design-patterns/builder 
// UML Link1: https://lucid.app/lucidchart/43b64054-519a-444c-a6c0-21fa74a065b3/edit?page=0_0&invitationId=inv_349e39d6-c8f8-4437-be48-df4d32a7b615#
// UML Link2: https://lucid.app/lucidchart/43b64054-519a-444c-a6c0-21fa74a065b3/edit?viewport_loc=-308%2C20%2C3238%2C1578%2C0_0&invitationId=inv_349e39d6-c8f8-4437-be48-df4d32a7b615

