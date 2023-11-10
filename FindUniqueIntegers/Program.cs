namespace Algorithms;

public class FindUniqueIntegers {

    public static List<int> GetUniqueIntegers(int[] array) {
        var frequencyDict = new Dictionary<int, int>();
        var uniqueInts = new List<int>();

        foreach (var num in array)
        {
            if (frequencyDict.ContainsKey(num)){
                frequencyDict[num]++;
            } else {
                frequencyDict.Add(num, 1);
            }
        }

        foreach (var kvp in frequencyDict)
        {
            if (kvp.Value == 1) {
                uniqueInts.Add(kvp.Key);
            }
        }

        return uniqueInts;
    }

    public static List<int> GetUniqueIntegersAlternative(int[] array) {
        var uniqueInts = new List<int>();

        Array.Sort(array);

        var length = array.Length;
        var i = 0;

        while (i < length)
        {
            var current = array[i];
            var count = 0;

            while (i < length && array[i] == current)
            {
                count++;
                i++;
            }

            if (count == 1) {
                uniqueInts.Add(current);
            }
        }

        return uniqueInts;
    }

    // TODO test edge cases
    /*
       The list is huge (i.e. several billion numbers or more)
       The list is tiny (0 or 1 items)
       The list is null
       Everything is a duplicate
       Everything is unique
       The list is just the same number repeated many times
    */

    public static void Main() {
        var arr = new int[] {1, 10, -4, 2, 7, 8, 45, -32, 2, 9, -4, 33};
        Console.WriteLine(string.Join(", ", GetUniqueIntegers(arr)));
        Console.WriteLine(string.Join(", ", GetUniqueIntegersAlternative(arr)));
    }

}