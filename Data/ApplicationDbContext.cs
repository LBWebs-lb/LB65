using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
using LB.Models.Clients;
using Microsoft.AspNetCore.Http;

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
        public DbSet<ClientHosting> CliHosting { get; set; }
        public DbSet<ClientsFtp> ClientsFtp { get; set; }
        public DbSet<ClientsPreDisseny> ClientsPredis { get; set; }
        public DbSet<ClientsLB> ClientsLB { get; set; }
        public DbSet<ClientsAcces> ClientsAcces { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acces>().ToTable("lbacc");
            modelBuilder.Entity<MailLB>().ToTable("lbmail");
            modelBuilder.Entity<ClientHosting>().ToTable("clihos");
            modelBuilder.Entity<ClientsFtp>().ToTable("cliftp");
            modelBuilder.Entity<ClientsPreDisseny>().ToTable("clipredis");
            modelBuilder.Entity<ClientsLB>().ToTable("clilb");
            modelBuilder.Entity<ClientsAcces>().ToTable("cliacc");
            base.OnModelCreating(modelBuilder);
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (!ChangeTracker.DebugView.ShortView.Contains("IdentityUser")) {
                var AddedEntities = ChangeTracker.Entries().Where(E => E.State == EntityState.Added).ToList();

                AddedEntities.ForEach(E =>
                {
                    //E.Property("cusualt").CurrentValue = HttpContext.Session.Get
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
