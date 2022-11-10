#region software_information
// Author: Noah Fogarty
// Created: 10-Nov-2022

string version = "1.0";
Console.WriteLine("Chocolate Egg Divider - Version {0}", version);

Console.WriteLine("\n");
#endregion

#region console_output
// Asks user how many chocolate eggs there are.
Console.WriteLine("How many chocolate eggs are there?");
int chocolateEggs = Convert.ToInt32(Console.ReadLine()); 

// Calculates how many chocolate eggs to give to the four sisters, and how much is remaining to give to the duckbear.
int eggsDivided = chocolateEggs / 4;
int eggsRemainder = chocolateEggs % 4;
Console.WriteLine("The total eggs each sister gets is {0}, the duckbear gets {1}", eggsDivided, eggsRemainder);

Console.ReadLine(); // Pauses program.
#endregion