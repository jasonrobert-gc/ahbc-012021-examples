namespace Assessment7Prep.Models
{
    public class Donut
    {
        public int id { get; set; }
        public string _ref { get; set; }
        public string name { get; set; }
        public int calories { get; set; }
        public string[] extras { get; set; }
        public string photo { get; set; }
        public string photo_attribution { get; set; }
    }
}
