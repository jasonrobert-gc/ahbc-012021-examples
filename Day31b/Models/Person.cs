using System;

namespace Day31b.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string hair_color { get; set; }
        public string skin_color { get; set; }
        public string eye_color { get; set; }
        public string birth_year { get; set; }
        public string Gender { get; set; }
        public string Homeworld { get; set; }
        public string[] Films { get; set; }
        public object[] Species { get; set; }
        public string[] Vehicles { get; set; }
        public string[] Starships { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }

}
