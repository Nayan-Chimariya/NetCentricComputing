using System;
using System.IO;

namespace lab1
{
	public class Student
	{
		public string name, ID, address;

		public void GetData()
		{
			Console.WriteLine("Enter name: ");
            Console.WriteLine("Enter ID: ");
            Console.WriteLine("Enter address: ");
        }

		public void DisplayData()
		{
			Console.WriteLine("{0}{1}{2}", name, ID, address); Console.WriteLine("Enter name: ");
            Console.ReadLine();
        }
            
		public void Read(string path)
		{
			FileStream file = new(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);

		}
	}
}


           



