using System;

public class Program
{
    public static void Main()
    {
        var numer_miesiąca = 0;
        var liczba_nadgodzin = 0.0;
        double stawka;
        double wynagrodzenie_brutto;
        double wynagrodzenie_netto;
        string[] miesiace = { "styczeń", "luty", "marzec", "kwiecień", "maj", "czerwiec", "lipiec", "sierpień", "wrzesień", "październik", "listopad", "grudzień" };
        int[] czas_pracy = { 168, 160, 176, 160, 160, 168, 176, 176, 160, 184, 168, 152 };
        Console.WriteLine("OBLICZANIE WYNAGRODZENIA ZA NADGODZINY (DODATEK 50%)\n");
        while (true)
        {
            Console.Write("Podaj liczbę nadgodzin: ");
            var line = Console.ReadLine();
            try
            {
                liczba_nadgodzin = Int32.Parse(line);
            }
            catch (Exception)
            {
                return;
            }
            do
            {
                Console.Write("Podaj numer miesiąca (1-12): ");
                String line2 = Console.ReadLine();
                try
                {
                    numer_miesiąca = Int32.Parse(line2);
                }
                catch (Exception)
                {
                    return;
                }
            }
            while (numer_miesiąca > 12 || numer_miesiąca == 0 || numer_miesiąca < 0);
            Console.Write("Podaj stawkę godzinową (brutto): ");
            String line3 = Console.ReadLine();
            try
            {
                stawka = Int32.Parse(line3);
            }
            catch (Exception)
            {
                return;
            }

            numer_miesiąca--;

            double a = stawka / 2;
            double stawka_nadgodziny = stawka + a;

            double nadgodziny_brutto = liczba_nadgodzin * stawka_nadgodziny;
            double nadgodziny_netto = nadgodziny_brutto * 0.750;

            wynagrodzenie_brutto = (czas_pracy[numer_miesiąca] * stawka) + nadgodziny_brutto;
            wynagrodzenie_netto = (wynagrodzenie_brutto) * 0.750;
            if (liczba_nadgodzin > 0)
            {
                Console.WriteLine("\n\nPODSUMOWANIE:");
                Console.WriteLine("------------------------------------------------------------------\n");
                Console.WriteLine($"Stawka godzinowa (brutto): {stawka}zł, liczba nadgodzin: {liczba_nadgodzin}");
                Console.WriteLine($"Miesiąc: {miesiace[numer_miesiąca]}, wymiar czasu pracy w tym miesiącu: {czas_pracy[numer_miesiąca]}.");
                Console.WriteLine($"\nLiczba nadgodzin: {liczba_nadgodzin}, wynagrodzenie brutto: {nadgodziny_brutto}zł");
                Console.WriteLine($"Liczba nadgodzin: {liczba_nadgodzin}, wynagrodzenie netto: {nadgodziny_netto}zł\n");
                Console.WriteLine($"\nWynagrodzenie całkowite brutto (podstawa + nadgodziny): {wynagrodzenie_brutto}zł");
                Console.WriteLine($"Wynagrodzenie całkowite netto (podstawa + nadgodziny): {wynagrodzenie_netto}zł");
                Console.WriteLine("------------------------------------------------------------------\n");
            }
            else
            {
                Console.WriteLine("\n\nPODSUMOWANIE:");
                Console.WriteLine("------------------------------------------------------------------\n");
                Console.WriteLine($"Stawka godzinowa: {stawka}zł");
                Console.WriteLine($"Miesiąc: {miesiace[numer_miesiąca]}, liczba godzin pracujących w tym miesiącu: {czas_pracy[numer_miesiąca]}.");
                Console.WriteLine($"\nWynagrodzenie brutto: {wynagrodzenie_brutto}zł");
                Console.WriteLine($"Wynagrodzenie netto: {wynagrodzenie_netto}zł");
                Console.WriteLine("------------------------------------------------------------------\n");
            }
        }

    }
}


