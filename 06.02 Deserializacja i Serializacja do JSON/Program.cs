using Newtonsoft.Json;

namespace _06._02_Deserializacja_i_Serializacja_do_JSON
{
    internal class Program
    {
        static void ReadJSON()
        {
            string playerSerialized = File.ReadAllText(@$"{AppDomain.CurrentDomain.BaseDirectory}\..\..\..\..\TextFiles\JSON\playerSerialized.json");
            Player player = JsonConvert.DeserializeObject<Player>(playerSerialized)!;

            Console.WriteLine(player.Name);
        }
        static void Main(string[] args)
        {
            var player = new Player()
            {
                Name = "Mario",
                Level = 1,
                HealthPoints = 100,
                Statistics = new List<Statistic>()
                {
                    new Statistic()
                    {
                        Name = "Strength",
                        Points = 10,
                    },
                    new Statistic() {
                        Name = "Intelligence",
                        Points = 10,
                    }
                }
            };

            player.Level++;

            string playerSerialized = JsonConvert.SerializeObject(player);

            File.WriteAllText(@$"{AppDomain.CurrentDomain.BaseDirectory}\..\..\..\..\TextFiles\JSON\playerSerialized.json", playerSerialized);
        }
    }
}
