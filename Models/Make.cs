using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreDockerExample.Models
{
    public class Make
    {
        [Key]
        public int MakeID { get; set; }
        public string Name { get; set; }

        public ICollection<CarModel> Models { get; set; }
    }
}
