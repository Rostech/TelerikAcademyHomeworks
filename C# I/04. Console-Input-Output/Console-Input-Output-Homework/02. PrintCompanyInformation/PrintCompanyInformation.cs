using System;

class PrintCompanyInformation
{
    /*
     2. Print Company Information
     
        A company has name, address, phone number, fax number, web site and 
        manager. The manager has first name, last name, age and a phone number.
        Write a program that reads the information about a company and its 
        manager and prints it back on the console.

     */
    static void Main()
    {
        //Input
        string formatText = "{0,-21}";
        Console.WriteLine("{0,50}", "Company information\n");
        Console.Write(formatText, "Company name: ");
        string companyName = Console.ReadLine();
        Console.Write(formatText, "Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write(formatText, "Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write(formatText, "Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write(formatText, "Web site: ");
        string webSite = Console.ReadLine();
        Console.Write(formatText, "Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write(formatText, "Menager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write(formatText, "Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write(formatText, "Manager phone: ");
        string managerPhone = Console.ReadLine();
        //Output
        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel.  " + phoneNumber);
        if(faxNumber.Length < 8) // fax number has to be at least 8 digits
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: " + faxNumber);
        }
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",managerFirstName,
            managerLastName, managerAge, managerPhone);
    }
}

