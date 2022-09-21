using Problem_2;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            var box = new Box(length, width, height);
            Console.WriteLine(box);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
