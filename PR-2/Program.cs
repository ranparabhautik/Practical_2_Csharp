using System;

namespace Practical_2;

class Customer_Account
{
    public string Bank_name;
    protected long Customer_AccountNo;
    protected string Customer_name;

    public Customer_Account(long acNo, string cName)
    {
        Customer_name = cName;
        Customer_AccountNo = acNo;
    }

    public void printInfo()
    {
        Console.WriteLine("\t\t--- Account Info ---\n");
        Console.WriteLine($"\tBank Name :            {Bank_name}");
        Console.WriteLine($"\tCustomer Account No. : {Customer_AccountNo}");
        Console.WriteLine($"\tCustomer Name :        {Customer_name}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\t\t---------- Bank Details ----------\n");

        Customer_Account CustomerJohn = new Customer_Account(1011, "JohnSon Mitchel");
        CustomerJohn.Bank_name = "IDFC";
        CustomerJohn.printInfo();

        Customer_Account CustomerSam = new Customer_Account(1022, "Samuel Smith");
        CustomerSam.Bank_name = "State Bank of India";
        CustomerSam.printInfo();

        Customer_Account CustomerRahul = new Customer_Account(1033, "Rahul Sharma");
        CustomerRahul.Bank_name = "Bank of Baroda";  
        CustomerRahul.printInfo();

        Console.ReadKey();
    }
}