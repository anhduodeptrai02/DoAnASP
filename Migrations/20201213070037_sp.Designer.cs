﻿// <auto-generated />
using DoAnASP1.Areas.Admin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoAnASP1.Migrations
{
    [DbContext(typeof(DPcontext))]
    [Migration("20201213070037_sp")]
    partial class sp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.LoaiSPModels", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("LoaiSanPham");
                });

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.SanPhamModels", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("gia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("maloai")
                        .HasColumnType("int");

                    b.Property<string>("ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("maloai");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.SanPhamModels", b =>
                {
                    b.HasOne("DoAnASP1.Areas.Admin.Models.LoaiSPModels", "loai")
                        .WithMany("lstSanPham")
                        .HasForeignKey("maloai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("loai");
                });

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.LoaiSPModels", b =>
                {
                    b.Navigation("lstSanPham");
                });
#pragma warning restore 612, 618
        }
    }
}
