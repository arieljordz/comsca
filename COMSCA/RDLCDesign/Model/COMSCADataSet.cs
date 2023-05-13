using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RDLCDesign.Model
{
    public partial class COMSCADataSet : DbContext
    {
        public COMSCADataSet()
            : base("name=COMSCADataSet1")
        {
        }

        public virtual DbSet<tbl_activeDate> tbl_activeDate { get; set; }
        public virtual DbSet<tbl_collection> tbl_collection { get; set; }
        public virtual DbSet<tbl_collectionDtls> tbl_collectionDtls { get; set; }
        public virtual DbSet<tbl_gender> tbl_gender { get; set; }
        public virtual DbSet<tbl_loanSchedule> tbl_loanSchedule { get; set; }
        public virtual DbSet<tbl_member> tbl_member { get; set; }
        public virtual DbSet<tbl_userAccounts> tbl_userAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_collection>()
                .Property(e => e.ORNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_gender>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_member>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_member>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_member>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_member>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_userAccounts>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_userAccounts>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_userAccounts>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_userAccounts>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_userAccounts>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
