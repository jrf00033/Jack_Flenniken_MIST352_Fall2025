using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Account
    {
        private int _accountNumber; // declaring a private integer field to store the account number
        private string _ownerName; // declaring a private string field to store the owner's name
        private double _balance; // declaring a private double field to store the account balance

        public Account() // default constructor initializes owner name and balance
        {
            this._ownerName = "Unknown"; // setting default owner name to "Unknown"
            this._balance = 0; // setting default balance to 0
        }

        public Account(int Number, string Owner) // constructor with account number and owner name
        {
            this._accountNumber = Number; // assigning the Number parameter to _accountNumber
            this._ownerName = Owner; // assigning the Owner parameter to _ownerName
            this._balance = 0; // initializing balance to 0
        }

        public Account(int number, string Owner, double balance) // constructor with account number, owner name, and balance
        {
            this._accountNumber = number; // assigning the number parameter to _accountNumber
            this._ownerName = Owner; // assigning the Owner parameter to _ownerName
            this._balance = balance; // assigning the balance parameter to _balance
        }

        public void Deposit(double amount) // method to deposit money into the account
        {
            if (amount > 0) // checking if the deposit amount is positive
            {
                this._balance += amount; // adding the amount to the current balance
            }
        }

        public void Withdraw(double amount) // method to withdraw money from the account
        {
            if (amount > this._balance) // checking if the withdrawal amount exceeds the balance (likely a bug: should be amount <= balance)
            {
                this._balance -= amount; // subtracting the amount from the current balance
            }
        }

        public void DisplayInfo() // method to display account information
        {
            Console.WriteLine($"Account Number:{_accountNumber}, Owner Name:{_ownerName}, Balance:{_balance}"); // printing account details to the console
        }




    } 
}
