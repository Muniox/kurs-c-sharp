// od wersji chyba C# 10 nie trzeba używać using
//using System;


using _02._17_Namespace.Enums; // aby dodowac klasy, interfejsy, enumy

namespace _02._17_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
            Gender gender = Gender.Female;
        }
    }
}
