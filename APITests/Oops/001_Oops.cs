using NUnit.Framework;
using System;

namespace ApiTests.Oops
{
    public class Oops
    {

        //**********************
        [Test]
        public void TestHello()
        {
            Console.WriteLine("Hello");
        }
        //**********************
        public static String str_cus_name1 = "Cus1";
        public static String str_cus_name2 = "Cus2";
        public static int totalamount_cus1 = 1000;
        public static int totalamount_cus2 = 2000;

        [Test]
        public void ProgramWithoutOops()
        {
            Credit(100, str_cus_name1);
            Debit(100, str_cus_name2);
            Console.WriteLine(GetBalance(str_cus_name1));
            Console.WriteLine(GetBalance(str_cus_name2));
        }

        public static void Credit(int amount, String cusName)
        {
            if (cusName.Equals("Cus1"))
            {
                totalamount_cus1 = totalamount_cus1 + amount;
            }
            if (cusName.Equals("Cus2"))
            {
                totalamount_cus2 = totalamount_cus2 + amount;
            }
        }
        public static void Debit(int amount, String cusName)
        {
            if (cusName.Equals("Cus1"))
            {
                totalamount_cus1 = totalamount_cus1 - amount;
            }
            if (cusName.Equals("Cus2"))
            {
                totalamount_cus2 = totalamount_cus2 - amount;
            }
        }
        public static int GetBalance(String cusName)
        {
            int amountToReturn = 0;
            if (cusName.Equals("Cus1"))
            {
                amountToReturn = totalamount_cus1;
            }
            if (cusName.Equals("Cus2"))
            {
                amountToReturn = totalamount_cus2;
            }
            return amountToReturn;
        }
        //**********************
        [Test]
        public void ProgramWitOops()
        {
            //let us say, if you forget to initilize variables, and hence we are using constructors.
            //Constructor block would get executed as soon as we create object of class
            Banking objcus1 = new Banking("Deepak", 1000);
            objcus1.Credit(100);
            Banking objcus2 = new Banking("Rachana", 2000);
            objcus2.Debit(100);
            Console.WriteLine(objcus1.Getbalance());
            Console.WriteLine(objcus2.Getbalance()); 
        }
        public class Banking
        {
            public String cus_name = "";
            public int totalbalance = 0;
            //let us say, if you forget to initilize variables, and hence we are using constructors.
            //Constructor block would get executed as soon as we create object of class
            public Banking(String cus_name, int totalbalance)
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
        //Class is a concept
        //if person is class and then we are are objects
        //Objects we can see ,touch, and perform mehods on object.
        //Here, if banking is class, then credit, debit, getbalance are methods.
    }
}
 