
namespace CSDAReminder
{
    partial class CSDAReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSDAReminder));
            this.btnHelp = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.remindTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyCSDA = new System.Windows.Forms.NotifyIcon(this.components);
            this.dayTimer = new System.Windows.Forms.Timer(this.components);
            this.jadwalTimer = new System.Windows.Forms.Timer(this.components);
            this.habitTimer = new System.Windows.Forms.Timer(this.components);
            this.tabHabit = new System.Windows.Forms.TabPage();
            this.clbHabit = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHelpHabit = new System.Windows.Forms.Button();
            this.btnHabitActive = new System.Windows.Forms.Button();
            this.lblTimeHabit = new System.Windows.Forms.Label();
            this.lblTimeHabit2 = new System.Windows.Forms.Label();
            this.tbHabitStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstHabit = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.tabJadwal = new System.Windows.Forms.TabPage();
            this.monthCalendarJadwal = new System.Windows.Forms.MonthCalendar();
            this.timePickerJadwal = new System.Windows.Forms.DateTimePicker();
            this.tbJadwal = new System.Windows.Forms.TextBox();
            this.btnJadwalAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMingguan = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnJadwalDelete = new System.Windows.Forms.Button();
            this.btnHelpJadwal = new System.Windows.Forms.Button();
            this.clbHarian = new System.Windows.Forms.CheckedListBox();
            this.cmbJadwalRemove = new System.Windows.Forms.ComboBox();
            this.tabReminder = new System.Windows.Forms.TabPage();
            this.clbReminder = new System.Windows.Forms.CheckedListBox();
            this.datepickerReminder = new System.Windows.Forms.DateTimePicker();
            this.timepickerReminder = new System.Windows.Forms.DateTimePicker();
            this.tbReminder = new System.Windows.Forms.TextBox();
            this.btnReminderAdd = new System.Windows.Forms.Button();
            this.btnReminderDelete = new System.Windows.Forms.Button();
            this.btnHelpReminder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabToDoList = new System.Windows.Forms.TabPage();
            this.clbTodo = new System.Windows.Forms.CheckedListBox();
            this.tbTodoAdd = new System.Windows.Forms.TextBox();
            this.btnTodoAdd = new System.Windows.Forms.Button();
            this.btnHelpTodo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabHabit.SuspendLayout();
            this.tabJadwal.SuspendLayout();
            this.tabReminder.SuspendLayout();
            this.tabToDoList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Maroon;
            this.btnHelp.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHelp.Location = new System.Drawing.Point(164, 20);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(85, 37);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("DS-Digital", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Location = new System.Drawing.Point(852, 43);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(125, 33);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "22:22:22";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Futura Bk BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(787, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(126, 22);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "June 13 2020";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaShell;
            this.btnSave.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(23, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 37);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save All";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // remindTimer
            // 
            this.remindTimer.Tick += new System.EventHandler(this.remindTimer_Tick);
            // 
            // notifyCSDA
            // 
            this.notifyCSDA.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyCSDA.BalloonTipText = "TestBalloonTipText";
            this.notifyCSDA.BalloonTipTitle = "Hi Student!";
            this.notifyCSDA.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyCSDA.Icon")));
            this.notifyCSDA.Text = "CSDA Reminder";
            this.notifyCSDA.Visible = true;
            this.notifyCSDA.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyCSDA_MouseDoubleClick);
            // 
            // dayTimer
            // 
            this.dayTimer.Interval = 1000;
            this.dayTimer.Tick += new System.EventHandler(this.dayTimer_Tick);
            // 
            // jadwalTimer
            // 
            this.jadwalTimer.Tick += new System.EventHandler(this.jadwalTimer_Tick);
            // 
            // habitTimer
            // 
            this.habitTimer.Tick += new System.EventHandler(this.habitTimer_Tick);
            // 
            // tabHabit
            // 
            this.tabHabit.BackColor = System.Drawing.Color.Bisque;
            this.tabHabit.Controls.Add(this.btnCheckAll);
            this.tabHabit.Controls.Add(this.listBox1);
            this.tabHabit.Controls.Add(this.label5);
            this.tabHabit.Controls.Add(this.lstHabit);
            this.tabHabit.Controls.Add(this.label3);
            this.tabHabit.Controls.Add(this.tbHabitStatus);
            this.tabHabit.Controls.Add(this.lblTimeHabit2);
            this.tabHabit.Controls.Add(this.lblTimeHabit);
            this.tabHabit.Controls.Add(this.btnHabitActive);
            this.tabHabit.Controls.Add(this.btnHelpHabit);
            this.tabHabit.Controls.Add(this.label4);
            this.tabHabit.Controls.Add(this.clbHabit);
            this.tabHabit.Location = new System.Drawing.Point(4, 33);
            this.tabHabit.Name = "tabHabit";
            this.tabHabit.Size = new System.Drawing.Size(1026, 487);
            this.tabHabit.TabIndex = 3;
            this.tabHabit.Text = "Habit";
            this.tabHabit.Click += new System.EventHandler(this.tabHabit_Click);
            // 
            // clbHabit
            // 
            this.clbHabit.CheckOnClick = true;
            this.clbHabit.FormattingEnabled = true;
            this.clbHabit.IntegralHeight = false;
            this.clbHabit.Items.AddRange(new object[] {
            "Sarapan",
            "Mandi pagi",
            "Makan siang",
            "Olahraga rutin",
            "Mandi sore",
            "Makan sore"});
            this.clbHabit.Location = new System.Drawing.Point(18, 46);
            this.clbHabit.Name = "clbHabit";
            this.clbHabit.Size = new System.Drawing.Size(358, 181);
            this.clbHabit.TabIndex = 0;
            this.clbHabit.SelectedIndexChanged += new System.EventHandler(this.clbHabit_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Firebrick;
            this.label4.Font = new System.Drawing.Font("Futura Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(19, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "List Habit";
            // 
            // btnHelpHabit
            // 
            this.btnHelpHabit.Location = new System.Drawing.Point(968, 429);
            this.btnHelpHabit.Name = "btnHelpHabit";
            this.btnHelpHabit.Size = new System.Drawing.Size(50, 50);
            this.btnHelpHabit.TabIndex = 17;
            this.btnHelpHabit.Text = "?";
            this.btnHelpHabit.UseVisualStyleBackColor = true;
            this.btnHelpHabit.Click += new System.EventHandler(this.btnHelpHabit_Click);
            // 
            // btnHabitActive
            // 
            this.btnHabitActive.BackColor = System.Drawing.Color.Yellow;
            this.btnHabitActive.Location = new System.Drawing.Point(387, 88);
            this.btnHabitActive.Name = "btnHabitActive";
            this.btnHabitActive.Size = new System.Drawing.Size(189, 42);
            this.btnHabitActive.TabIndex = 19;
            this.btnHabitActive.Text = "Aktifkan Habit";
            this.btnHabitActive.UseVisualStyleBackColor = false;
            this.btnHabitActive.Click += new System.EventHandler(this.btnHabitActive_Click);
            // 
            // lblTimeHabit
            // 
            this.lblTimeHabit.AutoSize = true;
            this.lblTimeHabit.BackColor = System.Drawing.Color.PowderBlue;
            this.lblTimeHabit.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeHabit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeHabit.Location = new System.Drawing.Point(622, 290);
            this.lblTimeHabit.Name = "lblTimeHabit";
            this.lblTimeHabit.Size = new System.Drawing.Size(216, 79);
            this.lblTimeHabit.TabIndex = 23;
            this.lblTimeHabit.Text = "22:22";
            this.lblTimeHabit.Click += new System.EventHandler(this.lblTimeHabit_Click);
            // 
            // lblTimeHabit2
            // 
            this.lblTimeHabit2.AutoSize = true;
            this.lblTimeHabit2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblTimeHabit2.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeHabit2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeHabit2.Location = new System.Drawing.Point(877, 306);
            this.lblTimeHabit2.Name = "lblTimeHabit2";
            this.lblTimeHabit2.Size = new System.Drawing.Size(87, 59);
            this.lblTimeHabit2.TabIndex = 24;
            this.lblTimeHabit2.Text = "22";
            // 
            // tbHabitStatus
            // 
            this.tbHabitStatus.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHabitStatus.Location = new System.Drawing.Point(626, 429);
            this.tbHabitStatus.Multiline = true;
            this.tbHabitStatus.Name = "tbHabitStatus";
            this.tbHabitStatus.ReadOnly = true;
            this.tbHabitStatus.Size = new System.Drawing.Size(188, 33);
            this.tbHabitStatus.TabIndex = 25;
            this.tbHabitStatus.Text = "Habit Belum Aktif";
            this.tbHabitStatus.TextChanged += new System.EventHandler(this.tbHabitStatus_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Firebrick;
            this.label3.Font = new System.Drawing.Font("Futura Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Habit Yang Harus Dilakukan";
            // 
            // lstHabit
            // 
            this.lstHabit.FormattingEnabled = true;
            this.lstHabit.ItemHeight = 24;
            this.lstHabit.Location = new System.Drawing.Point(18, 290);
            this.lstHabit.Name = "lstHabit";
            this.lstHabit.Size = new System.Drawing.Size(558, 172);
            this.lstHabit.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Firebrick;
            this.label5.Font = new System.Drawing.Font("Futura Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(621, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Waktu Habit";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "Sarapan - 08:00",
            "Mandi pagi - 09:00",
            "Makan siang - 11:30",
            "Olahraga rutin - 15:00",
            "Mandi sore - 17:00",
            "Makan sore - 18:30"});
            this.listBox1.Location = new System.Drawing.Point(620, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(383, 172);
            this.listBox1.TabIndex = 31;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCheckAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckAll.Location = new System.Drawing.Point(387, 136);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(189, 42);
            this.btnCheckAll.TabIndex = 32;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = false;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // tabJadwal
            // 
            this.tabJadwal.BackColor = System.Drawing.Color.Bisque;
            this.tabJadwal.Controls.Add(this.cmbJadwalRemove);
            this.tabJadwal.Controls.Add(this.clbHarian);
            this.tabJadwal.Controls.Add(this.btnHelpJadwal);
            this.tabJadwal.Controls.Add(this.btnJadwalDelete);
            this.tabJadwal.Controls.Add(this.label2);
            this.tabJadwal.Controls.Add(this.lstMingguan);
            this.tabJadwal.Controls.Add(this.label1);
            this.tabJadwal.Controls.Add(this.btnJadwalAdd);
            this.tabJadwal.Controls.Add(this.tbJadwal);
            this.tabJadwal.Controls.Add(this.timePickerJadwal);
            this.tabJadwal.Controls.Add(this.monthCalendarJadwal);
            this.tabJadwal.Location = new System.Drawing.Point(4, 33);
            this.tabJadwal.Name = "tabJadwal";
            this.tabJadwal.Size = new System.Drawing.Size(1026, 487);
            this.tabJadwal.TabIndex = 2;
            this.tabJadwal.Text = "Jadwal";
            this.tabJadwal.Click += new System.EventHandler(this.tabJadwal_Click);
            // 
            // monthCalendarJadwal
            // 
            this.monthCalendarJadwal.Location = new System.Drawing.Point(38, 31);
            this.monthCalendarJadwal.Name = "monthCalendarJadwal";
            this.monthCalendarJadwal.TabIndex = 0;
            // 
            // timePickerJadwal
            // 
            this.timePickerJadwal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerJadwal.Location = new System.Drawing.Point(38, 250);
            this.timePickerJadwal.Name = "timePickerJadwal";
            this.timePickerJadwal.ShowUpDown = true;
            this.timePickerJadwal.Size = new System.Drawing.Size(262, 31);
            this.timePickerJadwal.TabIndex = 1;
            this.timePickerJadwal.ValueChanged += new System.EventHandler(this.timePickerJadwal_ValueChanged);
            // 
            // tbJadwal
            // 
            this.tbJadwal.Location = new System.Drawing.Point(38, 296);
            this.tbJadwal.Multiline = true;
            this.tbJadwal.Name = "tbJadwal";
            this.tbJadwal.Size = new System.Drawing.Size(325, 60);
            this.tbJadwal.TabIndex = 2;
            // 
            // btnJadwalAdd
            // 
            this.btnJadwalAdd.Location = new System.Drawing.Point(379, 296);
            this.btnJadwalAdd.Name = "btnJadwalAdd";
            this.btnJadwalAdd.Size = new System.Drawing.Size(93, 60);
            this.btnJadwalAdd.TabIndex = 7;
            this.btnJadwalAdd.Text = "Add";
            this.btnJadwalAdd.UseVisualStyleBackColor = true;
            this.btnJadwalAdd.Click += new System.EventHandler(this.btnJadwalAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(536, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jadwal Hari Ini";
            // 
            // lstMingguan
            // 
            this.lstMingguan.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMingguan.FormattingEnabled = true;
            this.lstMingguan.ItemHeight = 20;
            this.lstMingguan.Location = new System.Drawing.Point(535, 268);
            this.lstMingguan.Name = "lstMingguan";
            this.lstMingguan.Size = new System.Drawing.Size(465, 204);
            this.lstMingguan.TabIndex = 10;
            this.lstMingguan.SelectedIndexChanged += new System.EventHandler(this.lstMingguan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSalmon;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(536, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Jadwal Minggu Ini";
            // 
            // btnJadwalDelete
            // 
            this.btnJadwalDelete.Location = new System.Drawing.Point(379, 362);
            this.btnJadwalDelete.Name = "btnJadwalDelete";
            this.btnJadwalDelete.Size = new System.Drawing.Size(93, 32);
            this.btnJadwalDelete.TabIndex = 15;
            this.btnJadwalDelete.Text = "Delete";
            this.btnJadwalDelete.UseVisualStyleBackColor = true;
            this.btnJadwalDelete.Click += new System.EventHandler(this.btnJadwalDelete_Click);
            // 
            // btnHelpJadwal
            // 
            this.btnHelpJadwal.Location = new System.Drawing.Point(8, 429);
            this.btnHelpJadwal.Name = "btnHelpJadwal";
            this.btnHelpJadwal.Size = new System.Drawing.Size(50, 50);
            this.btnHelpJadwal.TabIndex = 16;
            this.btnHelpJadwal.Text = "?";
            this.btnHelpJadwal.UseVisualStyleBackColor = true;
            this.btnHelpJadwal.Click += new System.EventHandler(this.btnHelpJadwal_Click);
            // 
            // clbHarian
            // 
            this.clbHarian.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbHarian.FormattingEnabled = true;
            this.clbHarian.Location = new System.Drawing.Point(535, 39);
            this.clbHarian.Name = "clbHarian";
            this.clbHarian.Size = new System.Drawing.Size(464, 188);
            this.clbHarian.TabIndex = 17;
            this.clbHarian.SelectedIndexChanged += new System.EventHandler(this.clbHarian_SelectedIndexChanged);
            // 
            // cmbJadwalRemove
            // 
            this.cmbJadwalRemove.FormattingEnabled = true;
            this.cmbJadwalRemove.Location = new System.Drawing.Point(38, 363);
            this.cmbJadwalRemove.Name = "cmbJadwalRemove";
            this.cmbJadwalRemove.Size = new System.Drawing.Size(325, 32);
            this.cmbJadwalRemove.TabIndex = 18;
            this.cmbJadwalRemove.SelectedIndexChanged += new System.EventHandler(this.cmbJadwalRemove_SelectedIndexChanged);
            // 
            // tabReminder
            // 
            this.tabReminder.BackColor = System.Drawing.Color.Bisque;
            this.tabReminder.Controls.Add(this.label6);
            this.tabReminder.Controls.Add(this.btnHelpReminder);
            this.tabReminder.Controls.Add(this.btnReminderDelete);
            this.tabReminder.Controls.Add(this.btnReminderAdd);
            this.tabReminder.Controls.Add(this.tbReminder);
            this.tabReminder.Controls.Add(this.timepickerReminder);
            this.tabReminder.Controls.Add(this.datepickerReminder);
            this.tabReminder.Controls.Add(this.clbReminder);
            this.tabReminder.Location = new System.Drawing.Point(4, 33);
            this.tabReminder.Name = "tabReminder";
            this.tabReminder.Padding = new System.Windows.Forms.Padding(3);
            this.tabReminder.Size = new System.Drawing.Size(1026, 487);
            this.tabReminder.TabIndex = 1;
            this.tabReminder.Text = "Reminder";
            // 
            // clbReminder
            // 
            this.clbReminder.CheckOnClick = true;
            this.clbReminder.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbReminder.FormattingEnabled = true;
            this.clbReminder.Location = new System.Drawing.Point(22, 72);
            this.clbReminder.Name = "clbReminder";
            this.clbReminder.Size = new System.Drawing.Size(550, 394);
            this.clbReminder.TabIndex = 2;
            this.clbReminder.SelectedIndexChanged += new System.EventHandler(this.clbReminder_SelectedIndexChanged);
            // 
            // datepickerReminder
            // 
            this.datepickerReminder.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepickerReminder.Location = new System.Drawing.Point(667, 116);
            this.datepickerReminder.Name = "datepickerReminder";
            this.datepickerReminder.Size = new System.Drawing.Size(190, 28);
            this.datepickerReminder.TabIndex = 3;
            // 
            // timepickerReminder
            // 
            this.timepickerReminder.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timepickerReminder.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timepickerReminder.Location = new System.Drawing.Point(667, 162);
            this.timepickerReminder.Name = "timepickerReminder";
            this.timepickerReminder.ShowUpDown = true;
            this.timepickerReminder.Size = new System.Drawing.Size(190, 28);
            this.timepickerReminder.TabIndex = 4;
            this.timepickerReminder.ValueChanged += new System.EventHandler(this.timepickerReminder_ValueChanged);
            // 
            // tbReminder
            // 
            this.tbReminder.Location = new System.Drawing.Point(667, 47);
            this.tbReminder.Multiline = true;
            this.tbReminder.Name = "tbReminder";
            this.tbReminder.Size = new System.Drawing.Size(294, 54);
            this.tbReminder.TabIndex = 5;
            // 
            // btnReminderAdd
            // 
            this.btnReminderAdd.Location = new System.Drawing.Point(667, 216);
            this.btnReminderAdd.Name = "btnReminderAdd";
            this.btnReminderAdd.Size = new System.Drawing.Size(294, 35);
            this.btnReminderAdd.TabIndex = 6;
            this.btnReminderAdd.Text = "Add";
            this.btnReminderAdd.UseVisualStyleBackColor = true;
            this.btnReminderAdd.Click += new System.EventHandler(this.btnReminderAdd_Click);
            // 
            // btnReminderDelete
            // 
            this.btnReminderDelete.Location = new System.Drawing.Point(667, 267);
            this.btnReminderDelete.Name = "btnReminderDelete";
            this.btnReminderDelete.Size = new System.Drawing.Size(294, 35);
            this.btnReminderDelete.TabIndex = 7;
            this.btnReminderDelete.Text = "Delete";
            this.btnReminderDelete.UseVisualStyleBackColor = true;
            this.btnReminderDelete.Click += new System.EventHandler(this.btnReminderDelete_Click);
            // 
            // btnHelpReminder
            // 
            this.btnHelpReminder.Location = new System.Drawing.Point(968, 429);
            this.btnHelpReminder.Name = "btnHelpReminder";
            this.btnHelpReminder.Size = new System.Drawing.Size(50, 50);
            this.btnHelpReminder.TabIndex = 8;
            this.btnHelpReminder.Text = "?";
            this.btnHelpReminder.UseVisualStyleBackColor = true;
            this.btnHelpReminder.Click += new System.EventHandler(this.btnHelpReminder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightCoral;
            this.label6.Font = new System.Drawing.Font("Futura Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(26, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "List Reminder";
            // 
            // tabToDoList
            // 
            this.tabToDoList.BackColor = System.Drawing.Color.Bisque;
            this.tabToDoList.Controls.Add(this.pictureBox1);
            this.tabToDoList.Controls.Add(this.btnHelpTodo);
            this.tabToDoList.Controls.Add(this.btnTodoAdd);
            this.tabToDoList.Controls.Add(this.tbTodoAdd);
            this.tabToDoList.Controls.Add(this.clbTodo);
            this.tabToDoList.Location = new System.Drawing.Point(4, 33);
            this.tabToDoList.Name = "tabToDoList";
            this.tabToDoList.Padding = new System.Windows.Forms.Padding(3);
            this.tabToDoList.Size = new System.Drawing.Size(1026, 487);
            this.tabToDoList.TabIndex = 0;
            this.tabToDoList.Text = "To Do List";
            this.tabToDoList.Click += new System.EventHandler(this.tabToDoList_Click);
            // 
            // clbTodo
            // 
            this.clbTodo.CheckOnClick = true;
            this.clbTodo.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTodo.FormattingEnabled = true;
            this.clbTodo.HorizontalExtent = 10;
            this.clbTodo.HorizontalScrollbar = true;
            this.clbTodo.Location = new System.Drawing.Point(22, 18);
            this.clbTodo.Name = "clbTodo";
            this.clbTodo.Size = new System.Drawing.Size(550, 446);
            this.clbTodo.TabIndex = 1;
            this.clbTodo.SelectedIndexChanged += new System.EventHandler(this.clbTodo_SelectedIndexChanged);
            // 
            // tbTodoAdd
            // 
            this.tbTodoAdd.Location = new System.Drawing.Point(632, 32);
            this.tbTodoAdd.Multiline = true;
            this.tbTodoAdd.Name = "tbTodoAdd";
            this.tbTodoAdd.Size = new System.Drawing.Size(364, 80);
            this.tbTodoAdd.TabIndex = 2;
            this.tbTodoAdd.TextChanged += new System.EventHandler(this.tbTodoAdd_TextChanged);
            // 
            // btnTodoAdd
            // 
            this.btnTodoAdd.Location = new System.Drawing.Point(632, 130);
            this.btnTodoAdd.Name = "btnTodoAdd";
            this.btnTodoAdd.Size = new System.Drawing.Size(364, 35);
            this.btnTodoAdd.TabIndex = 3;
            this.btnTodoAdd.Text = "Add To Do List";
            this.btnTodoAdd.UseVisualStyleBackColor = true;
            this.btnTodoAdd.Click += new System.EventHandler(this.btnTodoAdd_Click);
            // 
            // btnHelpTodo
            // 
            this.btnHelpTodo.Location = new System.Drawing.Point(968, 429);
            this.btnHelpTodo.Name = "btnHelpTodo";
            this.btnHelpTodo.Size = new System.Drawing.Size(50, 50);
            this.btnHelpTodo.TabIndex = 4;
            this.btnHelpTodo.Text = "?";
            this.btnHelpTodo.UseVisualStyleBackColor = true;
            this.btnHelpTodo.Click += new System.EventHandler(this.btnHelpTodo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSDAReminder.Properties.Resources.yoda_procrastinate_meme;
            this.pictureBox1.Location = new System.Drawing.Point(697, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabToDoList);
            this.tabs.Controls.Add(this.tabReminder);
            this.tabs.Controls.Add(this.tabJadwal);
            this.tabs.Controls.Add(this.tabHabit);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabs.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(0, 79);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1034, 524);
            this.tabs.TabIndex = 0;
            // 
            // CSDAReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 603);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CSDAReminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSDAReminder";
            this.Load += new System.EventHandler(this.CSDAReminder_Load);
            this.tabHabit.ResumeLayout(false);
            this.tabHabit.PerformLayout();
            this.tabJadwal.ResumeLayout(false);
            this.tabJadwal.PerformLayout();
            this.tabReminder.ResumeLayout(false);
            this.tabReminder.PerformLayout();
            this.tabToDoList.ResumeLayout(false);
            this.tabToDoList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHelp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer remindTimer;
        private System.Windows.Forms.NotifyIcon notifyCSDA;
        private System.Windows.Forms.Timer dayTimer;
        private System.Windows.Forms.Timer jadwalTimer;
        private System.Windows.Forms.Timer habitTimer;
        private System.Windows.Forms.TabPage tabHabit;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstHabit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHabitStatus;
        private System.Windows.Forms.Label lblTimeHabit2;
        private System.Windows.Forms.Label lblTimeHabit;
        private System.Windows.Forms.Button btnHabitActive;
        private System.Windows.Forms.Button btnHelpHabit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clbHabit;
        private System.Windows.Forms.TabPage tabJadwal;
        private System.Windows.Forms.ComboBox cmbJadwalRemove;
        private System.Windows.Forms.CheckedListBox clbHarian;
        private System.Windows.Forms.Button btnHelpJadwal;
        private System.Windows.Forms.Button btnJadwalDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstMingguan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJadwalAdd;
        private System.Windows.Forms.TextBox tbJadwal;
        private System.Windows.Forms.DateTimePicker timePickerJadwal;
        private System.Windows.Forms.MonthCalendar monthCalendarJadwal;
        private System.Windows.Forms.TabPage tabReminder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHelpReminder;
        private System.Windows.Forms.Button btnReminderDelete;
        private System.Windows.Forms.Button btnReminderAdd;
        private System.Windows.Forms.TextBox tbReminder;
        private System.Windows.Forms.DateTimePicker timepickerReminder;
        private System.Windows.Forms.DateTimePicker datepickerReminder;
        private System.Windows.Forms.CheckedListBox clbReminder;
        private System.Windows.Forms.TabPage tabToDoList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHelpTodo;
        private System.Windows.Forms.Button btnTodoAdd;
        private System.Windows.Forms.TextBox tbTodoAdd;
        private System.Windows.Forms.CheckedListBox clbTodo;
        private System.Windows.Forms.TabControl tabs;
    }
}