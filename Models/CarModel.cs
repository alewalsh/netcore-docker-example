using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreDockerExample.Models
{
    public class CarModel
    {
        [Key]
        public int CarModelID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Make")]
        public int MakeFK { get; set; }
        [ForeignKey("MakeFK")]
        public Make Make { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
