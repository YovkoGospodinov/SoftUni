using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MassDefect.Models
{
    public class Star
    {
        private ICollection<Planet> planets;

        public Star()
        {
            this.planets = new HashSet<Planet>();
        }

        [Key]
        public int Id { get; set; }

        [Index(IsUnique = true), MinLength(1), MaxLength(450)]
        [Required]
        public string Name { get; set; }

        public int SolarSystemId { get; set; }

        public virtual SolarSystem SolarSystem { get; set; }

        public virtual ICollection<Planet> Planets
        {
            get { return this.planets; }
            set { this.planets = value; }
        }
    }
}
