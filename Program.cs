#region software_information
// Author: Noah Fogarty
// Created: 10-Nov-2022
// Version: 1.0

string version = "1.0";
Console.WriteLine("Kingdom Score Calculator - {0}", version);

Console.WriteLine("\n");
#endregion

#region variables
int totalEstates; // Worth 1 point.
int totalDuchies; // Worth 3 points.
int totalProvinces; // Worth 6 points.
int totalScore;
#endregion

#region console_output
// Asks user to input how many estates, duchies and provinces they have.
Console.WriteLine("How many estates do you have?");
totalEstates = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many duchies do you have?");
totalDuchies = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many provinces do you have?");
totalProvinces = Convert.ToInt32(Console.ReadLine());

// Calculates total score based on above answers.
// Estates are worth 1 point, duchies are worth 3 points, and provinces are worth 6 points.
totalScore = totalEstates + (totalDuchies * 3) + (totalProvinces * 6);

Console.WriteLine("\n");

Console.WriteLine("Your total score is {0}", totalScore);

Console.ReadLine(); // Pauses program.
#endregion
