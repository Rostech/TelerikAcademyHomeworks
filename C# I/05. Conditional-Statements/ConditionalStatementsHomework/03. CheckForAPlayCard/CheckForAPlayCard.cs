using System;

class CheckForAPlayCard
{
    /*
        3. Check for a Play Card

        Classical play cards use the following signs to designate the card 
        face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program 
        that enters a string and prints “yes” if it is a valid card sign or 
        “no” otherwise.
    
    */
    static void Main()
    {
        Console.Write("Enter possible card: ");
        string card = Console.ReadLine();
        string[] deck = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" }; 
        bool foundCard = false;
        for(int index = 0; index < deck.Length; index++)
        {
            if(card == deck[index])
            {
                foundCard = true;
                break;
            }
        }
        if(foundCard)
            Console.WriteLine("Valid card sign?   Yes");
        else
            Console.WriteLine("Valid card sign?   No");
    }
}

