
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabToDoList = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHelpTodo = new System.Windows.Forms.Button();
            this.btnTodoAdd = new System.Windows.Forms.Button();
            this.tbTodoAdd = new System.Windows.Forms.TextBox();
            this.clbTodo = new System.Windows.Forms.CheckedListBox();
            this.tabReminder = new System.Windows.Forms.TabPage();
            this.btnHelpReminder = new System.Windows.Forms.Button();
            this.btnReminderDelete = new System.Windows.Forms.Button();
            this.btnReminderAdd = new System.Windows.Forms.Button();
            this.tbReminder = new System.Windows.Forms.TextBox();
            this.timepickerReminder = new System.Windows.Forms.DateTimePicker();
            this.datepickerReminder = new System.Windows.Forms.DateTimePicker();
            this.clbReminder = new System.Windows.Forms.CheckedListBox();
            this.tabJadwal = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbJadwalRemove = new System.Windows.Forms.ComboBox();
            this.clbHarian = new System.Windows.Forms.CheckedListBox();
            this.btnHelpJadwal = new System.Windows.Forms.Button();
            this.btnJadwalDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstMingguan = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJadwalAdd = new System.Windows.Forms.Button();
            this.tbJadwal = new System.Windows.Forms.TextBox();
            this.timePickerJadwal = new System.Windows.Forms.DateTimePicker();
            this.monthCalendarJadwal = new System.Windows.Forms.MonthCalendar();
            this.tabHabit = new System.Windows.Forms.TabPage();
            this.lblTimeHabit2 = new System.Windows.Forms.Label();
            this.lblTimeHabit = new System.Windows.Forms.Label();
            this.btnHabitDelete = new System.Windows.Forms.Button();
            this.cbHabit = new System.Windows.Forms.ComboBox();
            this.btnHelpHabit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.clbHabit = new System.Windows.Forms.CheckedListBox();
            this.tabIbadah = new System.Windows.Forms.TabPage();
            this.btnHelpIbadah = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIbadahLokasi = new System.Windows.Forms.Button();
            this.cmbLokasi = new System.Windows.Forms.ComboBox();
            this.clbJadwalIbadah = new System.Windows.Forms.CheckedListBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbName = new System.Windows.Forms.TextBox();
            this.remindTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyCSDA = new System.Windows.Forms.NotifyIcon(this.components);
            this.dayTimer = new System.Windows.Forms.Timer(this.components);
            this.jadwalTimer = new System.Windows.Forms.Timer(this.components);
            this.habitTimer = new System.Windows.Forms.Timer(this.components);
            this.tabs.SuspendLayout();
            this.tabToDoList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabReminder.SuspendLayout();
            this.tabJadwal.SuspendLayout();
            this.tabHabit.SuspendLayout();
            this.tabIbadah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabToDoList);
            this.tabs.Controls.Add(this.tabReminder);
            this.tabs.Controls.Add(this.tabJadwal);
            this.tabs.Controls.Add(this.tabHabit);
            this.tabs.Controls.Add(this.tabIbadah);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabs.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(0, 79);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1034, 524);
            this.tabs.TabIndex = 0;
            // 
            // tabToDoList
            // 
            this.tabToDoList.BackColor = System.Drawing.Color.PeachPuff;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSDAReminder.Properties.Resources.yoda_procrastinate_meme;
            this.pictureBox1.Location = new System.Drawing.Point(716, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            // tbTodoAdd
            // 
            this.tbTodoAdd.Location = new System.Drawing.Point(632, 32);
            this.tbTodoAdd.Multiline = true;
            this.tbTodoAdd.Name = "tbTodoAdd";
            this.tbTodoAdd.Size = new System.Drawing.Size(364, 80);
            this.tbTodoAdd.TabIndex = 2;
            this.tbTodoAdd.TextChanged += new System.EventHandler(this.tbTodoAdd_TextChanged);
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
            // tabReminder
            // 
            this.tabReminder.BackColor = System.Drawing.Color.PeachPuff;
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
            // tbReminder
            // 
            this.tbReminder.Location = new System.Drawing.Point(667, 47);
            this.tbReminder.Multiline = true;
            this.tbReminder.Name = "tbReminder";
            this.tbReminder.Size = new System.Drawing.Size(294, 54);
            this.tbReminder.TabIndex = 5;
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
            // datepickerReminder
            // 
            this.datepickerReminder.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepickerReminder.Location = new System.Drawing.Point(667, 116);
            this.datepickerReminder.Name = "datepickerReminder";
            this.datepickerReminder.Size = new System.Drawing.Size(190, 28);
            this.datepickerReminder.TabIndex = 3;
            // 
            // clbReminder
            // 
            this.clbReminder.CheckOnClick = true;
            this.clbReminder.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbReminder.FormattingEnabled = true;
            this.clbReminder.Location = new System.Drawing.Point(22, 20);
            this.clbReminder.Name = "clbReminder";
            this.clbReminder.Size = new System.Drawing.Size(550, 446);
            this.clbReminder.TabIndex = 2;
            this.clbReminder.SelectedIndexChanged += new System.EventHandler(this.clbReminder_SelectedIndexChanged);
            // 
            // tabJadwal
            // 
            this.tabJadwal.BackColor = System.Drawing.Color.PeachPuff;
            this.tabJadwal.Controls.Add(this.textBox1);
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Sienna;
            this.textBox1.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(64, 409);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 70);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Apabila memasukkan jadwal, pilih hari yang sama namun dengan minggu yang berbeda!" +
    "";
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
            // tbJadwal
            // 
            this.tbJadwal.Location = new System.Drawing.Point(38, 296);
            this.tbJadwal.Multiline = true;
            this.tbJadwal.Name = "tbJadwal";
            this.tbJadwal.Size = new System.Drawing.Size(325, 60);
            this.tbJadwal.TabIndex = 2;
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
            // monthCalendarJadwal
            // 
            this.monthCalendarJadwal.Location = new System.Drawing.Point(38, 31);
            this.monthCalendarJadwal.Name = "monthCalendarJadwal";
            this.monthCalendarJadwal.TabIndex = 0;
            // 
            // tabHabit
            // 
            this.tabHabit.BackColor = System.Drawing.Color.Bisque;
            this.tabHabit.Controls.Add(this.lblTimeHabit2);
            this.tabHabit.Controls.Add(this.lblTimeHabit);
            this.tabHabit.Controls.Add(this.btnHabitDelete);
            this.tabHabit.Controls.Add(this.cbHabit);
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
            // lblTimeHabit2
            // 
            this.lblTimeHabit2.AutoSize = true;
            this.lblTimeHabit2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblTimeHabit2.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeHabit2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeHabit2.Location = new System.Drawing.Point(906, 236);
            this.lblTimeHabit2.Name = "lblTimeHabit2";
            this.lblTimeHabit2.Size = new System.Drawing.Size(87, 59);
            this.lblTimeHabit2.TabIndex = 24;
            this.lblTimeHabit2.Text = "22";
            // 
            // lblTimeHabit
            // 
            this.lblTimeHabit.AutoSize = true;
            this.lblTimeHabit.BackColor = System.Drawing.Color.PowderBlue;
            this.lblTimeHabit.Font = new System.Drawing.Font("DS-Digital", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeHabit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeHabit.Location = new System.Drawing.Point(579, 209);
            this.lblTimeHabit.Name = "lblTimeHabit";
            this.lblTimeHabit.Size = new System.Drawing.Size(321, 118);
            this.lblTimeHabit.TabIndex = 23;
            this.lblTimeHabit.Text = "22:22";
            this.lblTimeHabit.Click += new System.EventHandler(this.lblTimeHabit_Click);
            // 
            // btnHabitDelete
            // 
            this.btnHabitDelete.Location = new System.Drawing.Point(583, 96);
            this.btnHabitDelete.Name = "btnHabitDelete";
            this.btnHabitDelete.Size = new System.Drawing.Size(189, 42);
            this.btnHabitDelete.TabIndex = 19;
            this.btnHabitDelete.Text = "Delete";
            this.btnHabitDelete.UseVisualStyleBackColor = true;
            // 
            // cbHabit
            // 
            this.cbHabit.FormattingEnabled = true;
            this.cbHabit.Location = new System.Drawing.Point(583, 46);
            this.cbHabit.Name = "cbHabit";
            this.cbHabit.Size = new System.Drawing.Size(390, 32);
            this.cbHabit.TabIndex = 18;
            this.cbHabit.Text = "Pilih habit";
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
            // clbHabit
            // 
            this.clbHabit.CheckOnClick = true;
            this.clbHabit.FormattingEnabled = true;
            this.clbHabit.IntegralHeight = false;
            this.clbHabit.Items.AddRange(new object[] {
            "Sarapan",
            "Mandi pagi",
            "Makan siang",
            "Mandi sore",
            "Makan sore",
            "Olahraga rutin"});
            this.clbHabit.Location = new System.Drawing.Point(18, 46);
            this.clbHabit.Name = "clbHabit";
            this.clbHabit.Size = new System.Drawing.Size(481, 418);
            this.clbHabit.TabIndex = 0;
            this.clbHabit.SelectedIndexChanged += new System.EventHandler(this.clbHabit_SelectedIndexChanged);
            // 
            // tabIbadah
            // 
            this.tabIbadah.BackColor = System.Drawing.Color.Bisque;
            this.tabIbadah.Controls.Add(this.btnHelpIbadah);
            this.tabIbadah.Controls.Add(this.pictureBox2);
            this.tabIbadah.Controls.Add(this.btnIbadahLokasi);
            this.tabIbadah.Controls.Add(this.cmbLokasi);
            this.tabIbadah.Controls.Add(this.clbJadwalIbadah);
            this.tabIbadah.Location = new System.Drawing.Point(4, 33);
            this.tabIbadah.Name = "tabIbadah";
            this.tabIbadah.Size = new System.Drawing.Size(1026, 487);
            this.tabIbadah.TabIndex = 4;
            this.tabIbadah.Text = "Jadwal Ibadah";
            // 
            // btnHelpIbadah
            // 
            this.btnHelpIbadah.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpIbadah.Location = new System.Drawing.Point(968, 429);
            this.btnHelpIbadah.Name = "btnHelpIbadah";
            this.btnHelpIbadah.Size = new System.Drawing.Size(50, 50);
            this.btnHelpIbadah.TabIndex = 22;
            this.btnHelpIbadah.Text = "?";
            this.btnHelpIbadah.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CSDAReminder.Properties.Resources.sholat_jarang_sedekah_dikit_ngaji_apalagi_terus_maunya_masuk_surga_mang_situ_punya_kenalan_orang_dal;
            this.pictureBox2.Location = new System.Drawing.Point(656, 247);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // btnIbadahLokasi
            // 
            this.btnIbadahLokasi.Location = new System.Drawing.Point(656, 73);
            this.btnIbadahLokasi.Name = "btnIbadahLokasi";
            this.btnIbadahLokasi.Size = new System.Drawing.Size(189, 32);
            this.btnIbadahLokasi.TabIndex = 20;
            this.btnIbadahLokasi.Text = "Set Lokasi";
            this.btnIbadahLokasi.UseVisualStyleBackColor = true;
            // 
            // cmbLokasi
            // 
            this.cmbLokasi.FormattingEnabled = true;
            this.cmbLokasi.Location = new System.Drawing.Point(656, 35);
            this.cmbLokasi.Name = "cmbLokasi";
            this.cmbLokasi.Size = new System.Drawing.Size(280, 32);
            this.cmbLokasi.TabIndex = 1;
            this.cmbLokasi.Text = "Pilih lokasi";
            this.cmbLokasi.SelectedIndexChanged += new System.EventHandler(this.cmbLokasi_SelectedIndexChanged);
            // 
            // clbJadwalIbadah
            // 
            this.clbJadwalIbadah.FormattingEnabled = true;
            this.clbJadwalIbadah.Location = new System.Drawing.Point(19, 16);
            this.clbJadwalIbadah.Name = "clbJadwalIbadah";
            this.clbJadwalIbadah.Size = new System.Drawing.Size(587, 446);
            this.clbJadwalIbadah.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(333, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(47, 37);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelpJadwalIbadah_Click);
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
            this.btnSave.Location = new System.Drawing.Point(208, 12);
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
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.MistyRose;
            this.tbName.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(26, 15);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(167, 31);
            this.tbName.TabIndex = 22;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // remindTimer
            // 
            this.remindTimer.Tick += new System.EventHandler(this.remindTimer_Tick);
            // 
            // notifyCSDA
            // 
            this.notifyCSDA.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyCSDA.BalloonTipText = "TestBalloonTipText";
            this.notifyCSDA.BalloonTipTitle = "Hi Intan!";
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
            // CSDAReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 603);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CSDAReminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSDAReminder";
            this.Load += new System.EventHandler(this.CSDAReminder_Load);
            this.tabs.ResumeLayout(false);
            this.tabToDoList.ResumeLayout(false);
            this.tabToDoList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabReminder.ResumeLayout(false);
            this.tabReminder.PerformLayout();
            this.tabJadwal.ResumeLayout(false);
            this.tabJadwal.PerformLayout();
            this.tabHabit.ResumeLayout(false);
            this.tabHabit.PerformLayout();
            this.tabIbadah.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabToDoList;
        private System.Windows.Forms.TabPage tabReminder;
        private System.Windows.Forms.TabPage tabJadwal;
        private System.Windows.Forms.TabPage tabHabit;
        private System.Windows.Forms.TabPage tabIbadah;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.CheckedListBox clbTodo;
        private System.Windows.Forms.Button btnTodoAdd;
        private System.Windows.Forms.TextBox tbTodoAdd;
        private System.Windows.Forms.Button btnHelpReminder;
        private System.Windows.Forms.Button btnReminderDelete;
        private System.Windows.Forms.Button btnReminderAdd;
        private System.Windows.Forms.TextBox tbReminder;
        private System.Windows.Forms.DateTimePicker timepickerReminder;
        private System.Windows.Forms.DateTimePicker datepickerReminder;
        private System.Windows.Forms.CheckedListBox clbReminder;
        private System.Windows.Forms.Button btnHelpTodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstMingguan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJadwalAdd;
        private System.Windows.Forms.TextBox tbJadwal;
        private System.Windows.Forms.DateTimePicker timePickerJadwal;
        private System.Windows.Forms.MonthCalendar monthCalendarJadwal;
        private System.Windows.Forms.CheckedListBox clbHabit;
        private System.Windows.Forms.Button btnJadwalDelete;
        private System.Windows.Forms.Button btnHelpJadwal;
        private System.Windows.Forms.Button btnHabitDelete;
        private System.Windows.Forms.ComboBox cbHabit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnIbadahLokasi;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ComboBox cmbLokasi;
        private System.Windows.Forms.CheckedListBox clbJadwalIbadah;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Timer remindTimer;
        private System.Windows.Forms.NotifyIcon notifyCSDA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnHelpHabit;
        private System.Windows.Forms.Button btnHelpIbadah;
        private System.Windows.Forms.Timer dayTimer;
        private System.Windows.Forms.Label lblTimeHabit;
        private System.Windows.Forms.Label lblTimeHabit2;
        private System.Windows.Forms.Timer jadwalTimer;
        private System.Windows.Forms.CheckedListBox clbHarian;
        private System.Windows.Forms.ComboBox cmbJadwalRemove;
        private System.Windows.Forms.Timer habitTimer;
        private System.Windows.Forms.TextBox textBox1;
    }
}