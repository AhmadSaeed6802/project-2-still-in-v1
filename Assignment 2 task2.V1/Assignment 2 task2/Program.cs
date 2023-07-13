using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Base Class BankAccount--------------------------------------------------------------------------------------------
public class BankAccount
{    
    // initializing and declaring attributes--
    public int AccountNo;
    public string AccountHolderName;
    public decimal Balance;
    // Constructors---
     public BankAccount(int accountNumber,string accountHolderName)
    {
        AccountNo = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = 0;
    }
    // deposit method-----------------------------------------
    public  virtual void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Your current balance is {Balance}");
    }
    // Withdraw method----------------------------------------
    public virtual void Withdraw(decimal amount)
    {
        if (amount>Balance)
        {
            Console.WriteLine("Not Enough Balance");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Succesfully with drawn Rs{amount}/- now your current balance os {Balance}");
        }
    }
    // Account information method-----------------------------
    public void AccountInfo()
    {
        Console.WriteLine($"Account Number: {AccountNo}");
        Console.WriteLine($"Account Holder: {AccountHolderName}");
        Console.WriteLine($"Account Number: {Balance}");
    }
}// BankAccount class end------------------------------------------------------------------------------------------------------------------------------------

//Subclass of base class BankAccount class --------------------------------------------------------------------------------------------------------------------
public class SavingAccount:BankAccount
{
   public decimal InterestRate { get; set; } ////aditional attributes
                   //Construct
    public SavingAccount(int  accountNumber,string accountHolderName,decimal interestRate):base (accountNumber,accountHolderName)
    {
        InterestRate = interestRate;
    }
    // override Deposit method to add interest rate 
    public override void Deposit(decimal amount)
    {
        decimal interest = amount * (InterestRate / 100);
        Balance += amount + interest;
        Console.WriteLine($"deposited: {amount} , interest: {interest} , current balance: {Balance}");
    }
}//Saving account class END------------------------------------------------------------------------------------------------------------------

//Checking Acount Class start-----------------------------------------------------------------------------------------------------------
public class CheckingAccount:BankAccount
{
    public  CheckingAccount(int accountNumber, string accountHolderName):base(accountNumber,accountHolderName)
    { 
    }
    public override void Withdraw(decimal amount)
    {
        if (amount<=Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount} current Balance: {Balance} ");
        }
        else
        {
            Console.WriteLine("NOT enough funds availible ");
        }
    }
} // Checking acount class END-----------------------------------------------------------------------------------------------------

// Bank Class Start-----------------------------------------------------------------------------------------------------------------------------------
public class Bank
{      // declare a list of type BankAccount
    public List<BankAccount> bankaccontsList { get; set; }
    //constructor
    public Bank()
    {
        bankaccontsList = new List<BankAccount>();
    }
    // Add account method
     public void AddAccount(BankAccount account)
    {
        bankaccontsList.Add(account);
        Console.WriteLine($"{account.AccountHolderName} with account number {account.AccountNo} has been added to bank accounts list")
    }
}
// Main  progrme class --------------------------------------------------------------------------------------------------------------
public class Program
{
    public static void Main(string[] args)
    {
        Char UserWant;
        Console.WriteLine("Welcome dear do you want to open a bank account enter 'Y' for YES OR 'N' for NO ");
        UserWant=Char.Parse(Console.ReadLine());
        if (UserWant == 'Y')
        {
            Console.WriteLine("Enter your Name");
            string userName= (Console.ReadLine());
              Random random =new Random();
            int accountNumber = random.Next(100000, 999999);
            BankAccount NewAccount = new BankAccount(accountNumber, userName);
            NewAccount.AccountInfo();
            Console.WriteLine("Do you want to withdraw or deposit money");
            Console.WriteLine("Enter 'W' to withdraw or 'D' to Deposit");
            char userChoice = Char.Parse(Console.ReadLine());
            if (userChoice == 'W')
            {
                Console.WriteLine("Enter the amiunt you want to Withdraw");
                int amount = int.Parse(Console.ReadLine());
                NewAccount.Withdraw(amount);
                Console.ReadKey();
            }
            else if (userChoice == 'D')
            {
                Console.WriteLine("Enter the amiunt you want to submit");
                int amount = int.Parse(Console.ReadLine());
                NewAccount.Deposit(amount);
                Console.ReadKey();
            }
        }
        else if (UserWant == 'N')
        {
            Console.WriteLine("if you already have your own account number and name  ");
            Console.WriteLine("Ok NO ISSUE YOU MAY CREAT LATER ,WHEN EVER YOU WANT");
            Console.ReadKey();
        }
       
        

        


    }
}
