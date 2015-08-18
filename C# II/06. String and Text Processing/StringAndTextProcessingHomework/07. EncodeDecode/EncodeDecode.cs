using System;
using System.Text;

class EncodeDecode
{
    /*
      7. Encode/decode

        Write a program that encodes and decodes a string using given 
        encryption key (cipher).
        The key consists of a sequence of characters.
        The encoding/decoding is done by performing XOR (exclusive or) 
        operation over the first letter of the string with the first of 
        the key, the second – with the second, etc. When the last key 
        character is reached, the next is the first.

    */
    static void Main()
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();
        Console.Write("Enter keyWord: ");
        string keyWord = Console.ReadLine();
        StringBuilder strB = new StringBuilder();
        int keyWordIndex = 0;
        for(int i = 0; i < text.Length; i++)
        {
            if(text[i] != ' ')
            {
                if(keyWordIndex < keyWord.Length)
                {
                    strB.Append((char)(((keyWord[keyWordIndex] ^ text[i]) % 26) + 65));
                    Console.WriteLine(keyWord[keyWordIndex] ^ text[i]);
                    keyWordIndex++;
                }
                else
                {
                    keyWordIndex = 0;
                    strB.Append((char)(((keyWord[keyWordIndex] ^ text[i]) % 26) + 65));
                    Console.WriteLine(keyWord[keyWordIndex] ^ text[i]);
                    keyWordIndex++;
                }
            }
            else
            {
                strB.Append(' ');
            }
        }
        string encode = strB.ToString();
        encode = encode.ToLower();
        keyWordIndex = 0;
        Console.WriteLine("Encode: " + encode);
    }
}

