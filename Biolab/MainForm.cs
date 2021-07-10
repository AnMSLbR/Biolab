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
    public partial class MainForm : Form
    {

        private SerialPort _connectedPort = new SerialPort();
        private ListItem _selectedListItem;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            searchPorts();
        }

        private void btn_ConnectPort_Click(object sender, EventArgs e)
        {
            if(_connectedPort.IsOpen)
            {
                closePort();
                btn_ConnectPort.Text = "Подключить";
            }
            else
            {
                openPort();
                btn_ConnectPort.Text = "Отключить";
            }
        }

        private void btn_RefreshPorts_Click(object sender, EventArgs e)
        {
            searchPorts();
        }


        private void openPort()
        {
            _connectedPort.BaudRate = 9600;
            _connectedPort.PortName = cb_Ports.SelectedItem.ToString();
            _connectedPort.Parity = Parity.None;
            _connectedPort.DataBits = 8;
            _connectedPort.StopBits = StopBits.One;

            try
            {
                _connectedPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void closePort()
        {
            try
            {
                _connectedPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


        private void searchPorts()
        {
            cb_Ports.Items.Clear();
            string[] portNames = SerialPort.GetPortNames();
            if (portNames.Length == 0)
            {
                cb_Ports.Text = "Нет доступных";
                btn_ConnectPort.Enabled = false;
            }
            else
            {
                foreach (string portName in portNames)
                {
                    cb_Ports.Items.Add(portName);
                }
                cb_Ports.SelectedItem = portNames[0];
                btn_ConnectPort.Enabled = true;
            }
        }

        private void btn_AddPoint_Click(object sender, EventArgs e)
        {
            //ExperimentForm experimentForm = new ExperimentForm(_connectedPort);
            //experimentForm.ShowDialog();
            ListItem listItem = new ListItem();
            listItem.PointID = "Точка N";
            listItem.Title = "Название";
            listItem.RecordDate = DateTime.Now;
            listItem.Click += new EventHandler(listItem_click);
            flw_ListItems.Controls.Add(listItem);
        }

        private void btn_DeletePoint_Click(object sender, EventArgs e)
        {
            
        }

        private void listItem_click (object sender, EventArgs e)
        {
            if (_selectedListItem != null)
                _selectedListItem.BorderStyle = BorderStyle.None;
            _selectedListItem = (ListItem)sender;
            _selectedListItem.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
