using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    // A simple savings account class.
    //class SavingsAccount
    //{
    //    // a static point of data
    //    public static double currInterestRate = 0.04;


    //    // Instance level data.
    //    public double currBalance;
    //    public SavingsAccount(double balance)
    //    {
    //        currBalance = balance;
    //        Console.WriteLine("An account was created with a balance of {0}\n", balance);
    //    }

    //    // Static members to get/set interest rate.
    //    public static void SetInterestRate(double newRate)
    //    { currInterestRate = newRate; }

    //    public static double GetInterestRate()
    //    { return currInterestRate; }
    //}

    class SavingsAccount
    {
        public double currBalance;
        public static double currInterestRate;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;
        }
    }
}
