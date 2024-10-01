namespace _06._02_Deserializacja_i_Serializacja_do_JSON
{
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public List<Statistic> Statistics { get; set; }
    }
}


