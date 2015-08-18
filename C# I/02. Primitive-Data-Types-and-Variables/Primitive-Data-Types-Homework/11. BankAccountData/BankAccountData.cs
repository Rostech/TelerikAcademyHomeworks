using System;

class BankAccountData
{
    /*  11. Bank Account Data

        A bank account has a holder name (first name, middle name and 
        last name), available amount of money (balance), bank name, IBAN, 
        3 credit card numbers associated with the account.
        Declare the variables needed to keep the information for a single 
        bank account using the appropriate data types and descriptive names.
    */

    static void Main()
    {
        string firstName = "Pedro";
        string middleName = "Quadro";
        string lastName = "Sanches";
        long balance = 2600965;
        string bankName = "Alliance";
        string IBAN = "GB12CPBK08929965044991";
        long creditCard1 = 1234567891234567;
        long creditCard2 = 1234567891234568;
        long creditCard3 = 1234567891234569;
        Console.WriteLine("Name: " + firstName + " " + middleName + " " + lastName);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("Bank name: " + bankName);
        Console.WriteLine("IBAN: " + IBAN);
        Console.WriteLine("Credit card #1: " + creditCard1);
        Console.WriteLine("Credit card #2: " + creditCard2);
        Console.WriteLine("Credit card #3: " + creditCard3);
    }
}

