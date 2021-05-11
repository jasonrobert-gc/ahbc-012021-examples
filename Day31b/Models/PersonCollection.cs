namespace Day31b.Models
{
    public class PersonCollection
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public Person[] Results { get; set; }
    }
}
