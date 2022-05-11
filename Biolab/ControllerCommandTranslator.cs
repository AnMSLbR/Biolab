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
        private string[] _movementCommand;

        public ControllerCommandTranslator()
        { }

        public string TranslateFromController(string str)
        {
            if(str[0] == 'C')
            {
                _command = "connected";
                return _command;
            }
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

        public string[] ComposeMovingCommand()
        {
            return _movementCommand;
        }
    }
}
