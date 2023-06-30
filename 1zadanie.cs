﻿using System;

public class Program
{
    public static void Main()
    {
        Student student = new Student("Lukasz", "Krysiak", 123456);
        Przedmiot przedmiot = new Przedmiot("Podstawy programowanie", "PP");
        NauczycielAkademicki nauczyciel = new NauczycielAkademicki("Jan", "Kowalski", "dr hab.");

        Console.WriteLine("Student: " + student.Imie + " " + student.Nazwisko + ", numer indeksu: " + student.NumerIndeksu);
        Console.WriteLine("Przedmiot: " + przedmiot.Nazwa + ", skrót: " + przedmiot.Skrot);
        Console.WriteLine("Nauczyciel akademicki: " + nauczyciel.Imie + " " + nauczyciel.Nazwisko + ", tytuł naukowy: " + nauczyciel.TytulNaukowy);
    }

    public struct Student
    {
        public string Imie;
        public string Nazwisko;
        public int NumerIndeksu;

        public Student(string imie, string nazwisko, int numerIndeksu)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            NumerIndeksu = numerIndeksu;
        }
    }

    public struct Przedmiot
    {
        public string Nazwa;
        public string Skrot;

        public Przedmiot(string nazwa, string skrot)
        {
            Nazwa = nazwa;
            Skrot = skrot;
        }
    }

    public struct NauczycielAkademicki
    {
        public string Imie;
        public string Nazwisko;
        public string TytulNaukowy;

        public NauczycielAkademicki(string imie, string nazwisko, string tytulNaukowy)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            TytulNaukowy = tytulNaukowy;
        }
    }
}