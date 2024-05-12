using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankDetailsInfo
{
    public class AccountInfo:PersonalInfo
    {
     

        private int s_accountNumber=1200;

        public string  AccountNumber { get; set; }

        public string  BranchName { get; set; }

        public string IFSCCode { get; set; }

        public double Balance { get; set; }

        public AccountInfo(string name,string fathername,string phone,string mail,DateTime dob,Gender gender,string branchName,string ifsccode,double balance):base( name, fathername, phone, mail, dob, gender)
        {

            s_accountNumber++;
            AccountNumber="AID"+s_accountNumber;
            BranchName=branchName;
            IFSCCode=ifsccode;
            Balance=balance;

        }

        public void Withdraw(double amount)
        {
            if(amount<=Balance)
            {
                Balance=Balance-amount;
                Console.WriteLine("amount has been withdrawn succesfully :"+Balance);


            }
        }

        public void Deposit(double amount)
        {
            Balance=Balance+amount;

            Console.WriteLine("amount has been Deposited succesfully :"+Balance);
        }

        public void ShowBalance()
        {
            Console.WriteLine("your account balance: "+Balance);
        }

// method for showming account degtails
   public void ShowAccountInfo()
        {
            Console.WriteLine($"Account holder Name: {Name} \nFatherName:{FatherName} \nphone{Phone} \nmail: {Mail} \nDateof birth: {Dob.ToString("dd/MM/yyyy")} \nGender: {Gender} \nAccount no:{AccountNumber} \nBranch Name: {BranchName} \nIFSC No :{IFSCCode}  ");
        }



    }
}