using System.Transactions;

class Pesel
{
    static string SformatujImie(string imie)
    {
        if (imie == null) {
            Console.WriteLine("Nie podałeś imienia!");
            return null;
        } else

            imie = imie.Replace(" ", "");

        imie = imie.ToLower();
        imie = char.ToUpper(imie[0]) + imie.Substring(1);



        return imie;
    }

    static string SformatujNazwisko(string? nazwisko)
    {



        nazwisko = nazwisko.Replace(" ", "");


        nazwisko = nazwisko.ToLower();
        nazwisko = char.ToUpper(nazwisko[0]) + nazwisko.Substring(1);


        if (nazwisko.Contains("-"))
        {
            int index = nazwisko.IndexOf("-");
            nazwisko = nazwisko.Substring(0, index + 1) + char.ToUpper(nazwisko[index + 1]) + nazwisko.Substring(index + 2);
        }



        return nazwisko;
    }
    static bool CzyPoprawnaData(string bDate)
    {
        if (bDate == null)
        {
            Console.WriteLine("Nie podałeś daty urodzenia!");
            return false;
        }

        bDate = bDate.Replace(" ", "");

        if (DateTime.TryParse(bDate, out DateTime data) && (data.Year >= 1800 && data.Year <= 2299) && (data.Month >= 1 && data.Month <= 12))
        {
            
            if (data.Year % 4 == 0 && data.Month == 2 && data.Day > 29)
            {
                return false;
            }
            return true;
        }
        else
        {
            return false;
        }
    }
    static bool CzyPoprawnaPlec(string plec)
    {

        plec = plec.Replace(" ", "");

        if (plec == null)
        {
            Console.WriteLine("Nie podałeś płci!");
            return false;
        }

        if (plec.Length != 1)
        {
            return false;
        }

        plec = plec.ToUpper();


        return plec == "K" || plec == "M";
    }
    //static int SumaKontrolna(string pesel)
    //{
    //    // obliczanie sumy kontrolnej z numeru pesel
    //    return 0;
    //}
    //static bool DataPesel(string data_urodzenia, string pesel)
    //{
    //    // sprawdzenie poprawności daty urodzenia w peselu
    //    return true;
    //}
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter your lastName: ");
        string? lastName = Console.ReadLine();
        Console.WriteLine("Enter your bithday  (yyyy-m-d lub yyyy/m/d) ");
        string? bDay = Console.ReadLine();
        Console.WriteLine("Enter your gender: ");
        string? gender = Console.ReadLine();
        //Console.WriteLine("Enter PESEL number:  ");
        //string? PESEL = Console.ReadLine();

        string formattedName = SformatujImie(name);
        string formattedLastName = SformatujNazwisko(lastName);


        Console.WriteLine($"Name: {formattedName} \nLast Name: {formattedLastName}");
        if (CzyPoprawnaData(bDay))
        {
            Console.WriteLine($"Data urodzenia: {bDay}");
        }
        if (CzyPoprawnaPlec(gender))
        {
            Console.WriteLine($"Płeć: {gender}");
        }
    }
}