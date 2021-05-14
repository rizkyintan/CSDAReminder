using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CSDAReminder
{
    public partial class CSDA_Model : DbContext
    {
        public CSDA_Model()
            : base("name=CSDA_Model")
        {
        }

        public virtual DbSet<ReminderTable> ReminderTables { get; set; }
        public virtual DbSet<TodoTable> TodoTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
