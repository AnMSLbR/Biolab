
namespace Biolab
{
    partial class ImageManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageManager));
            this.tlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.listV_ImagesArea = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_OpenFolder = new System.Windows.Forms.Button();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.tlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPanel
            // 
            this.tlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlPanel.BackColor = System.Drawing.SystemColors.Window;
            this.tlPanel.ColumnCount = 1;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanel.Controls.Add(this.listV_ImagesArea, 0, 0);
            this.tlPanel.Location = new System.Drawing.Point(0, -3);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 1;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanel.Size = new System.Drawing.Size(1000, 926);
            this.tlPanel.TabIndex = 0;
            // 
            // listV_ImagesArea
            // 
            this.listV_ImagesArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listV_ImagesArea.BackColor = System.Drawing.SystemColors.Window;
            this.listV_ImagesArea.HideSelection = false;
            this.listV_ImagesArea.LargeImageList = this.imageList;
            this.listV_ImagesArea.Location = new System.Drawing.Point(3, 35);
            this.listV_ImagesArea.MultiSelect = false;
            this.listV_ImagesArea.Name = "listV_ImagesArea";
            this.listV_ImagesArea.Size = new System.Drawing.Size(994, 888);
            this.listV_ImagesArea.SmallImageList = this.imageList;
            this.listV_ImagesArea.TabIndex = 0;
            this.listV_ImagesArea.UseCompatibleStateImageBehavior = false;
            this.listV_ImagesArea.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listV_ImagesArea_ItemSelectionChanged);
            this.listV_ImagesArea.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listV_ImagesArea_MouseDoubleClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "ImageManager_FolderIcon.png");
            this.imageList.Images.SetKeyName(1, "ImageManager_ImageIcon.png");
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Back.Enabled = false;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Back.Location = new System.Drawing.Point(3, 930);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(230, 50);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Назад";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Show.Enabled = false;
            this.btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Show.Location = new System.Drawing.Point(258, 930);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(230, 50);
            this.btn_Show.TabIndex = 2;
            this.btn_Show.Text = "Просмотр";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Update.Location = new System.Drawing.Point(512, 930);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(230, 50);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Обновить";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_OpenFolder
            // 
            this.btn_OpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OpenFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OpenFolder.Location = new System.Drawing.Point(766, 930);
            this.btn_OpenFolder.Name = "btn_OpenFolder";
            this.btn_OpenFolder.Size = new System.Drawing.Size(230, 50);
            this.btn_OpenFolder.TabIndex = 4;
            this.btn_OpenFolder.Text = "Открыть в проводнике";
            this.btn_OpenFolder.UseVisualStyleBackColor = true;
            this.btn_OpenFolder.Click += new System.EventHandler(this.btn_OpenFolder_Click);
            // 
            // tb_Path
            // 
            this.tb_Path.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Path.Location = new System.Drawing.Point(3, 1);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.ReadOnly = true;
            this.tb_Path.Size = new System.Drawing.Size(994, 26);
            this.tb_Path.TabIndex = 5;
            // 
            // ImageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tb_Path);
            this.Controls.Add(this.btn_OpenFolder);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.tlPanel);
            this.Name = "ImageManager";
            this.Size = new System.Drawing.Size(1000, 991);
            this.Load += new System.EventHandler(this.ImageManager_Load);
            this.Leave += new System.EventHandler(this.ImageManager_Leave);
            this.tlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.ListView listV_ImagesArea;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_OpenFolder;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TextBox tb_Path;
    }
}
