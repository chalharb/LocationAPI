using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocationAPI.Persistence.Entities
{
    public class State
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(3)]
        public string? Abbreviation { get; set; }

        public ICollection<City> Cities { get; set; } = new List<City>();

        public State() 
        {
            Id = Guid.NewGuid();
        }
    }
}
