for (int i = 0; i < 10; i++)
    Console.WriteLine($"Fubonakki[{i}] = {Fubonakki.Calculate(i)}");

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

    Console.WriteLine($"Fubonakki[{i}] = {Fubonakki.Calculate(i)}");
}

