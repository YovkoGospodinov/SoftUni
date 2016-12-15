using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MassDefect.Models
{
    public class Anomaly
    {
        private ICollection<Person> persons;

        public Anomaly()
        {
            this.persons = new HashSet<Person>();
        }

        [Key]
        public int Id { get; set; }

        public int OriginPlanetId { get; set; }
        
        public virtual Planet OriginPlanet { get; set; }

        public int TeleportPlanetId { get; set; }
        
        public virtual Planet TeleportPlanet { get; set; }

        public virtual ICollection<Person> Persons
        {
            get { return this.persons; }
            set { this.persons = value; }
        }
    }
}
