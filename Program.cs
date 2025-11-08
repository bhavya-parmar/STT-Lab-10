//using System;

//class Program
//{
//    private int data;
//    private static int counter = 0;

//    public Program()
//    {
//        data = 0;
//        counter++;
//        Console.WriteLine($"Constructor Called. Active objects: {counter}");
//    }

//    ~Program()
//    {
//        counter--;
//        Console.WriteLine($"Object Destroyed. Active objects: {counter}");
//    }

//    public void set_data(int x)
//    {
//        this.data = x;
//    }

//    public void show_data()
//    {
//        Console.WriteLine($"Data = {this.data}");
//    }

//    private static void MakeAndUseObject()
//    {
//        Console.WriteLine("Creating 3 objects...\n");
//        Program p1 = new Program();
//        Program p2 = new Program();
//        Program p3 = new Program();

//        Console.WriteLine("\nSetting data for each object...\n");
//        p1.set_data(10);
//        p2.set_data(20);
//        p3.set_data(30);

//        Console.WriteLine("Displaying data for each object...\n");
//        p1.show_data();
//        p2.show_data();
//        p3.show_data();
//    }

//    public static void Main(string[] args)
//    {
//        MakeAndUseObject();

//        Console.WriteLine("\nCleaning up...\n");
//        GC.Collect();
//        GC.WaitForPendingFinalizers();
//        GC.Collect();
//        Console.WriteLine($"Active objects remaining: {counter}");
//        Console.ReadKey(); // to see output before console window closes
//    }
//}
