using System;
using System.Collections.Generic;

namespace DependencyInjection;

class Program 
{
    public static void Main(string[] args)
    {
        CCAccount ccAccount=new CCAccount();
        ccAccount.AccountNumber=123;
        ccAccount.Name="syam";
        ccAccount.Balance=100000000;



        SBAccount sbAccount=new SBAccount();
        sbAccount.AccountNumber=12345;
        sbAccount.Name="satya";
        sbAccount.Balance=200000000;


        List <CCAccount> ccList=new List<CCAccount>();
        ccList.Add(ccAccount);
    

        List<SBAccount> sbList=new List<SBAccount>();

        sbList.Add(sbAccount);



        List<IAccount> accountList=new List<IAccount>();

        accountList.Add(sbAccount);
        accountList.Add(ccAccount);



        
           

        
    }
}
