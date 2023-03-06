using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocationAPI.Models
{
    public class State
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "State Name is required")]
        [MaxLength(50, ErrorMessage = "State Name cannot be longer than 50 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "State Abbreviation is required")]
        [MaxLength(2, ErrorMessage = "State Abbrevation cannot be longer than 2 characters")]
        public string? Abbreviation { get; set; }

        public ICollection<City> Cities { get; set; } = new List<City>();

        public State()
        {
            Id = Guid.NewGuid();
        }
    }
}
