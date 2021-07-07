using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biolab
{
    class Experiment
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Coordinate { get; set; }

        public Experiment() { }

        public Experiment(string name, string description, int coordinate)
        {
            this.Name = name;
            this.Description = description;
            this.Coordinate = coordinate;
        }
    }
}
