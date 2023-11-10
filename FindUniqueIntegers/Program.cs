namespace Algorithms;

public class Program {

    public static void Main() {
        var arr = new int[] {1, 10, -4, 2, 7, 8, 45, -32, 2, 9, -4, 33};
        
        var uniqueInts = new UniqueIntegers();
        Console.WriteLine(string.Join(", ", uniqueInts.GetUniqueIntegers(arr)));
        Console.WriteLine(string.Join(", ", uniqueInts.GetUniqueIntegersAlternative(arr)));
    }

}