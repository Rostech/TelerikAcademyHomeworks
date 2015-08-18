

namespace BankAccounts
{
    using System;
    using BankAccounts.Models;
    using BankAccounts.Interfaces;

    /*
        2. Bank accounts

            A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
            Customers could be individuals or companies.
            All accounts have customer, balance and interest rate (monthly based).
                Deposit accounts are allowed to deposit and with draw money.
                Loan and mortgage accounts can only deposit money.
            All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated 
            as follows: number_of_months * interest_rate.
            Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
            Deposit accounts have no interest if their balance is positive and less than 1000.
            Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
            Your task is to write a program to model the bank system by classes and interfaces.
            You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest 
            functionality through overridden methods.

    */
    class RunBankAccounts
    {
        static void Main()
        {
            Deposite depositeIndividualStanimir = new Deposite(new Individual("Stanimir"), 2003, 5);
            Deposite depositeCompanyGeograficNational = new Deposite(new Company("GeograficNational"), 198032, 17);
            Loan loanIndividualGerasim = new Loan(new Individual("Gerasim"), 315, 2);
            Loan loanCompanyTouristOOD = new Loan(new Company("TouristOOD"), 43707, 9);
            Mortgage mortgageIndividualPetkan = new Mortgage(new Individual("Petkan"), 200, 6);
            Mortgage mortgageCompanySoftCom = new Mortgage(new Company("SoftCom"), 299387, 19);

            Console.WriteLine(new string('-', 80));

            Bank alianzBank = new Bank("Alianz");
            alianzBank.AddAccount(depositeIndividualStanimir);
            alianzBank.AddAccount(depositeCompanyGeograficNational);
            alianzBank.AddAccount(loanIndividualGerasim);
            alianzBank.AddAccount(loanCompanyTouristOOD);
            alianzBank.AddAccount(mortgageIndividualPetkan);
            alianzBank.AddAccount(mortgageCompanySoftCom);

            Console.WriteLine(alianzBank.ToString());      
            
            
        }
    }
}
