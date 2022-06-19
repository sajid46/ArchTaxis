using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TaxiBoxAPI.Models
{
    public partial class TaxiBoxContext : DbContext
    {
        public TaxiBoxContext()
        {
        }

        public TaxiBoxContext(DbContextOptions<TaxiBoxContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Airport> Airports { get; set; } = null!;
        public virtual DbSet<Autogenerateinfo> Autogenerateinfos { get; set; } = null!;
        public virtual DbSet<Cookie> Cookies { get; set; } = null!;
        public virtual DbSet<Counter> Counters { get; set; } = null!;
        public virtual DbSet<Driver> Drivers { get; set; } = null!;
        public virtual DbSet<DriversStatus> DriversStatuses { get; set; } = null!;
        public virtual DbSet<FixedPricedJourny> FixedPricedJournies { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<JobsNote> JobsNotes { get; set; } = null!;
        public virtual DbSet<JobsOld> JobsOlds { get; set; } = null!;
        public virtual DbSet<JobsOtherCharge> JobsOtherCharges { get; set; } = null!;
        public virtual DbSet<PaxDetail> PaxDetails { get; set; } = null!;
        public virtual DbSet<Price> Prices { get; set; } = null!;
        public virtual DbSet<Setting> Settings { get; set; } = null!;
        public virtual DbSet<SettingsFare> SettingsFares { get; set; } = null!;
        public virtual DbSet<SettingsTmp> SettingsTmps { get; set; } = null!;
        public virtual DbSet<TaxiCompany> TaxiCompanies { get; set; } = null!;
        public virtual DbSet<TownsVillage> TownsVillages { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UsersBlacklist> UsersBlacklists { get; set; } = null!;
        public virtual DbSet<VehSelector> VehSelectors { get; set; } = null!;
        public virtual DbSet<Visitor> Visitors { get; set; } = null!;
        public virtual DbSet<VwJobswithNote> VwJobswithNotes { get; set; } = null!;
        public virtual DbSet<VwTownsVillage> VwTownsVillages { get; set; } = null!;
        public virtual DbSet<VwTownsVillagesDistinct> VwTownsVillagesDistincts { get; set; } = null!;
        public virtual DbSet<VwVehicleSelector> VwVehicleSelectors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=TaxiBox;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airport>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DeletedFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Autogenerateinfo>(entity =>
            {
                entity.ToTable("autogenerateinfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BusinessComponentname)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Datacomponentname)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteSp)
                    .HasColumnName("DeleteSP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.FetchSp)
                    .HasColumnName("FetchSP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InsertSp)
                    .HasColumnName("InsertSP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnDataReader).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnDataTable).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnDataset).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnXmlReader).HasDefaultValueSql("((0))");

                entity.Property(e => e.SpuExecuteNonQuery)
                    .HasColumnName("SPU_ExecuteNonQuery")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SpuExecuteScalar)
                    .HasColumnName("SPU_ExecuteScalar")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TableName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateSp)
                    .HasColumnName("UpdateSP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WebServiceName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cookie>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CookrieId).HasColumnName("CookrieID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Expires).HasColumnType("datetime");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.ToTable("Counter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Counter1).HasColumnName("Counter");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DeletedFlag).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Created)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DeletedFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.DriverNo).HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PostCode).HasMaxLength(15);

                entity.Property(e => e.TelNo).HasMaxLength(15);

                entity.Property(e => e.Town).HasMaxLength(100);

                entity.Property(e => e.Updated)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasMaxLength(20);

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<DriversStatus>(entity =>
            {
                entity.ToTable("DriversStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DriverNo).HasMaxLength(10);

                entity.Property(e => e.Location).HasMaxLength(10);

                entity.Property(e => e.Status).HasMaxLength(15);
            });

            modelBuilder.Entity<FixedPricedJourny>(entity =>
            {
                entity.ToTable("FixedPriced_Journies");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DayPrice).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.DeletedFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Destination)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NightPrice).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Pickup)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DateTimePickup).HasMaxLength(20);

                entity.Property(e => e.DeletedFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Destination)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Distance).HasMaxLength(20);

                entity.Property(e => e.DriverNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DurationMinutes).HasMaxLength(20);

                entity.Property(e => e.IsMg).HasColumnName("IsMG");

                entity.Property(e => e.JobStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaxEmail).HasMaxLength(500);

                entity.Property(e => e.PaxMobileNo).HasMaxLength(20);

                entity.Property(e => e.PaxName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pickup)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'suser_sname(0')");

                entity.Property(e => e.VehicleRequiredId).HasColumnName("VehicleRequiredID");
            });

            modelBuilder.Entity<JobsNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("COMPLETED, PENDING, CANCELLED");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(suser_sname())");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobsNotes)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_JobsNotes_Jobs");
            });

            modelBuilder.Entity<JobsOld>(entity =>
            {
                entity.ToTable("JobsOld");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DateTimePickup).HasMaxLength(20);

                entity.Property(e => e.Destination)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("IF A JOB HAS BEEN DISCOUNTED.. THEN DRIVER COMMISSIONED SHOULD BE DROPPED..");

                entity.Property(e => e.DriverNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JobStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("COMPLETED, PENDING, CANCELLED");

                entity.Property(e => e.MeetAndGreet).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.PaidTf).HasColumnName("PaidTF");

                entity.Property(e => e.PassengerName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pickup)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.VehicleRequiredId)
                    .HasColumnName("VehicleRequiredID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<JobsOtherCharge>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<PaxDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Created)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DeletedFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.MobileNo).HasMaxLength(15);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PostCode).HasMaxLength(15);

                entity.Property(e => e.TelNo).HasMaxLength(15);

                entity.Property(e => e.Town).HasMaxLength(100);

                entity.Property(e => e.Updated)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DayPrice).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.DeletedFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Destination)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NightPrice).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Pickup)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Created)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DeletedFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Updated)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasMaxLength(20);

                entity.Property(e => e.Value).HasMaxLength(100);
            });

            modelBuilder.Entity<SettingsFare>(entity =>
            {
                entity.ToTable("SettingsFare");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaseRate).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.BaseRateDistanceType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BaseRatePerDistance).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.StartMeterFare).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.StartMeterFarePerDistanceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_name())");
            });

            modelBuilder.Entity<SettingsTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SettingsTmp");

                entity.Property(e => e.Created)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DeletedFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Updated)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasMaxLength(20);

                entity.Property(e => e.Value).HasMaxLength(100);
            });

            modelBuilder.Entity<TaxiCompany>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Town)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            });

            modelBuilder.Entity<TownsVillage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DeletedFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.TownsVillages)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.DeletedFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSuperAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUser).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<UsersBlacklist>(entity =>
            {
                entity.ToTable("UsersBlacklist");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_name())");

                entity.Property(e => e.DeletedFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IP");
            });

            modelBuilder.Entity<VehSelector>(entity =>
            {
                entity.ToTable("VehSelector");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PercentIncreament)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasMaxLength(20);

                entity.Property(e => e.VehImage).HasColumnType("image");
            });

            modelBuilder.Entity<Visitor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Visitor1)
                    .HasMaxLength(50)
                    .HasColumnName("Visitor");
            });

            modelBuilder.Entity<VwJobswithNote>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_JobswithNotes");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.DateTimePickup).HasMaxLength(20);

                entity.Property(e => e.Destination)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Distance).HasMaxLength(20);

                entity.Property(e => e.DriverNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DurationMinutes).HasMaxLength(20);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsMg).HasColumnName("IsMG");

                entity.Property(e => e.JobStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaxEmail).HasMaxLength(500);

                entity.Property(e => e.PaxMobileNo).HasMaxLength(20);

                entity.Property(e => e.PaxName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pickup)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.VehicleRequiredId).HasColumnName("VehicleRequiredID");
            });

            modelBuilder.Entity<VwTownsVillage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_TownsVillages");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TownsVillages)
                    .HasMaxLength(354)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwTownsVillagesDistinct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_TownsVillages_DISTINCT");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TownsVillages)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwVehicleSelector>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_VehicleSelector");

                entity.Property(e => e.Created).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PercentIncreament)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(20);

                entity.Property(e => e.VehImage).HasColumnType("image");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
