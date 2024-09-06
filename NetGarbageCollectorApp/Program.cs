Employee e = null;

Console.WriteLine(System.GC.GetTotalMemory(false));

for (int i = 0; i < 100; i++)
     e = new Employee();

Console.WriteLine(System.GC.GetTotalMemory(false));
Console.WriteLine($"{System.GC.GetGeneration(e)}");

System.GC.Collect();

Console.WriteLine(System.GC.GetTotalMemory(false));
Console.WriteLine($"{System.GC.GetGeneration(e)}");



class Employee
{
    public string Name { set; get; }
    public int Age { set; get; }
    int[] array = new int[1000];
}