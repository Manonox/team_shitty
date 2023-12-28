public class Fubonakki
{
    static private readonly Dictionary<long, long> memoize = new();

    static public long Calculate(long i)
    {
        // if (i < 0)
        //     throw new Exception("Negative index for fubonakki numbers");
        
        if (i < 3)
            return 1;

        if (memoize.TryGetValue(i, out long result))
            return result;

        result = Calculate(i - 1) + Calculate(i - 2) + Calculate(i - 3);
        memoize.Add(i, result);
        return result;
    }
}