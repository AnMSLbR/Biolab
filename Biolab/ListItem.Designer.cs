
namespace Biolab
{
    partial class ListItem
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_PointID = new System.Windows.Forms.Label();
            this.lbl_PointTitle = new System.Windows.Forms.Label();
            this.lbl_RecordDate = new System.Windows.Forms.Label();
            this.pnl_Line = new System.Windows.Forms.Panel();
            this.lbl_RecordDateValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_PointID
            // 
            this.lbl_PointID.AutoSize = true;
            this.lbl_PointID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PointID.Location = new System.Drawing.Point(12, 8);
            this.lbl_PointID.Name = "lbl_PointID";
            this.lbl_PointID.Size = new System.Drawing.Size(50, 20);
            this.lbl_PointID.TabIndex = 0;
            this.lbl_PointID.Text = "Point";
            this.lbl_PointID.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.lbl_PointID.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // lbl_PointTitle
            // 
            this.lbl_PointTitle.AutoSize = true;
            this.lbl_PointTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PointTitle.Location = new System.Drawing.Point(12, 30);
            this.lbl_PointTitle.Name = "lbl_PointTitle";
            this.lbl_PointTitle.Size = new System.Drawing.Size(38, 20);
            this.lbl_PointTitle.TabIndex = 1;
            this.lbl_PointTitle.Text = "Title";
            this.lbl_PointTitle.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.lbl_PointTitle.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // lbl_RecordDate
            // 
            this.lbl_RecordDate.AutoSize = true;
            this.lbl_RecordDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_RecordDate.Location = new System.Drawing.Point(13, 53);
            this.lbl_RecordDate.Name = "lbl_RecordDate";
            this.lbl_RecordDate.Size = new System.Drawing.Size(85, 16);
            this.lbl_RecordDate.TabIndex = 2;
            this.lbl_RecordDate.Text = "RecordDate:";
            this.lbl_RecordDate.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.lbl_RecordDate.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // pnl_Line
            // 
            this.pnl_Line.BackColor = System.Drawing.Color.Silver;
            this.pnl_Line.Location = new System.Drawing.Point(3, 76);
            this.pnl_Line.Name = "pnl_Line";
            this.pnl_Line.Size = new System.Drawing.Size(348, 1);
            this.pnl_Line.TabIndex = 3;
            // 
            // lbl_RecordDateValue
            // 
            this.lbl_RecordDateValue.AutoSize = true;
            this.lbl_RecordDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_RecordDateValue.Location = new System.Drawing.Point(168, 53);
            this.lbl_RecordDateValue.Name = "lbl_RecordDateValue";
            this.lbl_RecordDateValue.Size = new System.Drawing.Size(37, 16);
            this.lbl_RecordDateValue.TabIndex = 4;
            this.lbl_RecordDateValue.Text = "Date";
            this.lbl_RecordDateValue.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.lbl_RecordDateValue.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lbl_RecordDateValue);
            this.Controls.Add(this.pnl_Line);
            this.Controls.Add(this.lbl_RecordDate);
            this.Controls.Add(this.lbl_PointTitle);
            this.Controls.Add(this.lbl_PointID);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(330, 79);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListItem_MouseClick);
            this.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PointID;
        private System.Windows.Forms.Label lbl_PointTitle;
        private System.Windows.Forms.Label lbl_RecordDate;
        private System.Windows.Forms.Panel pnl_Line;
        private System.Windows.Forms.Label lbl_RecordDateValue;
    }
}
