Console.WriteLine("Zgadnij liczbe z zakresu (0,100>");

int attempt = 0;
bool right = false;

Random random = new Random();
int x = random.Next(1, 100);

while (!right)
{
    string str = Console.ReadLine();
    int inp = Convert.ToInt32(str);

    if (inp > x)
    {
        Console.WriteLine("that number is lower!");

        attempt++;
    }
    else if (inp < x)
    {
        Console.WriteLine("that number is higher!");
        attempt++;
    }
    else if (inp == x)
    {
        Console.WriteLine($"youre right! thats it! number: {x} \n numbers of attempts: {attempt}");
        right = true;
    }
    else
    {
        Console.WriteLine("input error, try again");
    }
}
