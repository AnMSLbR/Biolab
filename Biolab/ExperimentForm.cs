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
        private List<Experiment> _experiments;
        private Experiment _experiment;
        private int _experimentId = 0;

        public ExperimentForm()
        {
            InitializeComponent();
        }

        public ExperimentForm(List<Experiment> experiments)
        {
            InitializeComponent();
            this._experiments = experiments;
            this._experiment = new Experiment();
            lbl_PointN.Text = "Точка " + (experiments.Count + 1);
        }

        public ExperimentForm(List<Experiment> experiments, ListItem listItem)
        {
            InitializeComponent();
            this._experiments = experiments;
            _experimentId = listItem.PointID;
            this._experiment = experiments[_experimentId - 1];
            lbl_PointN.Text = "Точка " + _experimentId;
            tb_ExperimentTitle.Text = _experiment.Title;
            tb_ExperimentDescription.Text = _experiment.Description;
            numericUD_Distance.Value = _experiment.Coordinate;

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (numericUD_Distance.Value == 0)
                MessageBox.Show("Нельзя задать точку старта в качестве координаты для остановки");          
            else
            {
                SetExperimentProperties();
                //SaveExperiment();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pb_distanceHelp_Click(object sender, EventArgs e)
        {
            int showDuration = 10000;
            toolTip_distanceHelp.Show(toolTip_distanceHelp.GetToolTip(pb_distanceHelp), pb_distanceHelp, showDuration);
        }

        private void SetExperimentProperties()
        {
            _experiment.Title = tb_ExperimentTitle.Text;
            _experiment.Description = tb_ExperimentDescription.Text;
            _experiment.Coordinate = Convert.ToInt32(numericUD_Distance.Value);
            if (_experimentId == 0)
                _experiments.Add(_experiment);
            //return _experiment;
        } 

        //private void SaveExperiment()
        //{
        //    _experiments.Add(SetExperimentProperties());
        //}

        private void numericUD_Distance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }


    }
}
