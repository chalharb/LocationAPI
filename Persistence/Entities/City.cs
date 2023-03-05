using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LocationAPI.Persistence.Entities
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        public int StateId { get; set; }
        public State? State { get; set; }

        public City()
        {
            Id = Guid.NewGuid();
        }
    }
}
