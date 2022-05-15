using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biolab
{
    class ControllerCommandTranslator
    {

        private int _distance;
        private string _command;
        private int _currentPoint;
        private List<string> _movingCommandList;

        public int CurrentPoint => _currentPoint; 
        public ControllerCommandTranslator()
        { }

        public string TranslateFromController(string str)
        {
            if(str == "C")
            {
                _command = "connected";
                return _command;
            }
            else if(str[0] == '1' && str[1] == '_')
            {
                _command = "successful";
                _currentPoint = Convert.ToInt32(str.Substring(str.IndexOf('_')+1, str.Length-2));
                return _command;
            }
            else if (str == "Z")
            {
                _command = "zero";
                return _command;
            }
            else if (str == "P")
            {
                _command = "pause";
                return _command;
            }
            //else if(str[0] == '0')
            //{
            //    _command = "unsuccessful";
            //    return _command;
            //}
            else
            {
                _command = "error";
                return _command;
            }
        }

        public string ComposePingCommand()
        {
            _command = "C";
            return _command;
        }

        public List<string> ComposeMovingCommand(List<Experiment> experiments)
        {
            string command = string.Empty;
            foreach (Experiment experiment in experiments)
            {
                command = "S_" + experiment.Coordinate;
                _movingCommandList.Add(command);
            }
            return _movingCommandList;
        }
    }
}
