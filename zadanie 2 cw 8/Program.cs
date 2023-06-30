using System;

namespace StrukturyProgramu
{
    struct Student
    {
        public string Imie;
        public string Nazwisko;
        public int NumerIndeksu;
        public int RokStudiow;
    }

    struct Przedmiot
    {
        public string Nazwa;
        public string KodPrzedmiotu;
        public int ECTS;
        public int GodzinyWykladu;
    }

    struct NauczycielAkademicki
    {
        public string Imie;
        public string Nazwisko;
        public string TytulNaukowy;
        public string Specjalizacja;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student;
            student.Imie = "Jan";
            student.Nazwisko = "Kowalski";
            student.NumerIndeksu = 123456;
            student.RokStudiow = 2;

            Przedmiot przedmiot;
            przedmiot.Nazwa = "Programowanie w C#";
            przedmiot.KodPrzedmiotu = "C#101";
            przedmiot.ECTS = 5;
            przedmiot.GodzinyWykladu = 30;

            NauczycielAkademicki nauczyciel;
            nauczyciel.Imie = "Anna";
            nauczyciel.Nazwisko = "Nowak";
            nauczyciel.TytulNaukowy = "dr";
            nauczyciel.Specjalizacja = "Programowanie";

            Console.WriteLine("Informacje o studencie:");
            Console.WriteLine("Imię: " + student.Imie);
            Console.WriteLine("Nazwisko: " + student.Nazwisko);
            Console.WriteLine("Numer indeksu: " + student.NumerIndeksu);
            Console.WriteLine("Rok studiów: " + student.RokStudiow);

            Console.WriteLine("\nInformacje o przedmiocie:");
            Console.WriteLine("Nazwa: " + przedmiot.Nazwa);
            Console.WriteLine("Kod przedmiotu: " + przedmiot.KodPrzedmiotu);
            Console.WriteLine("ECTS: " + przedmiot.ECTS);
            Console.WriteLine("Godziny wykładu: " + przedmiot.GodzinyWykladu);

            Console.WriteLine("\nInformacje o nauczycielu akademickim:");
            Console.WriteLine("Imię: " + nauczyciel.Imie);
            Console.WriteLine("Nazwisko: " + nauczyciel.Nazwisko);
            Console.WriteLine("Tytuł naukowy: " + nauczyciel.TytulNaukowy);
            Console.WriteLine("Specjalizacja: " + nauczyciel.Specjalizacja);

            Console.ReadKey();
        }
    }
}
