using System;
using System.Threading;

string namnA = "Ragnar";
int hpA = 100;

string namnB = "Björn";
int hpB = 100;

Random slump = new Random();
int runda = 1;

Console.WriteLine($"{namnA} ({hpA} HP) vs {namnB} ({hpB} HP)");
Console.WriteLine();

while (hpA > 0 && hpB > 0)
{
    Console.WriteLine($"--- Runda {runda} ---");

    int skadaB = slump.Next(5, 12);
    hpB -= skadaB;
    Console.WriteLine($"{namnA} slår {namnB} för {skadaB} skada. {namnB}: {Math.Max(hpB, 0)} HP");

    if (hpB > 0)
    {
        int skadaA = slump.Next(5, 12);
        hpA -= skadaA;
        Console.WriteLine($"{namnB} slår {namnA} för {skadaA} skada. {namnA}: {Math.Max(hpA, 0)} HP");
    }

    Console.WriteLine();
    runda++;

    Thread.Sleep(1000); 
}

    if (hpA <= 0 && hpB <= 0)
    Console.WriteLine("Oavgjort! Båda gick under 0 samtidigt.");
else if (hpA <= 0)
    Console.WriteLine($"{namnB} vinner!");
else
    Console.WriteLine($"{namnA} vinner!");

Console.WriteLine("Bra match!");
    Console.ReadLine();