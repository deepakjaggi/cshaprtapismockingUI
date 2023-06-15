using NUnit.Framework;
using System;

namespace ApiTests.Oops
{
    public class Oops
    {

        [Test]
        public void TestHello()
        {
            Console.WriteLine("Hello");
        }
        [Test]
        public void ProgramWithoutOops()
        {
            Credit(100, str_cus_name1);
            Debit(100, str_cus_name2);
            Console.WriteLine(GetBalance(str_cus_name1));
            Console.WriteLine(GetBalance(str_cus_name2));
        }

        public static String str_cus_name1 = "Cus1";
        public static String str_cus_name2 = "Cus2";
        public static int totalamount_cus1 = 1000;
        public static int totalamount_cus2 = 2000;

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
    }    
}
 