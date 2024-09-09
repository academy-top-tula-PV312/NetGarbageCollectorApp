//Employee e = null;

//Console.WriteLine(System.GC.GetTotalMemory(false));

//for (int i = 0; i < 100; i++)
//     e = new Employee();

//Console.WriteLine(System.GC.GetTotalMemory(false));
//Console.WriteLine($"{System.GC.GetGeneration(e)}");

//System.GC.Collect();

//Console.WriteLine(System.GC.GetTotalMemory(false));
//Console.WriteLine($"{System.GC.GetGeneration(e)}");


//Test();

//Console.WriteLine("Pressw any key");
//Console.ReadKey();

unsafe
{
    const int size = 10;
    int* array = stackalloc int[size];
}




void Test()
{
    //Employee employee = null;
    //try
    //{
    //    employee = new Employee() { Name = "Bobby" };
    //}
    //finally
    //{
    //    employee.Dispose();
    //}

    using(Employee employee = new Employee() { Name = "Bobby" })
    {

    }
}



class Employee : IDisposable
{
    public string Name { set; get; }
    public int Age { set; get; }
    //int[] array = new int[1000];

    public void Dispose()
    {
        Console.WriteLine($"Employee {Name} deleted");
    }
}