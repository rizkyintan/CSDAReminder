using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CSDAReminder
{
    public partial class CSDAReminder : Form
    {

        public CSDAReminder()
        {
            InitializeComponent();
            tbTodoAdd.KeyDown += tbTodoAdd_OnKeyDown;
            tbReminder.KeyDown += tbReminder_OnKeyDown;
            //calculate the time until first day is over 
            Int32 timeInterval = 86400000 - ((DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second) * 1000);
            if (timeInterval < 0)
            {
                throw new Exception("Time interval invalid");
            }
            dayTimer.Interval = timeInterval;
            LoadLastSession();
        }

        // kode untuk menjalankan timer
        private void CSDAReminder_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        // kode untuk menampilkan waktu dan tanggal real time pada UI
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lblTimeHabit.Text = DateTime.Now.ToString("HH:mm");
            lblTimeHabit2.Text = DateTime.Now.ToString("ss");
        }

        // Kode untuk menambahkan todo list dengan tombol enter
        private void tbTodoAdd_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTodoAdd_Click(sender, e);
            }
        }

        // Kode untuk menambahkan reminder dengan tombol enter
        private void tbReminder_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnReminderAdd_Click(sender, e);
            }
        }     

        //====================================================================================================//
        // KODE UNTUK FITUR TO DO LIST
        //====================================================================================================//

        private void btnTodoAdd_Click(object sender, EventArgs e)
        {
            if (tbTodoAdd.Text == "")
            {
                MessageBox.Show("Mohon isi kolom to do list!", "Warning");
                return;
            }
            else
            {
                clbTodo.Items.Add(new Todo(tbTodoAdd.Text));
                tbTodoAdd.Text = ""; 
            }   
        }
        
        /// <summary>
        /// Menghapus list todo pada box yang tercentang
        /// </summary>
        private void clbTodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbTodo.Items.Remove(clbTodo.SelectedItem);
        }


        //====================================================================================================//
        // KODE UNTUK FITUR REMINDER
        //====================================================================================================//

        /// <summary>
        /// Menambahkan reminder baru ketika button Add di tekan
        /// </summary>
        private void btnReminderAdd_Click(object sender, EventArgs e)
        {
            if (tbReminder.Text == "")
            {
                MessageBox.Show("Tolong tulis deksripsi reminder!", "Warning");
                return;
            }
            DateTime reminderDate = new DateTime( datepickerReminder.Value.Year,
                datepickerReminder.Value.Month, datepickerReminder.Value.Day,
                timepickerReminder.Value.Hour, timepickerReminder.Value.Minute,
                timepickerReminder.Value.Second);
            Reminder r = new Reminder(tbReminder.Text, reminderDate);
            clbReminder.Items.Add(r);
            tbReminder.Text = "";

            // Set waktu dan start timer jika reminder pertama ditambahkan 
            if (clbReminder.Items.Count <= 1)
            {
                updateReminderTimer(r);
                remindTimer.Start();
            }
            // Apabila reminder berikutnya lebih awal maka waktu diupdate 
            else if (isEarliestReminder(r))
            {
                updateReminderTimer(r);
            }
        }

        /// <summary>
        /// Mengupdate waktu reminder dan set properti untuk notifikasi
        /// </summary>
        private void updateReminderTimer(Reminder r)
        {
            notifyCSDA.BalloonTipText = "Reminder: " + r.message;
            Int32 tempInterval = getWaktu(r.remindDate);

            // ketika interval adalah 0 maka reminder segera dimunculkan
            if (tempInterval <= 0)
            {
                showReminder();
            }
            // update interval timer
            else
            {
                remindTimer.Interval = tempInterval;
            }
        }

        /// <summary>
        /// Memunculkan reminder, menghapusnya, dan mengupdate timer
        /// </summary>
        private void showReminder()
        {
            // apabila tidak ada reminder maka return
            if (clbReminder.Items.Count <= 0)
            {
                return;
            }
            notifyCSDA.ShowBalloonTip(30000);

            // removeReminder menghentikan timer bila sudah tidak ada lagi reminder
            // sehingga kita tidak perlu update manual 
            removeReminder(findEarliestReminder());
            Reminder r = findEarliestReminder();
            if (r != null)
            {
                updateReminderTimer(findEarliestReminder());
            }
        }

        /// <summary>
        /// Menghapus reminder dan mengupdate timernya jika dibutuhkan
        /// </summary>
        private void removeReminder(Reminder r)
        {
            // Mencek apakah reminder ini adalah yg paling awal, kemudian mengupdate waktunya 
            bool update = false;
            if (isEarliestReminder(r))
            {
                update = true;
            }

            clbReminder.Items.Remove(r);
            // Jika sudah tidak ada reminder hentikan timernya
            if (clbReminder.Items.Count <= 0)
            {
                remindTimer.Stop();
            }
            else if (update)
            {
                updateReminderTimer(findEarliestReminder());
            }
        }

        /// <summary>
        /// Mengembalikan nilai true apabila parameter reminder adalah reminder ter-awal
        /// </summary>
        private bool isEarliestReminder(Reminder inRemind)
        {
            return inRemind.Equals(findEarliestReminder());
        }

        /// <summary>
        /// Return reminder yang paling awal di list
        /// Return null apabila list kosong
        /// </summary>
        private Reminder findEarliestReminder()
        {
            if (clbReminder.Items.Count <= 0)
            {
                return null;
            }
            Reminder returnReminder = (Reminder)clbReminder.Items[0];
            foreach (Reminder r in clbReminder.Items)
            {
                if (r.remindDate.Ticks <= returnReminder.remindDate.Ticks)
                    returnReminder = r;
            }
            return returnReminder;
        }

        /// <summary>
        /// Menghapus semua reminder yang di check
        /// </summary>
        private void btnReminderDelete_Click(object sender, EventArgs e)
        {
            while (clbReminder.CheckedItems.Count > 0)
            {
                // hanya menghapus item pertama dan list lain akan mengikuti
                clbReminder.Items.Remove(clbReminder.CheckedItems[0]);
            }
        }

        //====================================================================================================//
        // KODE UNTUK FITUR JADWAL
        // Mekanismenya sama dengan reminder hanya saja pada jadwal dibuat sama perminggu nya
        //====================================================================================================//

        /// <summary>
        /// Menambahkan jadwal baru
        /// </summary>
        private void btnJadwalAdd_Click(object sender, EventArgs e)
        {
            if (tbJadwal.Text == "")
            {
                MessageBox.Show("Mohon isi kolom deskripsi jadwal!", "Warning");
                return;
            }

            DateTime tanggalJadwal = new DateTime(monthCalendarJadwal.SelectionEnd.Year,
                monthCalendarJadwal.SelectionEnd.Month, monthCalendarJadwal.SelectionEnd.Day,
                timePickerJadwal.Value.Hour, timePickerJadwal.Value.Minute,
                timePickerJadwal.Value.Second);

            Jadwal j = new Jadwal(tbJadwal.Text, tanggalJadwal);
            tbJadwal.Text = "";
            cmbJadwalRemove.Items.Add(j);
            
            if(DatesAreInTheSameWeek(tanggalJadwal, DateTime.Now))
            {
                lstMingguan.Items.Add(j);
            }            

            if(tanggalJadwal.Day == DateTime.Now.Day)
            {
                clbHarian.Items.Add(j);
            }

            // Set waktu dan start timer jika reminder pertama ditambahkan
            if (lstMingguan.Items.Count <= 1)
            {
                updateJadwalTimer(j);
                jadwalTimer.Start();
            }

            // Apabila jadwal berikutnya lebih awal maka waktu diupdate 
            else if (isEarliestJadwal(j))
            {
                updateJadwalTimer(j);
            }
        }

        private void updateJadwalTimer(Jadwal j)
        {
            notifyCSDA.BalloonTipText = "Jadwal: " + j.deskripsi;
            Int32 tempInterval = getWaktu(j.tanggalJadwal);
            if (tempInterval <= 0)
            {
                showJadwal();
            }
            else
            {
                jadwalTimer.Interval = tempInterval;
            }
        }

        private void showJadwal()
        {
            if (lstMingguan.Items.Count <= 0)
            {
                return;
            }
            notifyCSDA.ShowBalloonTip(30000);

            removeJadwal(findEarliestJadwal());
            Jadwal j = findEarliestJadwal();
            if (j != null)
            {
                updateJadwalTimer(findEarliestJadwal());
            }
        }

        private void removeJadwal(Jadwal j)
        {
            bool update = false;
            if (isEarliestJadwal(j))
            {
                update = true;
            }

            lstMingguan.Items.Remove(j);
            if (lstMingguan.Items.Count <= 0)
            {
                jadwalTimer.Stop();
            }
            else if (update)
            {
                updateJadwalTimer(findEarliestJadwal());
            }
        }

        private Jadwal findEarliestJadwal()
        {
            if (lstMingguan.Items.Count <= 0)
            {
                return null;
            }
            Jadwal returnJadwal = (Jadwal)lstMingguan.Items[0];
            foreach (Jadwal j in lstMingguan.Items)
            {
                if (j.tanggalJadwal.Ticks <= returnJadwal.tanggalJadwal.Ticks)
                    returnJadwal = j;
            }
            return returnJadwal;
        }

        private bool isEarliestJadwal(Jadwal inJadwal)
        {
            return inJadwal.Equals(findEarliestJadwal());
        }

        /// <summary>
        /// Untuk mengecek apakah dua jadwal berada dalam minggu yang sama
        /// </summary>
        private bool DatesAreInTheSameWeek(DateTime date1, DateTime date2)
        {
            var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
            var d1 = date1.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date1));
            var d2 = date2.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date2));

            return d1 == d2;
        }

        /// <summary>
        /// Menghapus jadwal
        /// </summary>
        private void btnJadwalDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstMingguan.Items.Count; i++)
            {
                if (lstMingguan.Items[i].ToString() == cmbJadwalRemove.Text)
                {
                    lstMingguan.Items.Remove(lstMingguan.Items[i]);
                    //clbHarian.Items.Remove(clbHarian.Items[i]);   
                }
            }
            cmbJadwalRemove.Items.Remove(cmbJadwalRemove.SelectedItem);
            cmbJadwalRemove.Text = "";
        }

        /// <summary>
        /// Menghapus jadwal pada box 'Jadwal Hari Ini' dengan dicentang
        /// </summary>
        private void clbHarian_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbHarian.Items.Remove(clbHarian.SelectedItem);
        }

        //====================================================================================================//
        // KODE UNTUK FITUR HABIT
        // Mekanismenya sama dengan reminder hanya saja pada habit waktu sudah ditentukan oleh program
        //====================================================================================================//

        private void btnHabitActive_Click(object sender, EventArgs e)
        {
            if (clbHabit.CheckedItems.Count == 0)
            {
                MessageBox.Show("Centang salah satu habit pada box!", "Warning");
            }
            else
            {
                lstHabit.Items.Clear();
                tbHabitStatus.Text = "Habit Aktif";

                DateTime time = DateTime.Now;
                DateTime time1 = new DateTime(time.Year, time.Month, time.Day, 8, 0, 0);
                DateTime time2 = new DateTime(time.Year, time.Month, time.Day, 9, 0, 0);
                DateTime time3 = new DateTime(time.Year, time.Month, time.Day, 11, 30, 0);
                DateTime time4 = new DateTime(time.Year, time.Month, time.Day, 15, 0, 0);
                DateTime time5 = new DateTime(time.Year, time.Month, time.Day, 17, 0, 0);
                DateTime time6 = new DateTime(time.Year, time.Month, time.Day, 18, 30, 0);

                for (int i = 0; i < clbHabit.Items.Count; i++)
                {
                    if (clbHabit.GetItemCheckState(i) == CheckState.Checked)
                    {
                        if (clbHabit.Items[i].ToString() == "Sarapan" && (DateTime.Compare(time, time1) < 0))
                        {
                            Habit h = new Habit(clbHabit.Items[i].ToString(), time1);
                            createHabit(h);
                        }
                        else if (clbHabit.Items[i].ToString() == "Mandi pagi" && (DateTime.Compare(time, time2) < 0))
                        {
                            Habit h = new Habit(clbHabit.Items[i].ToString(), time2);
                            createHabit(h);
                        }
                        else if (clbHabit.Items[i].ToString() == "Makan siang" && (DateTime.Compare(time, time3) < 0))
                        {
                            Habit h = new Habit(clbHabit.Items[i].ToString(), time3);
                            createHabit(h);
                        }
                        else if (clbHabit.Items[i].ToString() == "Olahraga rutin" && (DateTime.Compare(time, time4) < 0))
                        {
                            Habit h = new Habit(clbHabit.Items[i].ToString(), time4);
                            createHabit(h);
                        }
                        else if (clbHabit.Items[i].ToString() == "Mandi sore" && (DateTime.Compare(time, time5) < 0))
                        {
                            Habit h = new Habit(clbHabit.Items[i].ToString(), time5);
                            createHabit(h);
                        }
                        else if (clbHabit.Items[i].ToString() == "Makan sore" && (DateTime.Compare(time, time6) < 0))
                        {
                            Habit h = new Habit(clbHabit.Items[i].ToString(), time6);
                            createHabit(h);
                        }
                    }
                }
                foreach (int i in clbHabit.CheckedIndices)
                {
                    clbHabit.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void createHabit(Habit h)
        {
            lstHabit.Items.Add(h);
            if (lstHabit.Items.Count <= 1)
            {
                updateHabitTimer(h);
                habitTimer.Start();
            }
            else if (isEarliestHabit(h))
            {
                updateHabitTimer(h);
            }
        }
  
        private void updateHabitTimer(Habit h)
        {
            notifyCSDA.BalloonTipText = "Ambis boleh tapi jangan lupa : " + h.name;
            Int32 tempInterval = getWaktu(h.habitTime);
            if (tempInterval <= 0)
            {
                showHabit();
            }
            else
            {
                habitTimer.Interval = tempInterval;
            }
        }

        private void showHabit()
        {
            if (lstHabit.Items.Count <= 0)
            {
                return;
            }
            notifyCSDA.ShowBalloonTip(30000);

            removeHabit(findEarliestHabit());
            Habit h = findEarliestHabit();
            if (h != null)
            {
                updateHabitTimer(findEarliestHabit());
            }
        }

        private void removeHabit(Habit h)
        {
            bool update = false;
            if (isEarliestHabit(h))
            {
                update = true;
            }

            lstHabit.Items.Remove(h);
            if (lstHabit.Items.Count <= 0)
            {
                habitTimer.Stop();
            }
            else if (update)
            {
                updateHabitTimer(findEarliestHabit());
            }
        }

        private Habit findEarliestHabit()
        {
            if (lstHabit.Items.Count <= 0)
            {
                return null;
            }
            Habit returnHabit = (Habit)lstHabit.Items[0];
            foreach (Habit h in lstHabit.Items)
            {
                if (h.habitTime.Ticks <= returnHabit.habitTime.Ticks)
                    returnHabit = h;
            }
            return returnHabit;
        }

        private bool isEarliestHabit(Habit inHabit)
        {
            return inHabit.Equals(findEarliestHabit());
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbHabit.Items.Count; i++)
            {
                clbHabit.SetItemChecked(i, true);
            }
        }

        //====================================================================================================//
        // KODE UNTUK MENAMPILKAN FITUR APABILA SUDAH WAKTUNYA
        //====================================================================================================//

        private void remindTimer_Tick(object sender, EventArgs e)
        {
            showReminder();
        }
        private void jadwalTimer_Tick(object sender, EventArgs e)
        {
            showJadwal();
        }
        private void habitTimer_Tick(object sender, EventArgs e)
        {
            showHabit();
        }

        /// <summary>
        /// Mengubah waktu yg ditentukan ke timer untuk menghitung interval waktu dari waktu sekarang ke waktu tertentu
        /// </summary>
        private Int32 getWaktu(DateTime futureEvent)
        {
            //There are 10000 ticks in a millisecond
            return (Int32)futureEvent.Subtract(DateTime.Now).Ticks / 10000;
        }


        //====================================================================================================//
        // KODE UNTUK MENAMPILKAN FITUR HELP
        //====================================================================================================//

        private void btnHelpTodo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tuliskan To Do List yang harus dilakukan kemudian tekan tombol 'Add To Do List'." + "\n" +
                            "Ketika list sudah dilakukan centang pada box kemudian list akan menghilang.", "Help");
        }
        private void btnHelpReminder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tuliskan deskripsi reminder dan pilih tanggal dan waktu nya kemudian tekan tombol 'Add'." + "\n" +
                            "Reminder akan muncul pada box di sebelah kiri, ketika notifikasi muncul reminder akan hilang dengan sendirinya." + "\n" +
                            "Centang reminder pada box kemudian tekan delete untuk menghapus reminder.", "Help");
        }
        private void btnHelpJadwal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tuliskan deskripsi jadwal dan pilih tanggal dan waktu nya kemudian tekan tombol 'Add'." + "\n" +
                           "Jadwal akan muncul pada box 'Jadwal Minggu Ini', ketika notifikasi muncul jadwal akan hilang dengan sendirinya." + "\n" +
                           "Box 'Jadwal Hari Ini' menunjukkan jadwal yang terdapat pada hari pada hari itu. Centang jadwal untuk menghapus jadwal yang sudah dilakukan." + "\n" +
                           "Pilih jadwal pada kolom 'Delete' dan tekan delete untuk menghapus jadwal.", "Help");

        }
        private void btnHelpHabit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Centang box pada 'List Habit' untuk memilih habit yang akan diaktifkan, kemudian tekan tombol 'Aktifkan Habit'. \n" +
                "Box 'Habit Yang Harus Dilakukan' berisikan habit yang akan datang. \n" +
                "Habit akan muncul pada waktu yang sudah ditentukan oleh program.", "Help");
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selamat datang di aplikasi CSDA Reminder! \nBantuan terkait fitur dapat " +
                "dilihat di tombol '?' pada setiap tab fitur. \nApabila aplikasi tidak berjalan dengan baik" +
                " silahkan tutup aplikasi dan jalankan kembali. \nSemoga bermanfaat!", "Help");
        }

        //====================================================================================================//
        // KODE UNTUK FITUR SAVE YANG MENYIMPAN PADA DATABASE
        //====================================================================================================//

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                MessageBox.Show("Data tersimpan!\nKetika aplikasi dibuka Application will load saved settings upon next startup.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while saving. Error: " + ex.ToString());
            }
        }

        private void Save()
        {
            
            FileStream todoFS = new FileStream("todo.dat", FileMode.Create);
            FileStream reminderFS = new FileStream("reminder.dat", FileMode.Create);
            FileStream jadwalFS = new FileStream("jadwal.dat", FileMode.Create);
            FileStream habitFS = new FileStream("habit.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            
            Todo[] todo = new Todo[clbTodo.Items.Count];
            clbTodo.Items.CopyTo(todo, 0);
            Reminder[] reminder = new Reminder[clbReminder.Items.Count];
            clbReminder.Items.CopyTo(reminder, 0);
            Jadwal[] jadwal = new Jadwal[lstMingguan.Items.Count];
            lstMingguan.Items.CopyTo(jadwal, 0);
            Habit[] habit = new Habit[lstHabit.Items.Count];
            lstHabit.Items.CopyTo(habit, 0);
            
            try
            {   
                formatter.Serialize(todoFS, todo);
                formatter.Serialize(reminderFS, reminder);
                formatter.Serialize(jadwalFS, jadwal);
                formatter.Serialize(habitFS, habit);
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to serialize: Reason: " + e.Message);
                throw;
            }
            finally
            {
                habitFS.Close();
                todoFS.Close();
                reminderFS.Close();
                jadwalFS.Close();
            }
        }

        private void LoadLastSession()
        {
            
            Todo[] todo = null;
            Reminder[] reminder = null;
            Jadwal[] jadwal = null;
            Habit[] habit = null;

            FileStream habitFS;
            FileStream todoFS;
            FileStream reminderFS;
            FileStream jadwalFS;
            if (File.Exists("habit.dat") &&
                File.Exists("todo.dat") &&
                File.Exists("reminder.dat") &&
                File.Exists("jadwal.dat"))
            {
                habitFS = new FileStream("habit.dat", FileMode.Open);
                todoFS = new FileStream("todo.dat", FileMode.Open);
                reminderFS = new FileStream("reminder.dat", FileMode.Open);
                jadwalFS = new FileStream("jadwal.dat", FileMode.Open);
            }
            else
            {
                return; //No previous session found
            }

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                habit = (Habit[])formatter.Deserialize(habitFS);
                todo = (Todo[])formatter.Deserialize(todoFS);
                reminder = (Reminder[])formatter.Deserialize(reminderFS);
                jadwal = (Jadwal[])formatter.Deserialize(jadwalFS);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                return;
            }
            finally
            {
                habitFS.Close();
                todoFS.Close();
                reminderFS.Close();
                jadwalFS.Close();
            }

            //add all the objects to their respective lists
            lstHabit.Items.AddRange(habit);
            clbTodo.Items.AddRange(todo);
            clbReminder.Items.AddRange(reminder);
            lstMingguan.Items.AddRange(jadwal);

        }

        private void clbHabit_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tabHabit_Click(object sender, EventArgs e)
        {

        }
        private void clbReminder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabJadwal_Click(object sender, EventArgs e)
        {

        }

        private void cmbLokasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabToDoList_Click(object sender, EventArgs e)
        {

        }

        private void timepickerReminder_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTimeHabit_Click(object sender, EventArgs e)
        {

        }

        private void timePickerJadwal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstMingguan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbJadwalRemove_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void dayTimer_Tick(object sender, EventArgs e)
        {

        }

        private void notifyCSDA_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void tbHabitStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTodoAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnHelpIbadah_Click(object sender, EventArgs e)
        {

        }
    }
}
