using System;
using lab1;

class App
{
    public static void Main(string[] args)
    {
        //Employee
        Console.WriteLine("\nEmployee");
        Employee E1 = new("Ram", "Bahadur", 20000);

        E1.FirstName = "Nayan";
        E1.Display();
        E1.IncrementSalary(10);

        //Polymorphism
        //static
        Console.WriteLine("\nStatic Polymorphism");
        StaticPolyMorph ob1 = new();
        ob1.Print(1);
        ob1.Print("Nayan");

        //Polymorphism
        //dynamic
        Console.WriteLine("\nDynamic Polymorphism");
        Animal A1 = new();
        A1.Speak("mew");

        Dog D1 = new();
        D1.Speak();

        //exception handling
        Console.WriteLine("\nException Handling");
        lab1.Exception Ex1 = new();
        double res = Ex1.Divide(2, 2);
        Console.WriteLine("Division result = {0}",res);

        //File Handling
        //Student S1 = new();
        //S1.GetData();
        //S1.DisplayData();

        //Linq
        Console.WriteLine("\nLINQ");
        int[] number_list = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] even_list;
        int[] odd_list;

        Linq L1 = new();

        L1.NumberList(number_list);

        even_list = L1.GetEvenList(count: true);
        foreach (var number in even_list)
            Console.WriteLine(number);

        odd_list = L1.GetOddList(count: false);
        foreach (var number in odd_list)
            Console.WriteLine(number);



    }

}
