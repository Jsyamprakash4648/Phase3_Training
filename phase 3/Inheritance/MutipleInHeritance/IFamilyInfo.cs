using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutipleInHeritance
{
    public interface IFamilyInfo:IShowData
    {
         string FatherName { get; set; }

         string MotherName { get; set; }
          string HouseAddress { get; set; }
          int  NoOfSiblings  { get; set; }

           void ShowInfo()
        {
        
            
        }
        
    }
}
// Properties: FatherName, MotherName, HouseAddress, No.Of.Siblings  

//Method: ShowInfo