﻿// <auto-generated />
using System;
using LB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LB.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210108081551_prediss")]
    partial class prediss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("LB.Models.Acces", b =>
                {
                    b.Property<int>("idlb")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("acc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime2");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("linkWp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passWd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userWp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idlb");

                    b.ToTable("lbacc");
                });

            modelBuilder.Entity("LB.Models.Clients.ClientHosting", b =>
                {
                    b.Property<int>("ihos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime2");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("linkwphos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passhos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userhos")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ihos");

                    b.ToTable("clihos");
                });

            modelBuilder.Entity("LB.Models.Clients.ClientsFtp", b =>
                {
                    b.Property<int>("iftp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime2");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ipserver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passftp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userftp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("iftp");

                    b.ToTable("cliftp");
                });

            modelBuilder.Entity("LB.Models.Clients.ClientsPreDisseny", b =>
                {
                    b.Property<int>("ipredis")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("bouby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("envcli")
                        .HasColumnType("bit");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime2");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("paid")
                        .HasColumnType("bit");

                    b.Property<int>("pctheme")
                        .HasColumnType("int");

                    b.Property<string>("ptheme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("themebuy")
                        .HasColumnType("bit");

                    b.HasKey("ipredis");

                    b.ToTable("clipredis");
                });

            modelBuilder.Entity("LB.Models.MailLB", b =>
                {
                    b.Property<int>("idlbmail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dnommail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime2");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lnkmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mailuser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idlbmail");

                    b.ToTable("lbmail");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
