namespace Algorithms;

public class UniqueIntegers
{
    public static List<int> WithDictionary(int[] array) {
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

    public static List<int> WithExceptingDuplicatesHashSet(int[] array) {
        
        var duplicates = new List<int>();

        HashSet<int> set = array.TryGetNonEnumeratedCount(out var count) 
                            ? new(count) 
                            : new();

        foreach (var number in array)
        {
            if (!set.Add(number)) {
                duplicates.Add(number);
            }
        }

        var uniqueInts = array.Except(duplicates).ToList();

        return uniqueInts;
    }

    public static List<int> WithSortAndLinearScan(int[] array) {
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

}
