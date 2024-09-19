namespace _05._03_Porównywanie_wartości_referencyjnych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horsePower1 = 350;
            int horsePower2 = 350;

            bool valueTypeEquality = horsePower1 == horsePower2;

            Car car1 = new Car(horsePower1);
            Car car2 = new Car(horsePower2);

            bool referenceTypeEquality = car1.Equals(car2);
            bool referenceTypeEquality2 = car1 == car2;

            Console.WriteLine($"valueTypeEquality: {valueTypeEquality}");
            Console.WriteLine($"referenceTypeEquality: {referenceTypeEquality}");
            Console.WriteLine($"referenceTypeEquality2: {referenceTypeEquality2}");
        }
    }

    class Car
    {
        public static bool operator ==(Car left, Car right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Car left, Car right)
        {
            return Equals(left, right);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (this.GetType() != obj.GetType()) return false;

            Car carobj = (Car)obj;

            return this.HorsePower == carobj.HorsePower;
        }

        public int HorsePower { get; set; }

        public Car(int horsePower)
        {
            HorsePower = horsePower;
        }
    }
}
