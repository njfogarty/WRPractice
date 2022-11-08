/* The region below is used to store
 * all of the necessary variables
 * for this program to properly work. */

#region variables
// Used to store what kind of thing user is having named.
string a;
// Used to store a user-defined descriptor of the thing being named.
string b;
// Used to store an additional hardcoded descriptor.
string c;
// Stores pre-defined version number of unnamed thing, for added flare.
string d;
#endregion

#region console_output
// Asks user to specify what kind of thing is being named.
Console.WriteLine("What kind of thing are we talking about?");
a = Console.ReadLine();

// Asks user to provide an additional descriptor of the thing being named.
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
b = Console.ReadLine();

// Decides the pre-defined descriptor and version number for the thing being named.
c = "of Doom";
d = "3000";

// Prints out to console the final name.
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");
#endregion

Console.ReadLine(); // Pauses program.