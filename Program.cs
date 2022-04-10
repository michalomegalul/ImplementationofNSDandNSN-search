new ProgramPetros().Run();
class ProgramPetros
{
    public void Run()
    {
        var n = 134;
        var m = 321;
        //3
        Console.WriteLine("List all divisors of n>");
        for (var i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine($"divisor:{i};{n / i}");

            }
        }
        //4
        Console.WriteLine("Write the decomposition of the number n into prime factors>");
        var prime = new List<int>();
        var q = n;
        while (q > 1)
        {
            for (var i = 2; i <= q; i++)
            {
                if (q % i == 0)
                {
                    prime.Add(i);
                    q = q / i;
                    break;
                }
            }
        }
        Console.WriteLine(string.Join("*", prime));
        //5
        Console.WriteLine("Greatest common divisor with Euclid algorithm>");
        var a = n;
        var b = m;
        while (b != 0)
        {
            var c = a % b;
            a = b;
            b = c;
        }
        Console.WriteLine(a);
        //6
        Console.WriteLine("Greatest common divisor numbers m and n determined by decomposition of both numbers into prime factors>");
        var prime1 = new List<int>();
        var q1 = m;
        while (q1 > 1)
        {
            for (var i = 2; i <= q1; i++)
            {
                if (q1 % i == 0)
                {
                    prime1.Add(i);
                    q1 = q1 / i;
                    break;
                }
            }
        }
        var prime2 = new List<int>();
        var q2 = n;
        while (q2 > 1)
        {
            for (var i = 2; i <= q2; i++)
            {
                if (q2 % i == 0)
                {
                    prime2.Add(i);
                    q2 = q2 / i;
                    break;
                }
            }
        }
        var gcd = 1;
        foreach (var i in prime1)
        {
            if (prime2.Contains(i))
            {
                gcd *= i;
            }
        }
        Console.WriteLine(gcd);
        //7
        Console.WriteLine("Least common multiple between m and n>");
        var lcmn = n;
        var lcmm = m;
        for (var tempNum = 1; ; tempNum++)
        {
            
            if (tempNum % lcmn == 0 && tempNum % lcmm == 0)
            {
                Console.WriteLine(tempNum);
                break;
            }
        }
    }
}