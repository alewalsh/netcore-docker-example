using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreDockerExample.Models
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        public string Color { get; set; }
        [Required]
        public int Year { get; set; }
        
        [Display(Name = "Car Model")]
        public int CarModelFK { get; set; }
        [ForeignKey("CarModelFK")]
        public CarModel Model { get; set; }
    }
}
