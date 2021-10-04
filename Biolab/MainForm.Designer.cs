
namespace Biolab
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cb_Ports = new System.Windows.Forms.ComboBox();
            this.label_Ports = new System.Windows.Forms.Label();
            this.btn_ConnectPort = new System.Windows.Forms.Button();
            this.pnl_ConnectPorts = new System.Windows.Forms.Panel();
            this.pnl_Trajectory = new System.Windows.Forms.Panel();
            this.flw_ListItems = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip_MainForm = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Distance = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_PointN = new System.Windows.Forms.Label();
            this.tb_ExperimentDescription = new System.Windows.Forms.TextBox();
            this.tb_ExperimentTitle = new System.Windows.Forms.TextBox();
            this.lbl_ExperimentDescription = new System.Windows.Forms.Label();
            this.lbl_ExperimentTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_DeleteAllPoints = new System.Windows.Forms.Button();
            this.btn_editPoint = new System.Windows.Forms.Button();
            this.btn_DeletePoint = new System.Windows.Forms.Button();
            this.btn_AddPoint = new System.Windows.Forms.Button();
            this.btn_RefreshPorts = new System.Windows.Forms.Button();
            this.pnl_ConnectPorts.SuspendLayout();
            this.pnl_Trajectory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Ports
            // 
            this.cb_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Ports.FormattingEnabled = true;
            this.cb_Ports.Location = new System.Drawing.Point(101, 12);
            this.cb_Ports.Name = "cb_Ports";
            this.cb_Ports.Size = new System.Drawing.Size(265, 28);
            this.cb_Ports.TabIndex = 0;
            this.cb_Ports.TabStop = false;
            // 
            // label_Ports
            // 
            this.label_Ports.AutoSize = true;
            this.label_Ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Ports.Location = new System.Drawing.Point(9, 15);
            this.label_Ports.Name = "label_Ports";
            this.label_Ports.Size = new System.Drawing.Size(90, 20);
            this.label_Ports.TabIndex = 1;
            this.label_Ports.Text = "COM-порт:";
            // 
            // btn_ConnectPort
            // 
            this.btn_ConnectPort.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ConnectPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ConnectPort.Location = new System.Drawing.Point(101, 48);
            this.btn_ConnectPort.Name = "btn_ConnectPort";
            this.btn_ConnectPort.Size = new System.Drawing.Size(265, 47);
            this.btn_ConnectPort.TabIndex = 2;
            this.btn_ConnectPort.TabStop = false;
            this.btn_ConnectPort.Text = "Подключить";
            this.btn_ConnectPort.UseVisualStyleBackColor = false;
            this.btn_ConnectPort.Click += new System.EventHandler(this.btn_ConnectPort_Click);
            // 
            // pnl_ConnectPorts
            // 
            this.pnl_ConnectPorts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_ConnectPorts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_ConnectPorts.Controls.Add(this.btn_ConnectPort);
            this.pnl_ConnectPorts.Controls.Add(this.btn_RefreshPorts);
            this.pnl_ConnectPorts.Controls.Add(this.label_Ports);
            this.pnl_ConnectPorts.Controls.Add(this.cb_Ports);
            this.pnl_ConnectPorts.Location = new System.Drawing.Point(12, 12);
            this.pnl_ConnectPorts.Name = "pnl_ConnectPorts";
            this.pnl_ConnectPorts.Size = new System.Drawing.Size(382, 111);
            this.pnl_ConnectPorts.TabIndex = 4;
            // 
            // pnl_Trajectory
            // 
            this.pnl_Trajectory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Trajectory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Trajectory.Controls.Add(this.btn_DeleteAllPoints);
            this.pnl_Trajectory.Controls.Add(this.flw_ListItems);
            this.pnl_Trajectory.Controls.Add(this.label1);
            this.pnl_Trajectory.Controls.Add(this.btn_editPoint);
            this.pnl_Trajectory.Controls.Add(this.btn_DeletePoint);
            this.pnl_Trajectory.Controls.Add(this.btn_AddPoint);
            this.pnl_Trajectory.Location = new System.Drawing.Point(12, 137);
            this.pnl_Trajectory.Name = "pnl_Trajectory";
            this.pnl_Trajectory.Size = new System.Drawing.Size(382, 869);
            this.pnl_Trajectory.TabIndex = 5;
            // 
            // flw_ListItems
            // 
            this.flw_ListItems.AutoScroll = true;
            this.flw_ListItems.BackColor = System.Drawing.SystemColors.Window;
            this.flw_ListItems.Location = new System.Drawing.Point(13, 75);
            this.flw_ListItems.Name = "flw_ListItems";
            this.flw_ListItems.Size = new System.Drawing.Size(354, 777);
            this.flw_ListItems.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Эксперимент:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(408, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1499, 994);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lbl_Distance);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.lbl_PointN);
            this.panel2.Controls.Add(this.tb_ExperimentDescription);
            this.panel2.Controls.Add(this.tb_ExperimentTitle);
            this.panel2.Controls.Add(this.lbl_ExperimentDescription);
            this.panel2.Controls.Add(this.lbl_ExperimentTitle);
            this.panel2.Location = new System.Drawing.Point(-2, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 914);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Дата съемки";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(13, 350);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 24);
            this.textBox1.TabIndex = 14;
            this.textBox1.TabStop = false;
            // 
            // lbl_Distance
            // 
            this.lbl_Distance.AutoSize = true;
            this.lbl_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Distance.Location = new System.Drawing.Point(11, 327);
            this.lbl_Distance.Name = "lbl_Distance";
            this.lbl_Distance.Size = new System.Drawing.Size(98, 20);
            this.lbl_Distance.TabIndex = 13;
            this.lbl_Distance.Text = "Расстояние";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 423);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(396, 472);
            this.listBox1.TabIndex = 12;
            // 
            // lbl_PointN
            // 
            this.lbl_PointN.AutoSize = true;
            this.lbl_PointN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PointN.Location = new System.Drawing.Point(9, 19);
            this.lbl_PointN.Name = "lbl_PointN";
            this.lbl_PointN.Size = new System.Drawing.Size(75, 20);
            this.lbl_PointN.TabIndex = 11;
            this.lbl_PointN.Text = "Точка N";
            // 
            // tb_ExperimentDescription
            // 
            this.tb_ExperimentDescription.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_ExperimentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ExperimentDescription.Location = new System.Drawing.Point(15, 136);
            this.tb_ExperimentDescription.Multiline = true;
            this.tb_ExperimentDescription.Name = "tb_ExperimentDescription";
            this.tb_ExperimentDescription.Size = new System.Drawing.Size(396, 179);
            this.tb_ExperimentDescription.TabIndex = 10;
            this.tb_ExperimentDescription.TabStop = false;
            // 
            // tb_ExperimentTitle
            // 
            this.tb_ExperimentTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_ExperimentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ExperimentTitle.Location = new System.Drawing.Point(13, 83);
            this.tb_ExperimentTitle.Name = "tb_ExperimentTitle";
            this.tb_ExperimentTitle.Size = new System.Drawing.Size(398, 24);
            this.tb_ExperimentTitle.TabIndex = 9;
            this.tb_ExperimentTitle.TabStop = false;
            // 
            // lbl_ExperimentDescription
            // 
            this.lbl_ExperimentDescription.AutoSize = true;
            this.lbl_ExperimentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ExperimentDescription.Location = new System.Drawing.Point(11, 113);
            this.lbl_ExperimentDescription.Name = "lbl_ExperimentDescription";
            this.lbl_ExperimentDescription.Size = new System.Drawing.Size(83, 20);
            this.lbl_ExperimentDescription.TabIndex = 8;
            this.lbl_ExperimentDescription.Text = "Описание";
            // 
            // lbl_ExperimentTitle
            // 
            this.lbl_ExperimentTitle.AutoSize = true;
            this.lbl_ExperimentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ExperimentTitle.Location = new System.Drawing.Point(11, 60);
            this.lbl_ExperimentTitle.Name = "lbl_ExperimentTitle";
            this.lbl_ExperimentTitle.Size = new System.Drawing.Size(83, 20);
            this.lbl_ExperimentTitle.TabIndex = 7;
            this.lbl_ExperimentTitle.Text = "Название";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(408, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 81);
            this.panel3.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(171, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 55);
            this.button3.TabIndex = 12;
            this.button3.TabStop = false;
            this.toolTip_MainForm.SetToolTip(this.button3, "Добавить");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = global::Biolab.Properties.Resources.stop_btn;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(90, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 11;
            this.button2.TabStop = false;
            this.toolTip_MainForm.SetToolTip(this.button2, "Добавить");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::Biolab.Properties.Resources.start_btn;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.toolTip_MainForm.SetToolTip(this.button1, "Добавить");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_DeleteAllPoints
            // 
            this.btn_DeleteAllPoints.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DeleteAllPoints.BackgroundImage = global::Biolab.Properties.Resources.deleteAllPointsDisabled_btn;
            this.btn_DeleteAllPoints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_DeleteAllPoints.Location = new System.Drawing.Point(312, 12);
            this.btn_DeleteAllPoints.Name = "btn_DeleteAllPoints";
            this.btn_DeleteAllPoints.Size = new System.Drawing.Size(55, 47);
            this.btn_DeleteAllPoints.TabIndex = 9;
            this.btn_DeleteAllPoints.TabStop = false;
            this.toolTip_MainForm.SetToolTip(this.btn_DeleteAllPoints, "Очистить список");
            this.btn_DeleteAllPoints.UseVisualStyleBackColor = false;
            this.btn_DeleteAllPoints.Click += new System.EventHandler(this.btn_DeleteAllPoints_Click);
            // 
            // btn_editPoint
            // 
            this.btn_editPoint.BackColor = System.Drawing.SystemColors.Control;
            this.btn_editPoint.BackgroundImage = global::Biolab.Properties.Resources.editPointDisabled_btn;
            this.btn_editPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_editPoint.Location = new System.Drawing.Point(182, 12);
            this.btn_editPoint.Name = "btn_editPoint";
            this.btn_editPoint.Size = new System.Drawing.Size(55, 47);
            this.btn_editPoint.TabIndex = 7;
            this.btn_editPoint.TabStop = false;
            this.toolTip_MainForm.SetToolTip(this.btn_editPoint, "Редактировать");
            this.btn_editPoint.UseVisualStyleBackColor = false;
            this.btn_editPoint.Click += new System.EventHandler(this.btn_editPoint_Click);
            // 
            // btn_DeletePoint
            // 
            this.btn_DeletePoint.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DeletePoint.BackgroundImage = global::Biolab.Properties.Resources.deletePointDisabled_btn;
            this.btn_DeletePoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_DeletePoint.Location = new System.Drawing.Point(247, 12);
            this.btn_DeletePoint.Name = "btn_DeletePoint";
            this.btn_DeletePoint.Size = new System.Drawing.Size(55, 47);
            this.btn_DeletePoint.TabIndex = 8;
            this.btn_DeletePoint.TabStop = false;
            this.toolTip_MainForm.SetToolTip(this.btn_DeletePoint, "Удалить");
            this.btn_DeletePoint.UseVisualStyleBackColor = false;
            this.btn_DeletePoint.Click += new System.EventHandler(this.btn_DeletePoint_Click);
            // 
            // btn_AddPoint
            // 
            this.btn_AddPoint.BackColor = System.Drawing.SystemColors.Control;
            this.btn_AddPoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddPoint.BackgroundImage")));
            this.btn_AddPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddPoint.Location = new System.Drawing.Point(117, 12);
            this.btn_AddPoint.Name = "btn_AddPoint";
            this.btn_AddPoint.Size = new System.Drawing.Size(55, 47);
            this.btn_AddPoint.TabIndex = 6;
            this.btn_AddPoint.TabStop = false;
            this.toolTip_MainForm.SetToolTip(this.btn_AddPoint, "Добавить");
            this.btn_AddPoint.UseVisualStyleBackColor = false;
            this.btn_AddPoint.Click += new System.EventHandler(this.btn_AddPoint_Click);
            // 
            // btn_RefreshPorts
            // 
            this.btn_RefreshPorts.BackColor = System.Drawing.SystemColors.Control;
            this.btn_RefreshPorts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_RefreshPorts.BackgroundImage")));
            this.btn_RefreshPorts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RefreshPorts.Location = new System.Drawing.Point(13, 48);
            this.btn_RefreshPorts.Name = "btn_RefreshPorts";
            this.btn_RefreshPorts.Size = new System.Drawing.Size(71, 47);
            this.btn_RefreshPorts.TabIndex = 3;
            this.btn_RefreshPorts.TabStop = false;
            this.toolTip_MainForm.SetToolTip(this.btn_RefreshPorts, "Обновить");
            this.btn_RefreshPorts.UseVisualStyleBackColor = false;
            this.btn_RefreshPorts.Click += new System.EventHandler(this.btn_RefreshPorts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1001);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Trajectory);
            this.Controls.Add(this.pnl_ConnectPorts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1918, 1038);
            this.Name = "MainForm";
            this.Text = "Biolab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnl_ConnectPorts.ResumeLayout(false);
            this.pnl_ConnectPorts.PerformLayout();
            this.pnl_Trajectory.ResumeLayout(false);
            this.pnl_Trajectory.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Ports;
        private System.Windows.Forms.Label label_Ports;
        private System.Windows.Forms.Button btn_ConnectPort;
        private System.Windows.Forms.Button btn_RefreshPorts;
        private System.Windows.Forms.Panel pnl_ConnectPorts;
        private System.Windows.Forms.Panel pnl_Trajectory;
        private System.Windows.Forms.ToolTip toolTip_MainForm;
        private System.Windows.Forms.Button btn_DeletePoint;
        private System.Windows.Forms.Button btn_editPoint;
        private System.Windows.Forms.Button btn_AddPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flw_ListItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DeleteAllPoints;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Distance;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_PointN;
        private System.Windows.Forms.TextBox tb_ExperimentDescription;
        private System.Windows.Forms.TextBox tb_ExperimentTitle;
        private System.Windows.Forms.Label lbl_ExperimentDescription;
        private System.Windows.Forms.Label lbl_ExperimentTitle;
    }
}

