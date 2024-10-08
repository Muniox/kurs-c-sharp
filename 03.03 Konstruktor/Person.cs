﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03_Konstruktor
{
    internal class Person
    {
        public string FirstName;
        public string LastName;

        private DateTime dateOfBirth;

        public Person(string firstName, string lastName)
        {
            Console.WriteLine("Constructor1");
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(DateTime dateOfBirth, string firstName, string lastName) : this (firstName, lastName)
        {
            Console.WriteLine("constructor2");
            SetDateOfBirth(dateOfBirth);
        }

        public void SetDateOfBirth(DateTime date)
        {
            if (date > DateTime.Now)
            {
                Console.WriteLine("Invalid date of birth");
            }
            else
            {
                dateOfBirth = date;
            }
        }

        public DateTime GetDateOfBirth() => dateOfBirth;

        public void SayHi() => Console.WriteLine($"Hi I'm {FirstName} {GetDateOfBirth()}");
    }
}
