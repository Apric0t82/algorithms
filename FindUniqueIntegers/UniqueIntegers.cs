namespace Algorithms;

public class UniqueIntegers
{
    public List<int> GetUniqueIntegers(int[] array) {
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

    public List<int> GetUniqueIntegersAlternative(int[] array) {
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
