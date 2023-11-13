namespace Algorithms;

public class Program {

    public static void Main() {
        
        Console.WriteLine("Enter array of integer numbers separated by ',':");
        var value = Console.ReadLine();

        int[] arr;
        try {
            arr = value?.Split(',').Select(int.Parse).ToArray() ?? Array.Empty<int>();
        } catch {
            Console.WriteLine("Error!");
            return;
        }
        
        var uniqueInts = new UniqueIntegers();
        Console.WriteLine(string.Join(", ", UniqueIntegers.WithDictionary(arr)));
        Console.WriteLine(string.Join(", ", UniqueIntegers.WithSortAndLinearScan(arr)));
    }

}