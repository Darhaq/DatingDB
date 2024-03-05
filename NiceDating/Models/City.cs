using System.ComponentModel.DataAnnotations;

namespace DatingDB.Models
{
    public class City
    {
        public City()
        {
            Person = new List<Person>();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide a City Name")]
        [StringLength(10)]
        public string CityName { get; set; } = null!;

        public List<Person> Person { get; set; }
    }
}
