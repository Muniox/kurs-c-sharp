using System.Reflection.Metadata.Ecma335;

namespace _04._03_LINQ
{
    internal class Program
    {
        static List<Person> GetEmployess()
        {
            List<Person> employess = new List<Person>()
            {
                new Person(new DateTime(1990, 2, 2), "Bill", "Wick"),
                new Person(new DateTime(1995, 6, 3), "John", "Wick"),
                new Person(new DateTime(1996, 4, 3), "Bob", "Wick"),
                new Person(new DateTime(2001, 2, 2), "Bill", "Smith"),
                new Person(new DateTime(2000, 2, 2), "John", "Smith"),
                new Person(new DateTime(2005, 2, 2), "Bob", "Smith"),
                new Person(new DateTime(2003, 2, 2), "Ed", "Smith"),
            };

            return employess;
        }


        static void Main(string[] args)
        {
            List<Person> employess = GetEmployess();
            //List<Person> youngEmployees = new List<Person>();

            //foreach (Person employee in employess)
            //{ 
            //    if (employee.GetDateOfBirth() > new DateTime(2000, 1, 1))
            //    {
            //        youngEmployees.Add(employee);
            //    }
            //}

            //Console.WriteLine($"Young employess count {youngEmployees.Count}");

            //Person? bob = null;
            //foreach (Person youngEmployee in youngEmployees)
            //{
            //    if (youngEmployee.FirstName == "Bob")
            //    {
            //        bob = youngEmployee;
            //        break;
            //    }
            //}

            //if (bob != null)
            //{
            //    bob.SayHi();
            //}
            //else
            //{
            //    Console.WriteLine("Bob not found!");
            //}

            bool EmployeeIsYoung(Person employee)
            {
                return employee.GetDateOfBirth() > new DateTime(2000, 1, 1);
            }
            List<Person> youngEmployees = employess.Where(EmployeeIsYoung).ToList();
            Console.WriteLine($"Young employess count {youngEmployees.Count}");

            bool EmployeeIsBob(Person employee)
            {
                return employee.FirstName == "Bob";
            }
            Person? bob = youngEmployees.FirstOrDefault(EmployeeIsBob);

            if (bob != null)
            {
                bob.SayHi();
            }
            else
            {
                Console.WriteLine("Bob not found!");
            }
        }
    }
}
