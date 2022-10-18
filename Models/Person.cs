using System.ComponentModel.DataAnnotations;

namespace ContactListApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }

        [StringLength(60, MinimumLength = 5, ErrorMessage = "Password must be longer than 5 symbols.")]
        [RegularExpression("(.*[A-Z].*)", ErrorMessage = "Password must containt at lest one Uppercase letter.")]
        public string password { get; set; }
        public Category category { get; set; }
        public int phone { get; set; }
        public DateTime dob { get; set; }

        public Person()
        {

        }
    }
}
