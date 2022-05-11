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
using System.IO;
using System.Threading;

namespace Biolab
{
    public partial class MainForm : Form
    {

        private SerialPort _connectedPort = new SerialPort();
        private ListItem _selectedListItem;
        private delegate void HandleDataDelegate(string text);
        private ControllerCommandTranslator _translator = new ControllerCommandTranslator();

        private List<Experiment> _experimentList = new List<Experiment>();

        public MainForm()
        {
            CreatePhotoFolder();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateListItems();
            UpdateControls();
            searchPorts();

            //btn_editPoint.Enabled = false;
            //btn_DeletePoint.Enabled = false;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            closePort();
        }
        private void btn_ConnectPort_Click(object sender, EventArgs e)
        {
            if (_connectedPort.IsOpen)
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

            _connectedPort.DataReceived += new SerialDataReceivedEventHandler(ReceiveData);
            try
            {
                _connectedPort.Open();
                PingConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);
            string data = String.Empty;
            data = _connectedPort.ReadLine();
            this.BeginInvoke(new HandleDataDelegate(HandleData), data);
        }

        private void HandleData(string data)
        {
            switch(_translator.TranslateFromController(data))
            {
                case "connected":
                    tb_Log.Text += "Контроллер подключен\r\n";
                    break;
            }
        }

        private void closePort()
        {
            try
            {
                _connectedPort.Close();
                _connectedPort.DataReceived -= new SerialDataReceivedEventHandler(ReceiveData);
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

        private void PingConnection()
        {
            SendData(_translator.ComposePingCommand());
        }

        private void SendData(string command)
        {
            try
            {
                _connectedPort.Write(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_AddPoint_Click(object sender, EventArgs e)
        {
            ExperimentForm experimentForm = new ExperimentForm(_experimentList);
            DialogResult result = experimentForm.ShowDialog();
            if (result == DialogResult.OK)
                UpdateListItems();
                    //AddExperimentToList();

        }

        private void btn_editPoint_Click(object sender, EventArgs e)
        {
            ExperimentForm experimentForm = new ExperimentForm(_experimentList, _selectedListItem);
            DialogResult result = experimentForm.ShowDialog();
            if (result == DialogResult.OK)
                UpdateListItems();
                    //UpdateListItem();
        }

        private void btn_DeletePoint_Click(object sender, EventArgs e)
        {
            _experimentList.RemoveAt(_selectedListItem.PointID - 1);
            UpdateListItems();
        }


        private void btn_DeleteAllPoints_Click(object sender, EventArgs e)
        {
            _experimentList.Clear();
            UpdateListItems();
        }
        //private void AddExperimentToList()
        //{
        //    ListItem listItem = new ListItem();
        //    listItem.PointID = _experimentList.Count;
        //    listItem.Title = _experimentList.Last<Experiment>().Title;
        //    listItem.RecordDate = "—";
        //    listItem.Click += new EventHandler(listItem_Click);
        //    flw_ListItems.Controls.Add(listItem);
        //}

        //private void UpdateListItem()
        //{
        //    _selectedListItem.Title = _experimentList[_selectedListItem.PointID - 1].Title;
        //}

        private void UpdateListItems()
        {
            if (_experimentList.Any())
            {
                flw_ListItems.Controls.Clear();
                _selectedListItem = null;
                int id = 1;
                foreach (Experiment experiment in _experimentList)
                {
                    ListItem listItem = new ListItem();
                    listItem.PointID = id;
                    listItem.Title = experiment.Title;
                    listItem.RecordDate = "—";
                    listItem.Click += new EventHandler(listItem_Click);
                    flw_ListItems.Controls.Add(listItem);
                    id++;
                }
            }
            else
                flw_ListItems.Controls.Clear();
            UpdateControls();
        }

        private void UpdateControls()
        {
            if (_selectedListItem != null)
            {
                btn_editPoint.Enabled = true;
                btn_editPoint.BackgroundImage = Properties.Resources.editPoint_btn;
                btn_editPoint.BackgroundImageLayout = ImageLayout.Zoom;
                btn_DeletePoint.Enabled = true;
                btn_DeletePoint.BackgroundImage = Properties.Resources.deletePoint_btn;
                btn_DeletePoint.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                btn_editPoint.Enabled = false;
                btn_editPoint.BackgroundImage = Properties.Resources.editPointDisabled_btn;
                btn_editPoint.BackgroundImageLayout = ImageLayout.Zoom;
                btn_DeletePoint.Enabled = false;
                btn_DeletePoint.BackgroundImage = Properties.Resources.deletePointDisabled_btn;
                btn_DeletePoint.BackgroundImageLayout = ImageLayout.Zoom;
            }

            if(_experimentList.Any())
            {
                btn_DeleteAllPoints.Enabled = true;
                btn_DeleteAllPoints.BackgroundImage = Properties.Resources.deleteAllPoints_btn;
                btn_DeleteAllPoints.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                btn_DeleteAllPoints.Enabled = false;
                btn_DeleteAllPoints.BackgroundImage = Properties.Resources.deleteAllPointsDisabled_btn;
                btn_DeleteAllPoints.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void listItem_Click(object sender, EventArgs e)
        {
            if (_selectedListItem != null)
                _selectedListItem.BorderStyle = BorderStyle.None;
            _selectedListItem = (ListItem)sender;
            _selectedListItem.BorderStyle = BorderStyle.FixedSingle;
            UpdateControls();
        }

        private void CreatePhotoFolder()
        {
            string path = "Photo";
            try
            {
                if(!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_StartMoving_Click(object sender, EventArgs e)
        {
            StartMoving();
        }

        private void StartMoving()
        {
            _translator.ComposeMovingCommand();
        }
    }
}
