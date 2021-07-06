using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Biolab
{
    public partial class ExperimentForm : Form
    {
        private SerialPort _port;
        public ExperimentForm(SerialPort port)
        {
            InitializeComponent();
            this._port = port;
        }
    }
}
