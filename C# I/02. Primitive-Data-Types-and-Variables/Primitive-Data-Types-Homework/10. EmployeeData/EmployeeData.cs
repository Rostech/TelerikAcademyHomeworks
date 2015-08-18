using System;

class EmployeeData
{
    /* Employee Data

        A marketing company wants to keep record of its employees. Each 
        record would have the following characteristics:
        
            First name
            Last name
            Age (0...100)
            Gender (m or f)
            Personal ID number (e.g. 8306112507)
            Unique employee number (27560000…27569999)
        
        Declare the variables needed to keep the information for a 
        single employee using appropriate primitive data types. Use 
        descriptive names. Print the data at the console.
    */
    static void Main()
    {
        string firstName = "Michael";
        string lastName = "Jackson";
        byte age = 39;
        char gender = 'm';
        long presonalID = 8306112507;
        long uniqueEmployeeNumber = 27650000;
        Console.WriteLine("Name: " + firstName + " " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID: " + presonalID);
        Console.WriteLine("Unique employee number: " + uniqueEmployeeNumber);
    }
}

