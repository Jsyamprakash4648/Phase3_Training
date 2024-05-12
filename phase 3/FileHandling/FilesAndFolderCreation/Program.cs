using System;
using System.IO;
using System.Transactions;

namespace FilesAndFolderCreation;

class Program 
{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\SyamPrakashJayapraka\OneDrive - Syncfusion\Desktop\phase 3\Myfolder";

        string folderPath=path+"/Syam";

        if(!Directory.Exists(folderPath))
        {
            Console.WriteLine("creating FOlder");
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            Console.WriteLine("File Already exists");
        }
        string filepath=path+"/myfile.txt";
        if(!File.Exists(filepath))
        {
            Console.WriteLine("creating file....");
            File.Create(filepath);
        }
        else{
            Console.WriteLine("file already Exist");
        }




        Console.WriteLine("Select 1.create folder 2.create file 3.Delete folder 4.Delet file");
        int option=int.Parse(Console.ReadLine());

        switch(option)
        {
            case 1:
            {
                Console.WriteLine("Enter folder name you want to create");
                string folder=Console.ReadLine();
                string newpath=path+"/"+folder;
                if(!Directory.Exists(newpath))
                {
                    Console.WriteLine("creating a folder ");
                    Directory.CreateDirectory(newpath);
                }
                else
                {
                   Console.WriteLine(" Directory Already exists");
                }
                break;
            }

            case 2:
            {
                Console.WriteLine("enter file name:");
                String fileName=Console.ReadLine();
                Console.WriteLine("enter files extensio");
                String extension =Console.ReadLine();
                String newpath=path+"/"+fileName+"."+extension;
                if(!File.Exists(newpath))
                {
                    Console.WriteLine("creating file......"+fileName+"."+extension);
                    File.Create(newpath);


                }
                else{
                    Console.WriteLine("file already exists");
                }


                break;
            }

            case 3:
            {
                foreach(string path1 in Directory.GetDirectories(path))
                {
                    Console.WriteLine(path1);
                }

                Console.WriteLine("Select folder you wish to remove");
                string folder1=Console.ReadLine();
                foreach(string path1 in Directory.GetDirectories(path))
                {
                    if(path1.Contains(folder1))
                    {
                        Console.WriteLine("removing"+folder1);
                        Directory.Delete(path1);
                    }
                }
                break;
            }

            case 4:
            { 
                foreach(string file1 in Directory.GetFiles(path))
                {
                    Console.Write(file1);
                }

                Console.WriteLine("enter filename and extention  you want delete: ");
                string file2=Console.ReadLine();
                foreach(string file1 in Directory.GetFiles(path))
                {
                    if(file1.Contains(file2))
                    {
                        Console.WriteLine("removing file..."+file2);
                        File.Delete(file1);
                    }
                }
                break;
            }
        }
    }
}
