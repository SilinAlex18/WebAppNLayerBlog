using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppNLayerBlog.DataAccessLayer.Models;

namespace WebAppNLayerBlog.DataAccessLayer.Data.Seeds
{
    public static class UserSeed
    {
        public static void OnUserSeed(this ModelBuilder modelBuilder)
        {
            var user = new User
            {
                Id = "773a524b-99af-4fe3-b950-0f7d8ff82b0e",
                UserName = "tester",
                Email = "tester@test.com",
                NormalizedEmail = "tester@test.com".ToUpper(),
                NormalizedUserName = "tester".ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false
            };

            PasswordHasher<User> ph = new PasswordHasher<User>();
            user.PasswordHash = ph.HashPassword(user, "Sawahokei1+");

            modelBuilder.Entity<User>().HasData(
                user
            );
        }
    }
}
