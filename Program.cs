#region variables
double triangleBase;
double triangleHeight;
double triangleArea;
#endregion

#region software_information
string version = "1.0";
Console.WriteLine("Triangle Area Calculator - Version {0}", version);
Console.WriteLine("\n");
#endregion

#region console_output
// Asks user to input the base of their triangle to be calculated later.
Console.WriteLine("Please input the base of your triangle.");
triangleBase = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n");

Console.WriteLine("Base = {0}", triangleBase);

Console.WriteLine("\n");

// Asks user to input the height of their triangle to be calculated later.
Console.WriteLine("Please input the height of your triangle.");
triangleHeight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n");

Console.WriteLine("Height = {0}", triangleHeight);

Console.WriteLine("\n");

// Calculates the area of user's triangle by utilizing the data from earlier.
triangleArea = triangleBase * triangleHeight / 2;
Console.WriteLine("The total area of your triangle is {0}", triangleArea);

Console.ReadLine(); // Pauses program.
#endregion