namespace Assessment7Prep.Models
{
    public class DonutResults
    {
        public int count { get; set; }
        public DonutData[] results { get; set; }
    }

    public class DonutData
    {
        public int id { get; set; }
        public string _ref { get; set; }
        public string name { get; set; }
    }

}
