using System.ComponentModel.DataAnnotations;

namespace DatingDB.Models
{
    public class Gender
    {
        public Gender()
        {
            Person = new List<Person>();
        }

        [Required(ErrorMessage = "Please provide a Gender Name")]
        [StringLength(10)]
        public string Id { get; set; } = null!;

        public List<Person> Person { get; set; }
    }
}
