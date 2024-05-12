using System;
using System.IO;

namespace ReadAndWriteText;

class Program 
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Console.WriteLine("creating folder");
            Directory.CreateDirectory("TestFolder");
        }
        else
        {
            Console.WriteLine("Directory already exits");
        }

        if(!File.Exists("TestFolder/MyFile.txt"))
        {
            Console.WriteLine("creating File");
            File.Create("TestFolder/MyFile.txt").Close();
        }
        else
        {
            Console.WriteLine("File Already Exists");
        }



        Console.WriteLine("Select 1.Read From File  2. write to file");
        int option=int.Parse(Console.ReadLine());

        switch(option)
        {
            case 1:
            {
                StreamReader sr=new StreamReader("TestFolder/MyFile.txt");
                string data =sr.ReadLine();

                while(data!=null)
                {
                    Console.WriteLine(data);
                    data=sr.ReadLine();
                }
                sr.Close();
                
                break;
            }
            case 2:
            {
                string [] contents=File.ReadAllLines("TestFolder/MyFile.txt");
                StreamWriter sw=new StreamWriter("TestFolder/MyFile.txt");
                Console.WriteLine("enter what do you want to place in file: ");
                string data=Console.ReadLine();

                string old="";
                foreach(string line in contents)
                {
                    old=old+line+"\n";

                }
                old=old+data+"\n";
                sw.WriteLine(old);

                sw.Close(); 
                break;
            }
        }
    }
}
