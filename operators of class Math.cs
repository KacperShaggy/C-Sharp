string x = Console.ReadLine();
double y = Convert.ToDouble(x);

//PODNOSZENIE DO POTĘGI
double a = Math.Pow(y, 2); 
Console.WriteLine($"{y} do kwadratu: {a}\n");

//POTĘGA
double b = Math.Sqrt(y);
Console.WriteLine($"{y} pod potęgą wynosi: {b}\n");

//WARTOŚĆ BEZWZGLĘDNA
double c = Math.Abs(y);
Console.WriteLine($"{y} w wartości bezględnej: {c}\n");

//ZAOKRĄGLANIE
double d = Math.Round(y);
Console.WriteLine($"{y} zaokrąglone: {d}\n");



