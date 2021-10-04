using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biolab
{
    public class Experiment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Coordinate { get; set; }

        public Experiment() { }

        public Experiment(string title, string description, int coordinate)
        {
            this.Title = title;
            this.Description = description;
            this.Coordinate = coordinate;
        }
    }
}
