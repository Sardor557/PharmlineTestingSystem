using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Linq;
using Toolbelt.ComponentModel.DataAnnotations;
using System;
using PharmlineTestingSystem.Database.Extensions;
using PharmlineTestingSystem.Models;

namespace PharmlineTestingSystem.Database
{
    public sealed partial class MyDbContext : DbContext
    {

        #region dbSet
        public DbSet<spDrug> spDrugs { get; set; }
        public DbSet<spStatus> spStatuses { get; set; }
        public DbSet<tbAnswer> tbAnswers { get; set; }
        public DbSet<tbEmployee> tbEmployees { get; set; }
        public DbSet<tbOption> tbOptions { get; set; }
        public DbSet<tbQuestion> tbQuestions { get; set; }
        public DbSet<tbUser> tbUsers { get; set; }
        #endregion

        public MyDbContext(DbContextOptions options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();
            modelBuilder.BuildIndexesFromAnnotations();

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }
        
        public DbConnection GetDbConnection()
        {
            return Database.GetDbConnection();
        }
    }
}