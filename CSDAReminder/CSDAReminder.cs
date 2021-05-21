﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDAReminder
{
    public partial class CSDAReminder : Form
    {
        TodoTable todoTable;

        public CSDAReminder()
        {
            InitializeComponent();
            tbTodoAdd.KeyDown += tbTodoAdd_OnKeyDown; //attaches event
            tbReminder.KeyDown += tbReminder_OnKeyDown;
            //calculate the time until first day is over 
            Int32 timeInterval = 86400000 - ((DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second) * 1000);
            if (timeInterval < 0)
            {
                throw new Exception("Time interval invalid");
            }
            dayTimer.Interval = timeInterval;
        }

        private void tbTodoAdd_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTodoAdd_Click(sender, e);
            }
        }

        private void tbReminder_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnReminderAdd_Click(sender, e);
            }
        }

        // kode dibawah untuk menampilkan realtime jam dan tanggal
        private void CSDAReminder_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lblTimeHabit.Text = DateTime.Now.ToString("HH:mm");
            lblTimeHabit2.Text = DateTime.Now.ToString("ss");
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Menghapus list todo pada box yang tercentang
        /// </summary>
        private void clbTodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbTodo.Items.Remove(clbTodo.SelectedItem);
        }

        private void btnTodoAdd_Click(object sender, EventArgs e)
        {
            if (tbTodoAdd.Text == "")
            {
                MessageBox.Show("Mohon isi kolom to do list!", "Warning");
                return;
            }
            else
            {
                //using(var db = new CSDA_Model())
                //{
                //    TodoTable newTodoTable = new TodoTable
                //    {
                //        Desc = tbTodoAdd.Text,
                //    };
                //    db.TodoTables.Add(newTodoTable);
                //    db.SaveChanges();
                //};
                clbTodo.Items.Add(new Todo(tbTodoAdd.Text));
                tbTodoAdd.Text = ""; 
                //mengosongkan tbTodoAdd setelah diisi
            }
            
        }

        private void tbTodoAdd_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Menambahkan reminder baru ketika button Add di tekan
        /// </summary>
        private void btnReminderAdd_Click(object sender, EventArgs e)
        {
            if (tbReminder.Text == "")
            {
                MessageBox.Show("Tolong tulis deksripsi reminder.");
                return;
            }
            DateTime reminderDate = new DateTime( datepickerReminder.Value.Year,
                datepickerReminder.Value.Month, datepickerReminder.Value.Day,
                timepickerReminder.Value.Hour, timepickerReminder.Value.Minute,
                timepickerReminder.Value.Second);
            Reminder r = new Reminder(tbReminder.Text, reminderDate);
            clbReminder.Items.Add(r);
            tbReminder.Text = "";

            //Men-Set waktu jika reminder ditambahkan 
            if (clbReminder.Items.Count <= 1)
            {
                updateReminderTimer(r);
                remindTimer.Start();
            }
            //else mengecek apakah set waktu lebih awal dari waktu sekarang
            else if (isEarliestReminder(r))
            {
                updateReminderTimer(r);
            }
        }

        /// <summary>
        /// Mengubah waktu yg ditentukan ke timer untuk menghitung interval waktu dari waktu sekarang ke waktu reminder
        /// </summary>
        private Int32 getWaktu(DateTime futureEvent)
        {
            //There are 10000 ticks in a millisecond
            return (Int32)futureEvent.Subtract(DateTime.Now).Ticks / 10000;
        }

        /// <summary>
        /// Menghapus semua reminder yang di check
        /// </summary>
        private void btnReminderDelete_Click(object sender, EventArgs e)
        {
            while (clbReminder.CheckedItems.Count > 0)
            {
                //since the items are removed from the checked items list
                //we only need to remove the first item and let the list be continually updated
                clbReminder.Items.Remove(clbReminder.CheckedItems[0]);
            }
        }

        /// <summary>
        /// Removes a reminder and updates the timer if necessary
        /// </summary>
        private void removeReminder(Reminder r)
        {
            //Check if this is the most recent reminder, then update the timer 
            bool update = false;
            if (isEarliestReminder(r))
            {
                update = true;
            }

            clbReminder.Items.Remove(r);
            //If no reminders remain, stop the timer
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
        /// Returns the reminder with the earliest remind date in the reminder list.
        /// Returns null if list is empty 
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
        /// Returns true if the reminder parameter is the earliest reminder
        /// </summary>
        private bool isEarliestReminder(Reminder inRemind)
        {
            return inRemind.Equals(findEarliestReminder());
        }

        /// <summary>
        /// Updates reminder timer and sets the notify icon component properties
        /// </summary>
        private void updateReminderTimer(Reminder r)
        {
            notifyCSDA.BalloonTipText = "Reminder: " + r.message;
            Int32 tempInterval = getWaktu(r.remindDate);
            //0 is an invalid interval, so just show the reminder immediately
            if (tempInterval <= 0)
            {
                showReminder();
            }
            //Else update the timer interval
            else
            {
                remindTimer.Interval = tempInterval;
            }
        }

        //This method will show the reminder when it is time 
        private void remindTimer_Tick(object sender, EventArgs e)
        {
            showReminder();
        }

        /// <summary>
        /// Shows the reminder message, deletes the reminder, and updates the timer
        /// </summary>
        private void showReminder()
        {
            //if there are no reminders, return
            if (clbReminder.Items.Count <= 0)
            {
                return;
            }
            notifyCSDA.ShowBalloonTip(30000);

            //removeReminder stops the timer when there are no more reminders, so we don't have to update it 
            removeReminder(findEarliestReminder());
            Reminder r = findEarliestReminder();
            if (r != null)
            {
                updateReminderTimer(findEarliestReminder());
            }
        }

        /// <summary>
        /// Adds a new event to the schedule
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
            cmbJadwalRemove.Items.Add(j);
            lstMingguan.Items.Add(j);
            tbJadwal.Text = "";

            if(tanggalJadwal.Day == DateTime.Now.Day)
            {
                clbHarian.Items.Add(j);
            }

            //Men-Set waktu jika jadwal ditambahkan 
            if (lstMingguan.Items.Count <= 1)
            {
                updateJadwalTimer(j);
                jadwalTimer.Start();
            }

            //else mengecek apakah set waktu lebih awal dari waktu sekarang
            else if (isEarliestJadwal(j))
            {
                updateJadwalTimer(j);
            }
        }

        private void clbHarian_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbHarian.Items.Remove(clbHarian.SelectedItem);
        }

        private void btnJadwalDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstMingguan.Items.Count; i++)
            {
                if (lstMingguan.Items[i].ToString() == cmbJadwalRemove.Text)
                {
                    lstMingguan.Items.Remove(lstMingguan.Items[i]);
                    clbHarian.Items.Remove(clbHarian.Items[i]);   
                }
            }
            cmbJadwalRemove.Items.Remove(cmbJadwalRemove.SelectedItem);
            cmbJadwalRemove.Text = "";
        }

        /// <summary>
        /// Returns the reminder with the earliest remind date in the reminder list.
        /// Returns null if list is empty 
        /// </summary>
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

        /// <summary>
        /// Returns true if the reminder parameter is the earliest reminder
        /// </summary>
        private bool isEarliestJadwal(Jadwal inJadwal)
        {
            return inJadwal.Equals(findEarliestJadwal());
        }

        /// <summary>
        /// Updates reminder timer and sets the notify icon component properties
        /// </summary>
        private void updateJadwalTimer(Jadwal j)
        {
            notifyCSDA.BalloonTipText = "Jadwal: " + j.deskripsi;
            Int32 tempInterval = getWaktu(j.tanggalJadwal);
            //0 is an invalid interval, so just show the reminder immediately
            if (tempInterval <= 0)
            {
                showJadwal();
            }
            //Else update the timer interval
            else
            {
                jadwalTimer.Interval = tempInterval;
            }
        }
        
        /// <summary>
        /// Shows the reminder message, deletes the reminder, and updates the timer
        /// </summary>
        private void showJadwal()
        {
            //if there are no reminders, return
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
            //Check if this is the most recent reminder, then update the timer 
            bool update = false;
            if (isEarliestJadwal(j))
            {
                update = true;
            }

            lstMingguan.Items.Remove(j);
            //If no reminders remain, stop the timer
            if (lstMingguan.Items.Count <= 0)
            {
                jadwalTimer.Stop();
            }
            else if (update)
            {
                updateJadwalTimer(findEarliestJadwal());
            }
        }

        //This method will show the reminder when it is time 
        private void jadwalTimer_Tick(object sender, EventArgs e)
        {
            showJadwal();
        }

        private void btnHabitActive_Click(object sender, EventArgs e)
        {
            lstHabit.Items.Clear();
            tbHabitStatus.Text = "Habit Aktif";

            DateTime time = DateTime.Now;
            DateTime time1 = new DateTime(time.Year, time.Month, time.Day, 8, 0, 0);
            DateTime time2 = new DateTime(time.Year, time.Month, time.Day, 9, 0, 0);
            DateTime time3 = new DateTime(time.Year, time.Month, time.Day, 11, 30, 0);
            DateTime time4 = new DateTime(time.Year, time.Month, time.Day, 15, 0, 0);
            DateTime time5 = new DateTime(time.Year, time.Month, time.Day, 17, 50, 0);
            DateTime time6 = new DateTime(time.Year, time.Month, time.Day, 18, 30, 0);
            //DateTime time2 = DateTime.ParseExact("09:00:00", "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            
            for (int i = 0; i < clbHabit.Items.Count; i++)
            { 
                if (clbHabit.GetItemCheckState(i) == CheckState.Checked)
                {
                    if(clbHabit.Items[i].ToString() == "Sarapan" && (DateTime.Compare(time, time1) < 0 ))
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
            
        /// <summary>
        /// Updates reminder timer and sets the notify icon component properties
        /// </summary>
        private void updateHabitTimer(Habit h)
        {
            notifyCSDA.BalloonTipText = "Ambis boleh tapi jangan lupa : " + h.name;
            Int32 tempInterval = getWaktu(h.habitTime);
            //0 is an invalid interval, so just show the reminder immediately
            if (tempInterval <= 0)
            {
                showHabit();
            }
            //Else update the timer interval
            else
            {
                habitTimer.Interval = tempInterval;
            }
        }

        /// <summary>
        /// Shows the reminder message, deletes the reminder, and updates the timer
        /// </summary>
        private void showHabit()
        {
            //if there are no reminders, return
            if (lstHabit.Items.Count <= 0)
            {
                return;
            }
            notifyCSDA.ShowBalloonTip(30000);

            //removeReminder stops the timer when there are no more reminders, so we don't have to update it 
            removeHabit(findEarliestHabit());
            Habit h = findEarliestHabit();
            if (h != null)
            {
                updateHabitTimer(findEarliestHabit());
            }
        }

        /// <summary>
        /// Removes a reminder and updates the timer if necessary
        /// </summary>
        private void removeHabit(Habit h)
        {
            //Check if this is the most recent reminder, then update the timer 
            bool update = false;
            if (isEarliestHabit(h))
            {
                update = true;
            }

            lstHabit.Items.Remove(h);
            //If no reminders remain, stop the timer
            if (lstHabit.Items.Count <= 0)
            {
                habitTimer.Stop();
            }
            else if (update)
            {
                updateHabitTimer(findEarliestHabit());
            }
        }

        /// <summary>
        /// Returns the reminder with the earliest remind date in the reminder list.
        /// Returns null if list is empty 
        /// </summary>
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

        /// <summary>
        /// Returns true if the reminder parameter is the earliest reminder
        /// </summary>
        private bool isEarliestHabit(Habit inHabit)
        {
            return inHabit.Equals(findEarliestHabit());
        }

        private void habitTimer_Tick(object sender, EventArgs e)
        {
            showHabit();
        }

        private void clbHabit_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tabHabit_Click(object sender, EventArgs e)
        {

        }

        private void btnHelpHabit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void btnHelpTodo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tuliskan To Do List yang harus dilakukan kemudian tekan tombol 'Add To Do List'." + "\n" +
                            "Ketika list sudah dilakukan centang pada box kemudian list akan menghilang.", "Help");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHelpJadwalIbadah_Click(object sender, EventArgs e)
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

        private void btnHelpReminder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tuliskan deskripsi reminder dan pilih tanggal dan waktu nya kemudian tekan tombol 'Add'." + "\n" +
                            "Reminder akan muncul pada box di sebelah kiri, ketika notifikasi muncul reminder akan hilang dengan sendirinya." + "\n" +
                            "Centang reminder pada box kemudian tekan delete untuk menghapus reminder.", "Help");
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

        private void btnHelpJadwal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tuliskan deskripsi jadwal dan pilih tanggal dan waktu nya kemudian tekan tombol 'Add'." + "\n" +
                           "Jadwal akan muncul pada box 'Jadwal Minggu Ini', ketika notifikasi muncul jadwal akan hilang dengan sendirinya." + "\n" +
                           "Box 'Jadwal Hari Ini' menunjukkan jadwal yang terdapat pada hari pada hari itu. Centang jadwal untuk menghapus jadwal yang sudah dilakukan." + "\n" +
                           "Pilih jadwal pada kolom 'Delete' dan tekan delete untuk menghapus jadwal." + "Help");

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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

    }
}
