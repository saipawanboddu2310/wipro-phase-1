namespace sampledemo;
using ClassLibrary1;
using System.Reflection;

public class Calaculator
{
    [AddNumbers(5, 3)]
    public void operation()
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Type calctype = typeof(Calaculator);
        MethodInfo method = calctype.GetMethod(nameof(Calaculator.operation));
        AddNumbers attribute = (AddNumbers)method.GetCustomAttribute(typeof(AddNumbers));
        if (attribute != null)
        {
            int result = attribute.Add();
            int result2 = attribute.Substract();
            Console.WriteLine($"The result of addition is {result}");
            Console.WriteLine($"The result of substraction is {result2}");
        }
    }
}
