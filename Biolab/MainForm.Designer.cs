
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
            this.btn_RefreshPorts = new System.Windows.Forms.Button();
            this.pnl_ConnectPorts = new System.Windows.Forms.Panel();
            this.pnl_Trajectory = new System.Windows.Forms.Panel();
            this.btn_DeleteAllPoints = new System.Windows.Forms.Button();
            this.flw_ListItems = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_editPoint = new System.Windows.Forms.Button();
            this.btn_DeletePoint = new System.Windows.Forms.Button();
            this.btn_AddPoint = new System.Windows.Forms.Button();
            this.toolTip_MainForm = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_ConnectPorts.SuspendLayout();
            this.pnl_Trajectory.SuspendLayout();
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
            // btn_DeleteAllPoints
            // 
            this.btn_DeleteAllPoints.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DeleteAllPoints.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DeleteAllPoints.BackgroundImage")));
            this.btn_DeleteAllPoints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_DeleteAllPoints.Location = new System.Drawing.Point(312, 12);
            this.btn_DeleteAllPoints.Name = "btn_DeleteAllPoints";
            this.btn_DeleteAllPoints.Size = new System.Drawing.Size(55, 47);
            this.btn_DeleteAllPoints.TabIndex = 9;
            this.btn_DeleteAllPoints.TabStop = false;
            this.toolTip_MainForm.SetToolTip(this.btn_DeleteAllPoints, "Очистить список");
            this.btn_DeleteAllPoints.UseVisualStyleBackColor = false;
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
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Траектория:";
            // 
            // btn_editPoint
            // 
            this.btn_editPoint.BackColor = System.Drawing.SystemColors.Control;
            this.btn_editPoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editPoint.BackgroundImage")));
            this.btn_editPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_editPoint.Location = new System.Drawing.Point(182, 12);
            this.btn_editPoint.Name = "btn_editPoint";
            this.btn_editPoint.Size = new System.Drawing.Size(55, 47);
            this.btn_editPoint.TabIndex = 7;
            this.btn_editPoint.TabStop = false;
            this.toolTip_MainForm.SetToolTip(this.btn_editPoint, "Редактировать");
            this.btn_editPoint.UseVisualStyleBackColor = false;
            // 
            // btn_DeletePoint
            // 
            this.btn_DeletePoint.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DeletePoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DeletePoint.BackgroundImage")));
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(408, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1499, 994);
            this.panel1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1001);
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
    }
}

