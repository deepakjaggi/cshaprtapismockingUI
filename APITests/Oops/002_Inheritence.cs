using NUnit.Framework;
using System;

namespace ApiTests.Oops
{
    public class Inheritence
    {
        /*
         Inheritance in java is a mechanism in which one object acquires all the properties and behaviors of parent object. 
         The idea behind inheritance in java is that you can create new classes that are built upon existing classes.
        */

        [Test]
        public void Test() {

            Savings savings = new Savings("DJ",1000);
            savings.AddMoney(100);
            Console.WriteLine(savings.Getbalance());
            //--------
            Ppf ppf = new Ppf("DJ1", 1000);
            ppf.AddMoney(200000);
            ppf.Getbalance();
            Console.WriteLine(ppf.Getbalance());
        }

        public class Bank
        {
            public String cus_name = "";
            public int totalbalance = 0;
            public Bank(String cus_name, int totalbalance)
            {
                this.cus_name = cus_name;
                this.totalbalance = totalbalance;
            }
            public void Credit(int amount)
            {
                totalbalance = totalbalance + amount;
            }
            public void Debit(int amount)
            {
                totalbalance = totalbalance - amount;
            }
            public int Getbalance()
            {
                return totalbalance;
            }
        }

        public class Savings : Bank
        {
            /// <summary>
            /// The constructor of the base class (i.e., "Bank") is invoked using the "base" keyword to initialize the inherited members from the base class.
            /// </summary>
            /// 
            public Savings(string cus_name, int totalbalance) : base(cus_name, totalbalance)
            {
            }
            public void AddMoney(int amount)
            {
                Console.WriteLine("Adding money has no limitations in Savings Account");
                totalbalance = totalbalance + amount;                
            }
        }
        public class Ppf : Bank
        {
            /// <summary>
            /// The constructor of the base class (i.e., "Bank") is invoked using the "base" keyword to initialize the inherited members from the base class.
            /// </summary>
            /// 
            public Ppf(string cus_name, int totalbalance) : base(cus_name, totalbalance)
            {
            }
            public void AddMoney(int amount)
            {
                if (amount > 150000)
                Console.WriteLine("OverLimit - Transaction Rejected");                
            }
        }

    }        
}
 