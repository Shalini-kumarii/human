using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human humanname1 = new Human();

            Human humanname = new Human("shalini",3,3,3,100);
        Console.WriteLine($"The name is{humanname1.Name}  {humanname1.Strength} {humanname1.Intelligence}{humanname1.Dexterity} {humanname1.Health}");
        Console.WriteLine(humanname.Name);
        Console.WriteLine(humanname.Strength);
        Console.WriteLine(humanname.Intelligence);
        Console.WriteLine(humanname.Dexterity);
        Console.WriteLine(humanname.Health);
        Human h = new Human();
        h.Attack(humanname);
        }
    }
}
