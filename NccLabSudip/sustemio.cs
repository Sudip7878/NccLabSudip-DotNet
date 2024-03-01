using System;
using System.IO;
using System.Text;
namespace NccLabSudip
    //create file
{
    class program1
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\SUDIP\Desktop\just\example.txt";
            using (FileStream fs = File.Create(filepath))
            {
                byte[] data = new UTF8Encoding(true).GetBytes("hello world");
                fs.Write(data, 0, data.Length);
                Console.WriteLine("file created sucessfully");
                Console.ReadLine();

            }
        }
    }
}