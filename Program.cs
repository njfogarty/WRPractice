#region software_information
// Author: Noah Fogarty
// Created: 11-Nov-2022
// Version: 1.0

Console.Title = "Defense of Consolas";
string version = "1.0.0";
Console.WriteLine("Defense of Consolas - Version {0}", version);

Console.WriteLine("\n");
#endregion

#region variables
int row;
int column;
int calculatedRow; // Used to temporary store calculated result.
int calculatedColumn; // Used to temporary store calculated result.
#endregion

#region console_output
// Asks user to input a row and column.
Console.Write("Target Row? ");
row = Convert.ToInt32(Console.ReadLine());
row = Math.Clamp(row, 1, 8); // Prevents user from specifying a row outside of range.

Console.Write("Target Column? ");
column = Convert.ToInt32(Console.ReadLine());
column = Math.Clamp(column, 1, 8); // Prevents user from specifying a column outside of range.

Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Black;

// Bulk of the calculations are done below, prints out a diamond-esque shape surrounding the specified city block.
// Clamps are used in order to prevent the diamond from forming outside of range.
calculatedColumn = Math.Clamp(column - 1, 1, 8);
Console.WriteLine($"({row}, {calculatedColumn})");

calculatedRow = Math.Clamp(row - 1, 1, 8);
Console.WriteLine($"({calculatedRow}, {column})");

calculatedColumn = Math.Clamp(column + 1, 1, 8);
Console.WriteLine($"({row}, {calculatedColumn})");

calculatedRow = Math.Clamp(row + 1, 1, 8);
Console.WriteLine($"({column}, {calculatedRow})");

Console.Beep(); // Plays audio cue to notify user that calculations have completed.

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;

Console.ReadKey(true); // Pauses program.
#endregion