#region variables
byte varByte = 255;
sbyte varSByte = 127;
short varShort = 32_000;
ushort varUShort = 64_000;
int varInt = 2_100_000_000;
uint varUInt = 4_200_000_000;
long varLong = 9_000_000_000_000_000_000;
ulong varULong = 18_000_000_000_000_000_000;
float varFloat = 3.147f;
double varDouble = 3.147;
decimal varDecimal = 3.147m;
string varString = "Hello, World!";
char varChar = 'c';
bool varBool = true;
#endregion

#region console_output
// Prints out all of the above declared variables.
Console.WriteLine(varByte + "\n" +
    varSByte + "\n" +
    varShort + "\n" +
    varUShort + "\n" +
    varInt + "\n" +
    varUInt + "\n" +
    varLong + "\n" +
    varULong + "\n" +
    varFloat + "\n" +
    varDouble + "\n" +
    varDecimal + "\n" +
    varString + "\n" +
    varChar + "\n" +
    varBool);

Console.ReadLine(); // Used to pause the program.
#endregion