using System;

class DeclareVariables
{
    /*  1. Declare Variables

        Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, 
        short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
        Choose a large enough type for each number to ensure it will fit in it. Try to compile the code. */
     
    static void Main()
    {
        ushort unsignedShort = 52130;
        sbyte signedByte = -115;
        int integer = 4825932;
        byte byteInteger = 97;
        short shortInteger = -10000;
        Console.WriteLine("ushort = " + unsignedShort);
        Console.WriteLine("sbyte = " + signedByte);
        Console.WriteLine("int = " + integer);
        Console.WriteLine("byte = " + byteInteger);
        Console.WriteLine("short = " + shortInteger);
    }
}

