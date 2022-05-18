
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
            this.lbl_Ports = new System.Windows.Forms.Label();
            this.btn_ConnectPort = new System.Windows.Forms.Button();
            this.pnl_ConnectPorts = new System.Windows.Forms.Panel();
            this.btn_RefreshPorts = new System.Windows.Forms.Button();
            this.pnl_Trajectory = new System.Windows.Forms.Panel();
            this.btn_DeleteAllPoints = new System.Windows.Forms.Button();
            this.flw_ListItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Experiment = new System.Windows.Forms.Label();
            this.btn_editPoint = new System.Windows.Forms.Button();
            this.btn_DeletePoint = new System.Windows.Forms.Button();
            this.btn_AddPoint = new System.Windows.Forms.Button();
            this.toolTip_MainForm = new System.Windows.Forms.ToolTip(this.components);
            this.btn_ReturnToStart = new System.Windows.Forms.Button();
            this.btn_StopMoving = new System.Windows.Forms.Button();
            this.btn_StartMoving = new System.Windows.Forms.Button();
            this.pnl_ExperimentInformation = new System.Windows.Forms.Panel();
            this.tb_Log = new System.Windows.Forms.TextBox();
            this.lbl_RecordDate = new System.Windows.Forms.Label();
            this.tb_Distance = new System.Windows.Forms.TextBox();
            this.lbl_Distance = new System.Windows.Forms.Label();
            this.lb_ListOfDates = new System.Windows.Forms.ListBox();
            this.lbl_PointN = new System.Windows.Forms.Label();
            this.tb_ExperimentDescription = new System.Windows.Forms.TextBox();
            this.tb_ExperimentTitle = new System.Windows.Forms.TextBox();
            this.lbl_ExperimentDescription = new System.Windows.Forms.Label();
            this.lbl_ExperimentTitle = new System.Windows.Forms.Label();
            this.pnl_ControlButtons = new System.Windows.Forms.Panel();
            this.tlp_Workspace = new System.Windows.Forms.TableLayoutPanel();
            this.tc_Foto = new System.Windows.Forms.TabControl();
            this.tp_Images = new System.Windows.Forms.TabPage();
            this.tb_Cameras = new System.Windows.Forms.TabPage();
            this.im_ExperimentImages = new Biolab.ImageManager();
            this.pnl_ConnectPorts.SuspendLayout();
            this.pnl_Trajectory.SuspendLayout();
            this.pnl_ExperimentInformation.SuspendLayout();
            this.pnl_ControlButtons.SuspendLayout();
            this.tlp_Workspace.SuspendLayout();
            this.tc_Foto.SuspendLayout();
            this.tp_Images.SuspendLayout();
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
            // lbl_Ports
            // 
            this.lbl_Ports.AutoSize = true;
            this.lbl_Ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Ports.Location = new System.Drawing.Point(9, 15);
            this.lbl_Ports.Name = "lbl_Ports";
            this.lbl_Ports.Size = new System.Drawing.Size(90, 20);
            this.lbl_Ports.TabIndex = 1;
            this.lbl_Ports.Text = "COM-порт:";
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
            this.pnl_ConnectPorts.Controls.Add(this.lbl_Ports);
            this.pnl_ConnectPorts.Controls.Add(this.cb_Ports);
            this.pnl_ConnectPorts.Location = new System.Drawing.Point(12, 12);
            this.pnl_ConnectPorts.Name = "pnl_ConnectPorts";
            this.pnl_ConnectPorts.Size = new System.Drawing.Size(382, 111);
            this.pnl_ConnectPorts.TabIndex = 4;
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
            // pnl_Trajectory
            // 
            this.pnl_Trajectory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Trajectory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Trajectory.Controls.Add(this.btn_DeleteAllPoints);
            this.pnl_Trajectory.Controls.Add(this.flw_ListItems);
            this.pnl_Trajectory.Controls.Add(this.lbl_Experiment);
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
            // flw_ListItems
            // 
            this.flw_ListItems.AutoScroll = true;
            this.flw_ListItems.BackColor = System.Drawing.SystemColors.Window;
            this.flw_ListItems.Location = new System.Drawing.Point(13, 75);
            this.flw_ListItems.Name = "flw_ListItems";
            this.flw_ListItems.Size = new System.Drawing.Size(354, 777);
            this.flw_ListItems.TabIndex = 6;
            // 
            // lbl_Experiment
            // 
            this.lbl_Experiment.AutoSize = true;
            this.lbl_Experiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Experiment.Location = new System.Drawing.Point(3, 24);
            this.lbl_Experiment.Name = "lbl_Experiment";
            this.lbl_Experiment.Size = new System.Drawing.Size(115, 20);
            this.lbl_Experiment.TabIndex = 4;
            this.lbl_Experiment.Text = "Эксперимент:";
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
            // btn_ReturnToStart
            // 
            this.btn_ReturnToStart.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ReturnToStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ReturnToStart.BackgroundImage")));
            this.btn_ReturnToStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ReturnToStart.Location = new System.Drawing.Point(171, 12);
            this.btn_ReturnToStart.Name = "btn_ReturnToStart";
            this.btn_ReturnToStart.Size = new System.Drawing.Size(55, 55);
            this.btn_ReturnToStart.TabIndex = 12;
            this.btn_ReturnToStart.TabStop = false;
            this.toolTip_MainForm.SetToolTip(this.btn_ReturnToStart, "Добавить");
            this.btn_ReturnToStart.UseVisualStyleBackColor = false;
            this.btn_ReturnToStart.Click += new System.EventHandler(this.btn_ReturnToStart_Click);
            // 
            // btn_StopMoving
            // 
            this.btn_StopMoving.BackColor = System.Drawing.SystemColors.Control;
            this.btn_StopMoving.BackgroundImage = global::Biolab.Properties.Resources.stop_btn;
            this.btn_StopMoving.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_StopMoving.Location = new System.Drawing.Point(90, 12);
            this.btn_StopMoving.Name = "btn_StopMoving";
            this.btn_StopMoving.Size = new System.Drawing.Size(55, 55);
            this.btn_StopMoving.TabIndex = 11;
            this.btn_StopMoving.TabStop = false;
            this.toolTip_MainForm.SetToolTip(this.btn_StopMoving, "Добавить");
            this.btn_StopMoving.UseVisualStyleBackColor = false;
            this.btn_StopMoving.Click += new System.EventHandler(this.btn_StopMoving_Click);
            // 
            // btn_StartMoving
            // 
            this.btn_StartMoving.BackColor = System.Drawing.SystemColors.Control;
            this.btn_StartMoving.BackgroundImage = global::Biolab.Properties.Resources.start_btn;
            this.btn_StartMoving.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_StartMoving.Location = new System.Drawing.Point(13, 12);
            this.btn_StartMoving.Name = "btn_StartMoving";
            this.btn_StartMoving.Size = new System.Drawing.Size(55, 55);
            this.btn_StartMoving.TabIndex = 10;
            this.btn_StartMoving.TabStop = false;
            this.toolTip_MainForm.SetToolTip(this.btn_StartMoving, "Добавить");
            this.btn_StartMoving.UseVisualStyleBackColor = false;
            this.btn_StartMoving.Click += new System.EventHandler(this.btn_StartMoving_Click);
            // 
            // pnl_ExperimentInformation
            // 
            this.pnl_ExperimentInformation.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_ExperimentInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_ExperimentInformation.Controls.Add(this.tb_Log);
            this.pnl_ExperimentInformation.Controls.Add(this.lbl_RecordDate);
            this.pnl_ExperimentInformation.Controls.Add(this.tb_Distance);
            this.pnl_ExperimentInformation.Controls.Add(this.lbl_Distance);
            this.pnl_ExperimentInformation.Controls.Add(this.lb_ListOfDates);
            this.pnl_ExperimentInformation.Controls.Add(this.lbl_PointN);
            this.pnl_ExperimentInformation.Controls.Add(this.tb_ExperimentDescription);
            this.pnl_ExperimentInformation.Controls.Add(this.tb_ExperimentTitle);
            this.pnl_ExperimentInformation.Controls.Add(this.lbl_ExperimentDescription);
            this.pnl_ExperimentInformation.Controls.Add(this.lbl_ExperimentTitle);
            this.pnl_ExperimentInformation.Location = new System.Drawing.Point(3, 97);
            this.pnl_ExperimentInformation.Name = "pnl_ExperimentInformation";
            this.pnl_ExperimentInformation.Size = new System.Drawing.Size(487, 902);
            this.pnl_ExperimentInformation.TabIndex = 0;
            // 
            // tb_Log
            // 
            this.tb_Log.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Log.Location = new System.Drawing.Point(225, -7);
            this.tb_Log.Multiline = true;
            this.tb_Log.Name = "tb_Log";
            this.tb_Log.ReadOnly = true;
            this.tb_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Log.Size = new System.Drawing.Size(412, 864);
            this.tb_Log.TabIndex = 16;
            this.tb_Log.TabStop = false;
            this.tb_Log.Text = "dddddddddddddddddddddddd\r\ndddddddddddd\r\n";
            // 
            // lbl_RecordDate
            // 
            this.lbl_RecordDate.AutoSize = true;
            this.lbl_RecordDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_RecordDate.Location = new System.Drawing.Point(11, 388);
            this.lbl_RecordDate.Name = "lbl_RecordDate";
            this.lbl_RecordDate.Size = new System.Drawing.Size(108, 20);
            this.lbl_RecordDate.TabIndex = 15;
            this.lbl_RecordDate.Text = "Дата съемки";
            // 
            // tb_Distance
            // 
            this.tb_Distance.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Distance.Location = new System.Drawing.Point(15, 350);
            this.tb_Distance.Name = "tb_Distance";
            this.tb_Distance.Size = new System.Drawing.Size(462, 24);
            this.tb_Distance.TabIndex = 14;
            this.tb_Distance.TabStop = false;
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
            // lb_ListOfDates
            // 
            this.lb_ListOfDates.BackColor = System.Drawing.SystemColors.Menu;
            this.lb_ListOfDates.FormattingEnabled = true;
            this.lb_ListOfDates.Location = new System.Drawing.Point(15, 411);
            this.lb_ListOfDates.Name = "lb_ListOfDates";
            this.lb_ListOfDates.Size = new System.Drawing.Size(462, 472);
            this.lb_ListOfDates.TabIndex = 12;
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
            this.tb_ExperimentDescription.Location = new System.Drawing.Point(13, 136);
            this.tb_ExperimentDescription.Multiline = true;
            this.tb_ExperimentDescription.Name = "tb_ExperimentDescription";
            this.tb_ExperimentDescription.Size = new System.Drawing.Size(464, 179);
            this.tb_ExperimentDescription.TabIndex = 10;
            this.tb_ExperimentDescription.TabStop = false;
            // 
            // tb_ExperimentTitle
            // 
            this.tb_ExperimentTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_ExperimentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ExperimentTitle.Location = new System.Drawing.Point(13, 83);
            this.tb_ExperimentTitle.Name = "tb_ExperimentTitle";
            this.tb_ExperimentTitle.Size = new System.Drawing.Size(464, 24);
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
            // pnl_ControlButtons
            // 
            this.pnl_ControlButtons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_ControlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_ControlButtons.Controls.Add(this.btn_ReturnToStart);
            this.pnl_ControlButtons.Controls.Add(this.btn_StopMoving);
            this.pnl_ControlButtons.Controls.Add(this.btn_StartMoving);
            this.pnl_ControlButtons.Location = new System.Drawing.Point(3, 3);
            this.pnl_ControlButtons.Name = "pnl_ControlButtons";
            this.pnl_ControlButtons.Size = new System.Drawing.Size(487, 83);
            this.pnl_ControlButtons.TabIndex = 0;
            // 
            // tlp_Workspace
            // 
            this.tlp_Workspace.ColumnCount = 2;
            this.tlp_Workspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.63158F));
            this.tlp_Workspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.36842F));
            this.tlp_Workspace.Controls.Add(this.pnl_ControlButtons, 0, 0);
            this.tlp_Workspace.Controls.Add(this.pnl_ExperimentInformation, 0, 1);
            this.tlp_Workspace.Controls.Add(this.tc_Foto, 1, 0);
            this.tlp_Workspace.Location = new System.Drawing.Point(401, 9);
            this.tlp_Workspace.Name = "tlp_Workspace";
            this.tlp_Workspace.RowCount = 2;
            this.tlp_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.453781F));
            this.tlp_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.54622F));
            this.tlp_Workspace.Size = new System.Drawing.Size(1513, 1002);
            this.tlp_Workspace.TabIndex = 6;
            // 
            // tc_Foto
            // 
            this.tc_Foto.Controls.Add(this.tp_Images);
            this.tc_Foto.Controls.Add(this.tb_Cameras);
            this.tc_Foto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tc_Foto.Location = new System.Drawing.Point(496, 3);
            this.tc_Foto.Name = "tc_Foto";
            this.tlp_Workspace.SetRowSpan(this.tc_Foto, 2);
            this.tc_Foto.SelectedIndex = 0;
            this.tc_Foto.Size = new System.Drawing.Size(1014, 996);
            this.tc_Foto.TabIndex = 1;
            // 
            // tp_Images
            // 
            this.tp_Images.Controls.Add(this.im_ExperimentImages);
            this.tp_Images.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tp_Images.Location = new System.Drawing.Point(4, 29);
            this.tp_Images.Name = "tp_Images";
            this.tp_Images.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Images.Size = new System.Drawing.Size(1006, 963);
            this.tp_Images.TabIndex = 0;
            this.tp_Images.Text = "Фотографии";
            this.tp_Images.UseVisualStyleBackColor = true;
            // 
            // tb_Cameras
            // 
            this.tb_Cameras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tb_Cameras.Location = new System.Drawing.Point(4, 29);
            this.tb_Cameras.Name = "tb_Cameras";
            this.tb_Cameras.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Cameras.Size = new System.Drawing.Size(1006, 963);
            this.tb_Cameras.TabIndex = 1;
            this.tb_Cameras.Text = "Камеры";
            this.tb_Cameras.UseVisualStyleBackColor = true;
            // 
            // im_ExperimentImages
            // 
            this.im_ExperimentImages.BackColor = System.Drawing.SystemColors.Window;
            this.im_ExperimentImages.DirectoryPath = "Photo";
            this.im_ExperimentImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.im_ExperimentImages.Location = new System.Drawing.Point(3, 3);
            this.im_ExperimentImages.Name = "im_ExperimentImages";
            this.im_ExperimentImages.Size = new System.Drawing.Size(1000, 957);
            this.im_ExperimentImages.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1001);
            this.Controls.Add(this.tlp_Workspace);
            this.Controls.Add(this.pnl_Trajectory);
            this.Controls.Add(this.pnl_ConnectPorts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1918, 1038);
            this.Name = "MainForm";
            this.Text = "Biolab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnl_ConnectPorts.ResumeLayout(false);
            this.pnl_ConnectPorts.PerformLayout();
            this.pnl_Trajectory.ResumeLayout(false);
            this.pnl_Trajectory.PerformLayout();
            this.pnl_ExperimentInformation.ResumeLayout(false);
            this.pnl_ExperimentInformation.PerformLayout();
            this.pnl_ControlButtons.ResumeLayout(false);
            this.tlp_Workspace.ResumeLayout(false);
            this.tc_Foto.ResumeLayout(false);
            this.tp_Images.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Ports;
        private System.Windows.Forms.Label lbl_Ports;
        private System.Windows.Forms.Button btn_ConnectPort;
        private System.Windows.Forms.Button btn_RefreshPorts;
        private System.Windows.Forms.Panel pnl_ConnectPorts;
        private System.Windows.Forms.Panel pnl_Trajectory;
        private System.Windows.Forms.ToolTip toolTip_MainForm;
        private System.Windows.Forms.Button btn_DeletePoint;
        private System.Windows.Forms.Button btn_editPoint;
        private System.Windows.Forms.Button btn_AddPoint;
        private System.Windows.Forms.Label lbl_Experiment;
        private System.Windows.Forms.FlowLayoutPanel flw_ListItems;
        private System.Windows.Forms.Button btn_DeleteAllPoints;
        private System.Windows.Forms.Panel pnl_ExperimentInformation;
        private System.Windows.Forms.Panel pnl_ControlButtons;
        private System.Windows.Forms.Button btn_ReturnToStart;
        private System.Windows.Forms.Button btn_StopMoving;
        private System.Windows.Forms.Button btn_StartMoving;
        private System.Windows.Forms.Label lbl_RecordDate;
        private System.Windows.Forms.TextBox tb_Distance;
        private System.Windows.Forms.Label lbl_Distance;
        private System.Windows.Forms.ListBox lb_ListOfDates;
        private System.Windows.Forms.Label lbl_PointN;
        private System.Windows.Forms.TextBox tb_ExperimentDescription;
        private System.Windows.Forms.TextBox tb_ExperimentTitle;
        private System.Windows.Forms.Label lbl_ExperimentDescription;
        private System.Windows.Forms.Label lbl_ExperimentTitle;
        private System.Windows.Forms.TableLayoutPanel tlp_Workspace;
        private System.Windows.Forms.TabControl tc_Foto;
        private System.Windows.Forms.TabPage tp_Images;
        private System.Windows.Forms.TabPage tb_Cameras;
        private ImageManager im_ExperimentImages;
        private System.Windows.Forms.TextBox tb_Log;
    }
}

