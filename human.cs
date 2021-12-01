using System;

namespace human
{
class Human
{
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;
     
    // add a public "getter" property to access health
     
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
     
    // Add a constructor to assign custom values to all fields
     
    // Build Attack method
    public int Health
    {
        get { return health; }
    }
    public Human()
    {
        Name="Kumari";
        Strength=1;
        Intelligence=1;
        Dexterity=1;
        health=50;
    }
    public Human(string name,int stre,int intell,int dex,int hth)
    {
        Name=name;
        Strength=stre;
        Intelligence=intell;
        Dexterity=dex;
        health=hth;

        
    }
     public int Attack(Human target)
    {
        int dmg = Strength * 5;
        target.health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.health;
    }
}
}
