using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biolab
{
    class Trajectory
    {
        private int _point;
        private List<int> _trajectory;
        public Trajectory()
        { }
        

        private void AddPointToTrajectory(int Point)
        {
            this._trajectory.Add(Point);
        }
    }
}
