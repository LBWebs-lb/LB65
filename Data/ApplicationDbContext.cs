﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LB.Models;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
namespace LB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Acces> Acces { get; set; }
        public DbSet<MailLB> Mail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acces>().ToTable("lbacc");
            modelBuilder.Entity<MailLB>().ToTable("lbmail");
            base.OnModelCreating(modelBuilder);
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (!ChangeTracker.DebugView.ShortView.Contains("IdentityUser")) {
                var AddedEntities = ChangeTracker.Entries().Where(E => E.State == EntityState.Added).ToList();

                AddedEntities.ForEach(E =>
                {
                    //E.Property("cusualt").CurrentValue = Common.ExtensionsMethods.getuserid(this.Users);
                    E.Property("faltrto").CurrentValue = DateTime.Now;
                    E.Property("hmod").CurrentValue = DateTime.Now.ToString("HH:mm");
                    E.Property("fmod").CurrentValue = DateTime.Now.ToString("dd/M/yyyy");
                });

                var EditedEntities = ChangeTracker.Entries().Where(E => E.State == EntityState.Modified).ToList();

                EditedEntities.ForEach(E =>
                {
                    E.Property("hmod").CurrentValue = DateTime.Now.ToString("HH:mm");
                    E.Property("fmod").CurrentValue = DateTime.Now.ToString("dd/M/yyyy");
                });
            }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
