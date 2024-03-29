﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _07_Fiap.Web.AspNet.Persistence;

namespace _07_Fiap.Web.AspNet.Migrations
{
    [DbContext(typeof(PresidioContext))]
    [Migration("20190926114623_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_07_Fiap.Web.AspNet.Models.Cela", b =>
                {
                    b.Property<int>("CelaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Area");

                    b.Property<string>("Nome");

                    b.Property<int>("QuantidadeMaxima");

                    b.HasKey("CelaId");

                    b.ToTable("Celas");
                });

            modelBuilder.Entity("_07_Fiap.Web.AspNet.Models.Presidiario", b =>
                {
                    b.Property<int>("PresidiarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CelaId");

                    b.Property<DateTime>("DataEntrada");

                    b.Property<DateTime>("DataSaida");

                    b.Property<int>("NivelEscolaridade");

                    b.Property<string>("Nome");

                    b.Property<bool>("SaidaTemporaria");

                    b.HasKey("PresidiarioId");

                    b.HasIndex("CelaId");

                    b.ToTable("Presidiarios");
                });

            modelBuilder.Entity("_07_Fiap.Web.AspNet.Models.Presidiario", b =>
                {
                    b.HasOne("_07_Fiap.Web.AspNet.Models.Cela", "Cela")
                        .WithMany("Presidiarios")
                        .HasForeignKey("CelaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
