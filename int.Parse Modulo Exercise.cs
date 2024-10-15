// Excersise 1, string2int:

//string inp = Console.ReadLine();
//int nLiczba;

//bool ok = int.TryParse(inp, out nLiczba);
//if (ok)
//{
//      Console.WriteLine($"Liczba: {nLiczba}");
//}
//else
//{
//    Console.WriteLine("That is not even a number");
//}

//Excersise 2, %3, %7 in input range

//Console.WriteLine("Input range: ");
//string aSTR = Console.ReadLine();
//string bSTR = Console.ReadLine();

//int a, b;

//bool okA = int.TryParse(aSTR, out a);
//bool okB = int.TryParse(bSTR, out b);

//if (!okA || !okB)
//{
//    Console.WriteLine("That is not even a number");
//}

//for (int i = a; i <= b; i++)
//{
//    if( i % 3 == 0 || i % 7 == 0)
//    {
//        Console.WriteLine("\n \n", i);
//    }
//}


//Excersise 3, prime numbers

Console.WriteLine("input a number: ");
string? aSTR = Console.ReadLine();
int a;

bool okA = int.TryParse(aSTR, out a);


if (!okA)
{
    Console.WriteLine("That is not even a number");
}

if (a < 2)
{
    Console.WriteLine("not prime");
}

for (int i = 2; i * i < a; i++)
{
    if (a % i == 0)
        Console.WriteLine("not prime"); 
}


Console.WriteLine("prime");





