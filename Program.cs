// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
int health = 100;
int energy = 100;
int wristbladesCost = 5;
int homingmissilesCost = 20;
int UnibeamCost = 25;
int MicrogunsCost = 15;
bool wristblades = false;
bool homingmissiles = false;
bool Unibeam = false;  
bool Microguns = false;



Console.WriteLine("Escape Doom's lair");
Console.WriteLine("I am Iron Man:");

string input = Console.ReadLine();

Console.WriteLine($"Iron Man said {input}");

Console.WriteLine("There is a Squad of Doom Bots heading your way. Do you think you can take them?");

Console.WriteLine("Jarvis can assist you with Hostile encounters would you like to have him activated");

 input = Console.ReadLine() ;

Console.WriteLine("Jarvis is now online. what would you like to use, wrist blades 5% Energy, Homing missiles 20 % Energy, Unibeam 25 % Energy, Micro Guns 15 % Energy, Your energy level is at 100%");

input = Console.ReadLine() ;

if (input == "wrist blades")
{
    energy -= wristbladesCost;
    wristblades = true;
}
else if (input == "homing missiles")
{
    energy -= homingmissilesCost;
    homingmissiles = true;
    

}
else if (input == "Unibeam")
{
    energy -= UnibeamCost;
    Unibeam = true;
    

}
else if (input == "Micro guns")
{
    energy -= MicrogunsCost;
    Microguns = true;
}

if (wristblades == true)
{
    Console.WriteLine("you used wrist blades");

}
else if (homingmissiles == true)
{
    Console.WriteLine("You used homing missiles");

}
else if (Unibeam == true)
{
    Console.WriteLine("you used Unibeam");

}
else if (wristblades == true)
{
    Console.WriteLine("you used Micro guns");

}
Console.WriteLine("hostiles nutralized sir.");

Console.WriteLine($"{energy} energy remaining.");

Console.WriteLine("Is tired of playing games hes sending in his lieutenants");

Console.WriteLine("There's three paths you can take one leads you towards Magneto the other leads you towards Electro and the last path leads to Machine Man");

Console.WriteLine("Pick a path but choose wisely"); 






