﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace QuizApi.Migrations
{
    [DbContext(typeof(QuizDbContext))]
    partial class QuizDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuizApi.Models.Participant", b =>
                {
                    b.Property<int>("ParticipantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParticipantId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Score")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TimeTaken")
                        .HasColumnType("int");

                    b.HasKey("ParticipantId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("QuizApi.Models.Question", b =>
                {
                    b.Property<int>("QnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QnId"));

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Option1")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Option2")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Option3")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Option4")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("QnInWords")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("QnId");

                    b.ToTable("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
