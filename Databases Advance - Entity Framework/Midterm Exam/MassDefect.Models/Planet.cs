using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MassDefect.Models
{
    public class Planet
    {
        private ICollection<Person> persons;
        private ICollection<Anomaly> anomalies;

        public Planet()
        {
            this.persons = new HashSet<Person>();
            this.anomalies = new List<Anomaly>();
        }

        [Key]
        public int Id { get; set; }

        [Index(IsUnique = true), MinLength(1), MaxLength(450)]
        [Required]
        public string Name { get; set; }

        public int SunId { get; set; }

        public virtual Star Sun { get; set; }

        public int SolarSystemId { get; set; }

        public virtual SolarSystem SolarSystem { get; set; }
        
        public virtual ICollection<Person> Persons
        {
            get { return this.persons; }
            set { this.persons = value; }
        }

        public virtual ICollection<Anomaly> AnomaliesOrigin
        {
            get { return this.anomalies; }
            set { this.anomalies = value; }
        }

        public virtual ICollection<Anomaly> AnomaliesTeleport
        {
            get { return this.anomalies; }
            set { this.anomalies = value; }
        }
    }
}
