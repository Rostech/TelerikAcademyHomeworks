
namespace Extension_Delegates_AndOther
{
    using System;
    using System.Text;

    /*
      1. StringBuilder.Substring

        Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

    */

    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder strB, int index, int length)
        {
            if(index + length > strB.Length)
                throw new Exception("Substring is going out of the length of the string");
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < length; i ++)
            {
                result.Append(strB[index + i]);
            }
            return result;
        }
    }
}
