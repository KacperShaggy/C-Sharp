using System;
namespace StudentManagement
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string gender;
        private string peselNumber;


        public string FirstName
        {
            get { return firstName; }
            set { firstName = char.ToUpper(value[0]) + value.Substring(1).ToLower(); }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = char.ToUpper(value[0]) + value.Substring(1).ToLower(); }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                value = value.Replace(".", "");
                if (DateTime.TryParseExact(value, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    dateOfBirth = date.ToString("yyyy MM dd");
                }
                else
                {
                    throw new Exception("Zła data");
                }
                //DateTime.ParseExact(value, "yyyy.MM.dd", null);
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                value = value.ToUpper();

                if (value == "M" || value == "K")
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Podaj dobra plec");
                }
            }

        }

        public string PeselNumber
        {
            get {return peselNumber ;}
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException("Pesel musi miec 11 cyfr");
                }
                else 
                {
                    peselNumber = value;
                }
                
            }
        }





        public void AddStudent()
        {
            Console.Write("Podaj imię: ");
            FirstName = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            LastName = Console.ReadLine();

            Console.Write("Podaj date urodzenia: ");
            DateOfBirth = Console.ReadLine();

            Console.Write("Podaj płeć: ");
            Gender = Console.ReadLine();

            Console.Write("Podaj pesel: ");
            PeselNumber = Console.ReadLine();

        }
        public void PrintStudent()
        {
            Console.WriteLine($"{FirstName} {LastName} {DateOfBirth} {Gender} {PeselNumber}");
        }
    }
    public class App
    {
        public static void Main(string[] args)
        {
            Student nowy = new();
            nowy.AddStudent();
            nowy.PrintStudent();
        }
    }
}