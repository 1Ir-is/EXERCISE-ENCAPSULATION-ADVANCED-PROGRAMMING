using EXERCISE_ENCAPSULATION;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        var length = double.Parse(Console.ReadLine());
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());
        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(fields.Count());

        var box = new Box(length, width, height);
        Console.WriteLine(box);
    }
}