using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MassDefect.Models
{
    public class Person
    {
        private ICollection<Anomaly> anomalies;

        public Person()
        {
            this.anomalies = new HashSet<Anomaly>();
        }
        [Key]
        public int Id { get; set; }

        [Index(IsUnique = true), MinLength(1), MaxLength(450)]
        [Required]
        public string Name { get; set; }

        public int HomePlanetId { get; set; }

        public virtual Planet HomePlanet { get; set; }

        public virtual ICollection<Anomaly> Anomalies
        {
            get { return this.anomalies; }
            set { this.anomalies = value; }
        }
    }
}
