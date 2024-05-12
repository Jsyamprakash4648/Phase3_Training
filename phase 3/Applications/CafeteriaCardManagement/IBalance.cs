using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public interface IBalance
    {
         double WalletBalance { get; }
         void WalletRecharge(double amount); 
         void DeductAmount(double amount);
    }
}