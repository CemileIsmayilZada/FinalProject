// <auto-generated />
using System;
using Hotel.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230213080458_All")]
    partial class All
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hotel.Core.Entities.Amentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Amentities");
                });

            modelBuilder.Entity("Hotel.Core.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Created")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("FlatId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Opinions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FlatId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Hotel.Core.Entities.Flat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Adults")
                        .HasColumnType("int");

                    b.Property<int>("BedCount")
                        .HasColumnType("int");

                    b.Property<int>("Children")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("RoomCatagoryId")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomCatagoryId");

                    b.ToTable("Flats");
                });

            modelBuilder.Entity("Hotel.Core.Entities.FlatAmentity", b =>
                {
                    b.Property<int>("FlatId")
                        .HasColumnType("int");

                    b.Property<int>("AmentityId")
                        .HasColumnType("int");

                    b.HasKey("FlatId", "AmentityId");

                    b.HasIndex("AmentityId");

                    b.ToTable("FlatAmentity");
                });

            modelBuilder.Entity("Hotel.Core.Entities.GallaryCatagory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("GallaryCatagories");
                });

            modelBuilder.Entity("Hotel.Core.Entities.GallaryImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GallaryCatagoryId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GallaryCatagoryId");

                    b.ToTable("GallaryImages");
                });

            modelBuilder.Entity("Hotel.Core.Entities.NearPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("NearPlaces");
                });

            modelBuilder.Entity("Hotel.Core.Entities.RoomCatagory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("RoomCatagories");
                });

            modelBuilder.Entity("Hotel.Core.Entities.RoomImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FlatId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FlatId");

                    b.ToTable("RoomImages");
                });

            modelBuilder.Entity("Hotel.Core.Entities.ServiceImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceOfferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceOfferId");

                    b.ToTable("ServiceImages");
                });

            modelBuilder.Entity("Hotel.Core.Entities.ServiceOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFree")
                        .HasColumnType("bit");

                    b.Property<float?>("Price")
                        .IsRequired()
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("ServiceOffers");
                });

            modelBuilder.Entity("Hotel.Core.Entities.SliderHome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("SliderHomes");
                });

            modelBuilder.Entity("Hotel.Core.Entities.TeamMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("TeamMembers");
                });

            modelBuilder.Entity("Hotel.Core.Entities.TeamMemberInformation", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Facebook")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Instagram")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Linkedin")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Twitter")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("TeamMemberInformations");
                });

            modelBuilder.Entity("Hotel.Core.Entities.WhyUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("WhyUss");
                });

            modelBuilder.Entity("Hotel.Core.Entities.Comment", b =>
                {
                    b.HasOne("Hotel.Core.Entities.Flat", "Flat")
                        .WithMany("Comments")
                        .HasForeignKey("FlatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flat");
                });

            modelBuilder.Entity("Hotel.Core.Entities.Flat", b =>
                {
                    b.HasOne("Hotel.Core.Entities.RoomCatagory", "RoomCatagory")
                        .WithMany("Flats")
                        .HasForeignKey("RoomCatagoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomCatagory");
                });

            modelBuilder.Entity("Hotel.Core.Entities.FlatAmentity", b =>
                {
                    b.HasOne("Hotel.Core.Entities.Amentity", "Amentity")
                        .WithMany("Flats")
                        .HasForeignKey("AmentityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel.Core.Entities.Flat", "Flat")
                        .WithMany("Amentities")
                        .HasForeignKey("FlatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amentity");

                    b.Navigation("Flat");
                });

            modelBuilder.Entity("Hotel.Core.Entities.GallaryImage", b =>
                {
                    b.HasOne("Hotel.Core.Entities.GallaryCatagory", "GallaryCatagory")
                        .WithMany("Images")
                        .HasForeignKey("GallaryCatagoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GallaryCatagory");
                });

            modelBuilder.Entity("Hotel.Core.Entities.RoomImage", b =>
                {
                    b.HasOne("Hotel.Core.Entities.Flat", "Flat")
                        .WithMany("Images")
                        .HasForeignKey("FlatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flat");
                });

            modelBuilder.Entity("Hotel.Core.Entities.ServiceImage", b =>
                {
                    b.HasOne("Hotel.Core.Entities.ServiceOffer", "ServiceOffer")
                        .WithMany("ServiceImages")
                        .HasForeignKey("ServiceOfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServiceOffer");
                });

            modelBuilder.Entity("Hotel.Core.Entities.TeamMemberInformation", b =>
                {
                    b.HasOne("Hotel.Core.Entities.TeamMember", "TeamMember")
                        .WithOne("TeamMemberInformation")
                        .HasForeignKey("Hotel.Core.Entities.TeamMemberInformation", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeamMember");
                });

            modelBuilder.Entity("Hotel.Core.Entities.Amentity", b =>
                {
                    b.Navigation("Flats");
                });

            modelBuilder.Entity("Hotel.Core.Entities.Flat", b =>
                {
                    b.Navigation("Amentities");

                    b.Navigation("Comments");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("Hotel.Core.Entities.GallaryCatagory", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("Hotel.Core.Entities.RoomCatagory", b =>
                {
                    b.Navigation("Flats");
                });

            modelBuilder.Entity("Hotel.Core.Entities.ServiceOffer", b =>
                {
                    b.Navigation("ServiceImages");
                });

            modelBuilder.Entity("Hotel.Core.Entities.TeamMember", b =>
                {
                    b.Navigation("TeamMemberInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
