int[] t = new int[100];

for (int i = 0; i < 100; i++)
{
    Random rnd = new Random();
    t[i] = rnd.Next(1,99);
    Console.WriteLine(t[i]);
}

int suma = 0;
for (int i = 0; i < 100; i++)
{
    suma += t[i];
}

Console.WriteLine($"Suma: {suma}");

int max =  0;
for (int i = 0; i < 100; i++)
{
    if (t[i] > max)
    {
        max = t[i];
    }
}
Console.WriteLine($"Max: {max}");

int min = t[0];
for (int i = 0; i < 100; i++)
{
    if (t[i] < min)
    {
        min = t[i];
    }
}
Console.WriteLine($"Min: {min}");

float srednia = suma / t.Length;

Console.WriteLine($"Średnia: {srednia}");

Array.Sort(t);

for (int i = 0; i < t.Length; i++)
{
    Console.WriteLine(t[i]);
}
