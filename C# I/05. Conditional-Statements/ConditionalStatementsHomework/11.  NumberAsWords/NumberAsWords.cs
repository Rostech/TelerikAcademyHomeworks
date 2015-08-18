using System;

class NumberAsWords
{   /*
        11.  Number as Words

        Write a program that converts a number in the range [0…999] to 
        words, corresponding to the English pronunciation.

    */
    static void Main()
    {
        Console.Write("Enter number [0...999]: ");
        int number = int.Parse(Console.ReadLine());
        while(number > 999 || number < 0)
        {
            Console.Write("Wrong number! Enter number [0...999]");
            number = int.Parse(Console.ReadLine());
        }
        string numberToString = number.ToString();
        Console.Write("Number as word: ");
        #region NumbersBetween100And999
        if (numberToString.Length == 3)
        {
            switch(numberToString[0])
            {
                case '1':
                    Console.Write("One");
                    break;
                case '2':
                    Console.Write("Two");
                    break;
                case '3':
                    Console.Write("Three");
                    break;
                case '4':
                    Console.Write("Four");
                    break;
                case '5':
                    Console.Write("Five");
                    break;
                case '6':
                    Console.Write("Six");
                    break;
                case '7':
                    Console.Write("Seven");
                    break;
                case '8':
                    Console.Write("Eight");
                    break;
                case '9':
                    Console.Write("Nine");
                    break;
                default:
                    break;
            }
            Console.Write(" hunred");
            if(numberToString[1] > '0' || numberToString [2] > '0')
            {
                Console.Write(" and");
            }
            switch (numberToString[1])
            {
                case '0':
                    break;
                case '1':
                    switch(numberToString[2])
                    {
                        case '0':
                            Console.Write(" ten");
                            break;
                        case '1':
                            Console.Write(" eleven");
                            break;
                        case '2':
                            Console.Write(" twelve");
                            break;
                        case '3':
                            Console.Write(" thirteen");
                            break;
                        case '4':
                            Console.Write(" fourteen");
                            break;
                        case '5':
                            Console.Write(" fifteen");
                            break;
                        case '6':
                            Console.Write(" sixteen");
                            break;
                        case '7':
                            Console.Write(" seventeen");
                            break;
                        case '8':
                            Console.Write(" eighteen");
                            break;
                        case '9':
                            Console.Write(" nineteen");
                            break;
                        default:
                            break;
                    }
                    break;
                case '2':
                    Console.Write(" twenty");
                    break;
                case '3':
                    Console.Write(" thirty");
                    break;
                case '4':
                    Console.Write(" fourty");
                    break;
                case '5':
                    Console.Write(" fifty");
                    break;
                case '6':
                    Console.Write(" sixty");
                    break;
                case '7':
                    Console.Write(" seventy");
                    break;
                case '8':
                    Console.Write(" eighty");
                    break;
                case '9':
                    Console.Write(" ninety");
                    break;
                default:
                    break;
            }
            if (numberToString[1] != '1')
            {
                switch (numberToString[2])
                {
                    case '1':
                        Console.Write(" one");
                        break;
                    case '2':
                        Console.Write(" two");
                        break;
                    case '3':
                        Console.Write(" three");
                        break;
                    case '4':
                        Console.Write(" four");
                        break;
                    case '5':
                        Console.Write(" five");
                        break;
                    case '6':
                        Console.Write(" six");
                        break;
                    case '7':
                        Console.Write(" seven");
                        break;
                    case '8':
                        Console.Write(" eight");
                        break;
                    case '9':
                        Console.Write(" nine");
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
        #region NumbersBetween10And99
        if (numberToString.Length == 2)
        {
            switch (numberToString[0])
            {
                case '0':
                    break;
                case '1':
                    switch (numberToString[1])
                    {
                        case '0':
                            Console.Write("Ten");
                            break;
                        case '1':
                            Console.Write("Eleven");
                            break;
                        case '2':
                            Console.Write("Twelve");
                            break;
                        case '3':
                            Console.Write("Thirteen");
                            break;
                        case '4':
                            Console.Write("Fourteen");
                            break;
                        case '5':
                            Console.Write("Fifteen");
                            break;
                        case '6':
                            Console.Write("Sixteen");
                            break;
                        case '7':
                            Console.Write("Seventeen");
                            break;
                        case '8':
                            Console.Write("Eighteen");
                            break;
                        case '9':
                            Console.Write("Nineteen");
                            break;
                        default:
                            break;
                    }
                    break;
                case '2':
                    Console.Write("Twenty");
                    break;
                case '3':
                    Console.Write("Thirty");
                    break;
                case '4':
                    Console.Write("Fourty");
                    break;
                case '5':
                    Console.Write("Fifty");
                    break;
                case '6':
                    Console.Write("Sixty");
                    break;
                case '7':
                    Console.Write("Seventy");
                    break;
                case '8':
                    Console.Write("Eighty");
                    break;
                case '9':
                    Console.Write("Ninety");
                    break;
                default:
                    break;
            }
            if (numberToString[0] != '1')
            {
                switch (numberToString[1])
                {
                    case '1':
                        Console.Write(" one");
                        break;
                    case '2':
                        Console.Write(" two");
                        break;
                    case '3':
                        Console.Write(" three");
                        break;
                    case '4':
                        Console.Write(" four");
                        break;
                    case '5':
                        Console.Write(" five");
                        break;
                    case '6':
                        Console.Write(" six");
                        break;
                    case '7':
                        Console.Write(" seven");
                        break;
                    case '8':
                        Console.Write(" eight");
                        break;
                    case '9':
                        Console.Write(" nine");
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
        #region NumbersBetween0And9
        if (numberToString.Length == 1)
        {
            switch (numberToString[0])
            {
                case '0':
                    Console.Write("Zero");
                    break;
                case '1':
                    Console.Write("One");
                    break;
                case '2':
                    Console.Write("Two");
                    break;
                case '3':
                    Console.Write("Three");
                    break;
                case '4':
                    Console.Write("Four");
                    break;
                case '5':
                    Console.Write("Five");
                    break;
                case '6':
                    Console.Write("Six");
                    break;
                case '7':
                    Console.Write("Seven");
                    break;
                case '8':
                    Console.Write("Eight");
                    break;
                case '9':
                    Console.Write("Nine");
                    break;
                default:
                    break;
            }
        }
        #endregion
        Console.WriteLine();
    }
}

