using AsbtCore.UtilsV2;
using Microsoft.EntityFrameworkCore;
using PharmlineTestingSystem.Models;
using System;

namespace PharmlineTestingSystem.Database.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<spStatus>().HasData(new spStatus
            {
                Id = 1,
                Name = "Активный"
            },
            new spStatus
            {
                Id = 2,
                Name = "Архив"
            });

            modelBuilder.Entity<tbUser>().HasData(new tbUser()
            {
                Id = 1,
                FIO = "Admin",
                Login = "admin",
                Password = CHash.EncryptMD5("s8064025"),
                Status = 1,
                CreateDate = DateTime.Now,
                CreateUser = 1
            });
            modelBuilder.Entity<tbUser>().HasData(new tbUser()
            {
                Id = 2,
                FIO = "Gavxar",
                Login = "director",
                Password = CHash.EncryptMD5("s8064025"),
                Status = 1,
                CreateDate = DateTime.Now,
                CreateUser = 1,
            });
            modelBuilder.Entity<tbUser>().HasData(new tbUser()
            {
                Id = 3,
                FIO = "Jenya",
                Login = "manager",
                Password = CHash.EncryptMD5("1234567"),
                Status = 1,
                CreateDate = DateTime.Now,
                CreateUser = 1,
            });
            modelBuilder.Entity<tbUser>().HasData(new tbUser()
            {
                Id = 4,
                FIO = "Sklad",
                Login = "sklad",
                Password = CHash.EncryptMD5("7654321"),
                Status = 1,
                CreateDate = DateTime.Now,
                CreateUser = 1
            });
        }
    }
}
