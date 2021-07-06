
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip_RefreshPorts = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_ConnectPorts.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Ports
            // 
            this.cb_Ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Ports.FormattingEnabled = true;
            this.cb_Ports.Location = new System.Drawing.Point(105, 12);
            this.cb_Ports.Name = "cb_Ports";
            this.cb_Ports.Size = new System.Drawing.Size(152, 28);
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
            this.btn_ConnectPort.Location = new System.Drawing.Point(66, 49);
            this.btn_ConnectPort.Name = "btn_ConnectPort";
            this.btn_ConnectPort.Size = new System.Drawing.Size(191, 46);
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
            this.btn_RefreshPorts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RefreshPorts.Location = new System.Drawing.Point(13, 48);
            this.btn_RefreshPorts.Name = "btn_RefreshPorts";
            this.btn_RefreshPorts.Size = new System.Drawing.Size(47, 47);
            this.btn_RefreshPorts.TabIndex = 3;
            this.btn_RefreshPorts.TabStop = false;
            this.toolTip_RefreshPorts.SetToolTip(this.btn_RefreshPorts, "Обновить");
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
            this.pnl_ConnectPorts.Size = new System.Drawing.Size(273, 111);
            this.pnl_ConnectPorts.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(12, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 128);
            this.panel2.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1001);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_ConnectPorts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1918, 1038);
            this.Name = "MainForm";
            this.Text = "Biolab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnl_ConnectPorts.ResumeLayout(false);
            this.pnl_ConnectPorts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Ports;
        private System.Windows.Forms.Label label_Ports;
        private System.Windows.Forms.Button btn_ConnectPort;
        private System.Windows.Forms.Button btn_RefreshPorts;
        private System.Windows.Forms.Panel pnl_ConnectPorts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip_RefreshPorts;
    }
}

