﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Context;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20221207104036_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebAPI.Models.Angsuran", b =>
                {
                    b.Property<int>("IdAngsuran")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAngsuran"), 1L, 1);

                    b.Property<int>("AngsuranKe")
                        .HasColumnType("int");

                    b.Property<double>("BesarAngsuran")
                        .HasColumnType("float");

                    b.Property<double>("Denda")
                        .HasColumnType("float");

                    b.Property<int>("IdPinjaman")
                        .HasColumnType("int");

                    b.Property<double>("SisaPinjaman")
                        .HasColumnType("float");

                    b.Property<DateTime>("TglEntry")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEntry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAngsuran");

                    b.HasIndex("IdPinjaman");

                    b.ToTable("Angsuran");
                });

            modelBuilder.Entity("WebAPI.Models.JenisPinjaman", b =>
                {
                    b.Property<int>("IdJenisPinjaman")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdJenisPinjaman"), 1L, 1);

                    b.Property<double>("Bunga")
                        .HasColumnType("float");

                    b.Property<int>("LamaAngsuran")
                        .HasColumnType("int");

                    b.Property<double>("MaksPinjaman")
                        .HasColumnType("float");

                    b.Property<string>("NamaPinjaman")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TglEntry")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEntry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdJenisPinjaman");

                    b.ToTable("JenisPinjaman");
                });

            modelBuilder.Entity("WebAPI.Models.JenisSimpanan", b =>
                {
                    b.Property<int>("IdJenisSimpanan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdJenisSimpanan"), 1L, 1);

                    b.Property<double>("BesarSimpanan")
                        .HasColumnType("float");

                    b.Property<string>("NamaSimpanan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TglEntry")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEntry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdJenisSimpanan");

                    b.ToTable("JenisSimpanan");
                });

            modelBuilder.Entity("WebAPI.Models.Penarikan", b =>
                {
                    b.Property<int>("IdPenarikan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPenarikan"), 1L, 1);

                    b.Property<int>("BesarPenarikan")
                        .HasColumnType("int");

                    b.Property<int>("IdTabungan")
                        .HasColumnType("int");

                    b.Property<DateTime>("TglPenarikan")
                        .HasColumnType("datetime2");

                    b.HasKey("IdPenarikan");

                    b.HasIndex("IdTabungan");

                    b.ToTable("Penarikan");
                });

            modelBuilder.Entity("WebAPI.Models.Pengajuan", b =>
                {
                    b.Property<int>("IdPengajuan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPengajuan"), 1L, 1);

                    b.Property<double>("BesarAngsuran")
                        .HasColumnType("float");

                    b.Property<int>("BesarPinjaman")
                        .HasColumnType("int");

                    b.Property<int>("IdJenisPinjaman")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TglAcc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TglPengajuan")
                        .HasColumnType("datetime2");

                    b.HasKey("IdPengajuan");

                    b.HasIndex("IdJenisPinjaman");

                    b.HasIndex("IdUser");

                    b.ToTable("Pengajuan");
                });

            modelBuilder.Entity("WebAPI.Models.Pinjaman", b =>
                {
                    b.Property<int>("IdPinjaman")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPinjaman"), 1L, 1);

                    b.Property<double>("BesarAngsuran")
                        .HasColumnType("float");

                    b.Property<double>("BesarPinjaman")
                        .HasColumnType("float");

                    b.Property<int>("IdJenisPinjaman")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("LamaAngsuran")
                        .HasColumnType("int");

                    b.Property<int>("SisaAngsuran")
                        .HasColumnType("int");

                    b.Property<double>("SisaPinjaman")
                        .HasColumnType("float");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TglEntry")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TglTempo")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEntry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPinjaman");

                    b.HasIndex("IdJenisPinjaman");

                    b.HasIndex("IdUser");

                    b.ToTable("Pinjaman");
                });

            modelBuilder.Entity("WebAPI.Models.Role", b =>
                {
                    b.Property<int>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRole"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TglEntry")
                        .HasColumnType("datetime2");

                    b.HasKey("IdRole");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebAPI.Models.Simpanan", b =>
                {
                    b.Property<int>("IdSimpanan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSimpanan"), 1L, 1);

                    b.Property<double>("BesarSimpanan")
                        .HasColumnType("float");

                    b.Property<int>("IdJenisSimpanan")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("TglEntry")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TglMulai")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEntry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSimpanan");

                    b.HasIndex("IdJenisSimpanan");

                    b.HasIndex("IdUser");

                    b.ToTable("Simpanan");
                });

            modelBuilder.Entity("WebAPI.Models.Tabungan", b =>
                {
                    b.Property<int>("IdTabungan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTabungan"), 1L, 1);

                    b.Property<double>("BesarTabungan")
                        .HasColumnType("float");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("TglMulai")
                        .HasColumnType("datetime2");

                    b.HasKey("IdTabungan");

                    b.HasIndex("IdUser");

                    b.ToTable("Tabungan");
                });

            modelBuilder.Entity("WebAPI.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"), 1L, 1);

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdRole")
                        .HasColumnType("int");

                    b.Property<string>("JenisKelamin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomorAnggota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pekerjaan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telepon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TempatLahir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TglEntry")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TglLahir")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TglMasuk")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEntry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUser");

                    b.HasIndex("IdRole");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebAPI.Models.Angsuran", b =>
                {
                    b.HasOne("WebAPI.Models.Pinjaman", "Pinjaman")
                        .WithMany()
                        .HasForeignKey("IdPinjaman")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pinjaman");
                });

            modelBuilder.Entity("WebAPI.Models.Penarikan", b =>
                {
                    b.HasOne("WebAPI.Models.Tabungan", "Tabungan")
                        .WithMany()
                        .HasForeignKey("IdTabungan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tabungan");
                });

            modelBuilder.Entity("WebAPI.Models.Pengajuan", b =>
                {
                    b.HasOne("WebAPI.Models.JenisPinjaman", "JenisPinjaman")
                        .WithMany()
                        .HasForeignKey("IdJenisPinjaman")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JenisPinjaman");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebAPI.Models.Pinjaman", b =>
                {
                    b.HasOne("WebAPI.Models.JenisPinjaman", "JenisPinjaman")
                        .WithMany()
                        .HasForeignKey("IdJenisPinjaman")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JenisPinjaman");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebAPI.Models.Simpanan", b =>
                {
                    b.HasOne("WebAPI.Models.JenisSimpanan", "JenisSimpanan")
                        .WithMany()
                        .HasForeignKey("IdJenisSimpanan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JenisSimpanan");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebAPI.Models.Tabungan", b =>
                {
                    b.HasOne("WebAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebAPI.Models.User", b =>
                {
                    b.HasOne("WebAPI.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("IdRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}