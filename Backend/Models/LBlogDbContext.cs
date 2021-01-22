using System.Reflection;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Backend.Models.BlogModels;

namespace Backend.Models
{
    public class LBlogDbContext: DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogType> BlogTypes { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }

        public LBlogDbContext(DbContextOptions options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //// seeding user and roles
            //#region seed custom admin role
            //string ADMIN_ID = Guid.NewGuid().ToString();
            //string ROLE_ID = ADMIN_ID;
            ////seed custom admin role
            //modelBuilder.Entity<LBlogRole>().HasData(new LBlogRole
            //{
            //    Id = ROLE_ID,
            //    Name = "root",
            //    NormalizedName = "ROOT"
            //});
            //modelBuilder.Entity<LBlogRole>().HasData(new LBlogRole
            //{
            //    Id = Guid.NewGuid().ToString(),
            //    Name = "admin",
            //    NormalizedName = "ADMIN"
            //});
            //modelBuilder.Entity<LBlogRole>().HasData(new LBlogRole
            //{
            //    Id = Guid.NewGuid().ToString(),
            //    Name = "VIP",
            //    NormalizedName = "VIP"
            //});
            //modelBuilder.Entity<LBlogRole>().HasData(new LBlogRole
            //{
            //    Id = Guid.NewGuid().ToString(),
            //    Name = "user",
            //    NormalizedName = "USER"
            //});
            ////seed admins
            //var hasher = new PasswordHasher<LBlogUser>();
            //modelBuilder.Entity<LBlogUser>().HasData(new LBlogUser
            //{
            //    Id = ADMIN_ID,
            //    NickName = "louis",
            //    UserName = "admin@test.com",
            //    NormalizedUserName = "admin@test.com".ToUpper(),
            //    Email = "admin@test.com",
            //    NormalizedEmail = "admin@test.com".ToUpper(),
            //    EmailConfirmed = true,
            //    PasswordHash = hasher.HashPassword(null, "admin"),
            //    SecurityStamp = string.Empty,
            //    Active = true
            //});
            ////seed admin into role
            //modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            //{
            //    RoleId = ROLE_ID,
            //    UserId = ADMIN_ID
            //});
            //#endregion
        }
    }
}
