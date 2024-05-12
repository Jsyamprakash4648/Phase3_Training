using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class MedicineDetails
    {
// a.	MedicineID (MD100)
// b.	MedicineName
// c.	AvailableCount
// d.	Price
// e.	DateOfExpiry
    private static int s_medicineID=100;
    public string  MedicineID { get; set; }

    public string MedicineName { get; set; }

    public int AvailableCount { get; set; }

    public double Price { get; set; }
    public DateTime DateOfExpiry { get; set; }


    public MedicineDetails(string medicineName,int availableCount,double price,DateTime dateOfExpiry)
    { s_medicineID++;
        MedicineID="MID"+s_medicineID;
        MedicineName=medicineName;
        AvailableCount=availableCount;
        Price=price;
        DateOfExpiry=dateOfExpiry;


    }
    }
}