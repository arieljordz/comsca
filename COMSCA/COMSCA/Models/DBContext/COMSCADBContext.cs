using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Models.DBContext
{
    public class COMSCADBContext : DbContext

    {
        public COMSCADBContext(DbContextOptions<COMSCADBContext> options) : base(options) { }

        #region EF: Datase-Tabels to Models
        //------------< region: Datase-Tables to Models >------------
        public DbSet<tbl_gender> tbl_gender { get; set; }
        public DbSet<tbl_member> tbl_member { get; set; }
        public DbSet<tbl_collection> tbl_collection { get; set; }
        public DbSet<tbl_collectionDtls> tbl_collectionDtls { get; set; }
        public DbSet<tbl_activeDate> tbl_activeDate { get; set; }
        public DbSet<tbl_userAccounts> tbl_userAccounts { get; set; }
        public DbSet<tbl_loanSchedule> tbl_loanSchedule { get; set; }
        public DbSet<tbl_fee> tbl_fee { get; set; }
        public DbSet<tbl_feeDtls> tbl_feeDtls { get; set; }
        public DbSet<tbl_loanDtls> tbl_loanDtls { get; set; }
        public DbSet<tbl_loanHdr> tbl_loanHdr { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<tbl_gender>().ToTable("tbl_gender");
            modelBuilder.Entity<tbl_member>().ToTable("tbl_member");
            modelBuilder.Entity<tbl_collection>().ToTable("tbl_collection");
            modelBuilder.Entity<tbl_collectionDtls>().ToTable("tbl_collectionDtls");
            modelBuilder.Entity<tbl_activeDate>().ToTable("tbl_activeDate");
            modelBuilder.Entity<tbl_userAccounts>().ToTable("tbl_userAccounts");
            modelBuilder.Entity<tbl_loanSchedule>().ToTable("tbl_loanSchedule");
            modelBuilder.Entity<tbl_fee>().ToTable("tbl_fee");
            modelBuilder.Entity<tbl_feeDtls>().ToTable("tbl_feeDtls");
            modelBuilder.Entity<tbl_loanDtls>().ToTable("tbl_loanDtls");
            modelBuilder.Entity<tbl_loanHdr>().ToTable("tbl_loanHdr");
        }

        //------------</ region : Datase-Tables to Models >------------

        #endregion /EF: Datase-Tabels to Models

    }
}
