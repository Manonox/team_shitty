var memoize = new Dictionary<long, long>();

long Fubonakki(long i)
{
    if (i < 0)
        throw new Exception("Negative index for fubonakki numbers");
    
    if (i < 3)
        return 1;

    if (memoize.TryGetValue(i, out long result))
        return result;

    result = Fubonakki(i - 1) + Fubonakki(i - 2) + Fubonakki(i - 3);
    memoize.Add(i, result);
    return result;
}

for (int i = 0; i < 10; i++)
    Console.WriteLine($"Fubonakki[{i}] = {Fubonakki(i)}");

while (true)
{   
    Console.Write("Fubonakki index: "); Console.Out.Flush();
    var s = Console.ReadLine();
    if (s is null)
        return;
    
    long i;
    try
    {
        i = long.Parse(s);
    }
    catch
    {
        Console.WriteLine("Bad fubonakki index.");
        continue;
    }

    Console.WriteLine($"Fubonakki[{i}] = {Fubonakki(i)}");
}

