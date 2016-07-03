using System.Collections.Generic;

namespace _06.RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }

        public Engine Engine
        {
            get
            {
                return this.engine;
            }
        }

        public Cargo Cargo
        {
            get
            {
                return this.cargo;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public List<Tire> Tires
        {
            get
            {
                return this.tires;
            }
        }
    }
}
