
namespace Biolab
{
    partial class ExperimentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExperimentForm));
            this.lbl_ExperimentTitle = new System.Windows.Forms.Label();
            this.lbl_ExperimentDescription = new System.Windows.Forms.Label();
            this.tb_ExperimentTitle = new System.Windows.Forms.TextBox();
            this.tb_ExperimentDescription = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_PointN = new System.Windows.Forms.Label();
            this.lbl_Distance = new System.Windows.Forms.Label();
            this.pb_distanceHelp = new System.Windows.Forms.PictureBox();
            this.toolTip_distanceHelp = new System.Windows.Forms.ToolTip(this.components);
            this.numericUD_Distance = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pb_distanceHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_Distance)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ExperimentTitle
            // 
            this.lbl_ExperimentTitle.AutoSize = true;
            this.lbl_ExperimentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ExperimentTitle.Location = new System.Drawing.Point(12, 50);
            this.lbl_ExperimentTitle.Name = "lbl_ExperimentTitle";
            this.lbl_ExperimentTitle.Size = new System.Drawing.Size(83, 20);
            this.lbl_ExperimentTitle.TabIndex = 0;
            this.lbl_ExperimentTitle.Text = "Название";
            // 
            // lbl_ExperimentDescription
            // 
            this.lbl_ExperimentDescription.AutoSize = true;
            this.lbl_ExperimentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ExperimentDescription.Location = new System.Drawing.Point(12, 103);
            this.lbl_ExperimentDescription.Name = "lbl_ExperimentDescription";
            this.lbl_ExperimentDescription.Size = new System.Drawing.Size(83, 20);
            this.lbl_ExperimentDescription.TabIndex = 1;
            this.lbl_ExperimentDescription.Text = "Описание";
            // 
            // tb_ExperimentTitle
            // 
            this.tb_ExperimentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ExperimentTitle.Location = new System.Drawing.Point(12, 73);
            this.tb_ExperimentTitle.Name = "tb_ExperimentTitle";
            this.tb_ExperimentTitle.Size = new System.Drawing.Size(318, 24);
            this.tb_ExperimentTitle.TabIndex = 2;
            this.tb_ExperimentTitle.TabStop = false;
            // 
            // tb_ExperimentDescription
            // 
            this.tb_ExperimentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ExperimentDescription.Location = new System.Drawing.Point(12, 126);
            this.tb_ExperimentDescription.Multiline = true;
            this.tb_ExperimentDescription.Name = "tb_ExperimentDescription";
            this.tb_ExperimentDescription.Size = new System.Drawing.Size(318, 179);
            this.tb_ExperimentDescription.TabIndex = 3;
            this.tb_ExperimentDescription.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.Location = new System.Drawing.Point(12, 419);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(150, 40);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.TabStop = false;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Cancel.Location = new System.Drawing.Point(180, 419);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(150, 40);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.TabStop = false;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_PointN
            // 
            this.lbl_PointN.AutoSize = true;
            this.lbl_PointN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PointN.Location = new System.Drawing.Point(10, 9);
            this.lbl_PointN.Name = "lbl_PointN";
            this.lbl_PointN.Size = new System.Drawing.Size(75, 20);
            this.lbl_PointN.TabIndex = 6;
            this.lbl_PointN.Text = "Точка N";
            // 
            // lbl_Distance
            // 
            this.lbl_Distance.AutoSize = true;
            this.lbl_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Distance.Location = new System.Drawing.Point(12, 341);
            this.lbl_Distance.Name = "lbl_Distance";
            this.lbl_Distance.Size = new System.Drawing.Size(98, 20);
            this.lbl_Distance.TabIndex = 7;
            this.lbl_Distance.Text = "Расстояние";
            // 
            // pb_distanceHelp
            // 
            this.pb_distanceHelp.Image = ((System.Drawing.Image)(resources.GetObject("pb_distanceHelp.Image")));
            this.pb_distanceHelp.Location = new System.Drawing.Point(110, 338);
            this.pb_distanceHelp.Name = "pb_distanceHelp";
            this.pb_distanceHelp.Size = new System.Drawing.Size(25, 25);
            this.pb_distanceHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_distanceHelp.TabIndex = 9;
            this.pb_distanceHelp.TabStop = false;
            this.toolTip_distanceHelp.SetToolTip(this.pb_distanceHelp, "Задайте расстояние в сантиметрах, \r\nна которое должна переместиться \r\nплатформа о" +
        "т точки старта.\r\n");
            this.pb_distanceHelp.Click += new System.EventHandler(this.pb_distanceHelp_Click);
            // 
            // numericUD_Distance
            // 
            this.numericUD_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUD_Distance.Location = new System.Drawing.Point(12, 366);
            this.numericUD_Distance.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUD_Distance.Name = "numericUD_Distance";
            this.numericUD_Distance.Size = new System.Drawing.Size(318, 24);
            this.numericUD_Distance.TabIndex = 10;
            this.numericUD_Distance.TabStop = false;
            this.numericUD_Distance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUD_Distance_KeyPress);
            this.numericUD_Distance.Controls[0].Visible = false;
            // 
            // ExperimentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 472);
            this.Controls.Add(this.numericUD_Distance);
            this.Controls.Add(this.pb_distanceHelp);
            this.Controls.Add(this.lbl_Distance);
            this.Controls.Add(this.lbl_PointN);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_ExperimentDescription);
            this.Controls.Add(this.tb_ExperimentTitle);
            this.Controls.Add(this.lbl_ExperimentDescription);
            this.Controls.Add(this.lbl_ExperimentTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExperimentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Эксперимент";
            ((System.ComponentModel.ISupportInitialize)(this.pb_distanceHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_Distance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ExperimentTitle;
        private System.Windows.Forms.Label lbl_ExperimentDescription;
        private System.Windows.Forms.TextBox tb_ExperimentTitle;
        private System.Windows.Forms.TextBox tb_ExperimentDescription;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_PointN;
        private System.Windows.Forms.Label lbl_Distance;
        private System.Windows.Forms.PictureBox pb_distanceHelp;
        private System.Windows.Forms.ToolTip toolTip_distanceHelp;
        private System.Windows.Forms.NumericUpDown numericUD_Distance;
    }
}