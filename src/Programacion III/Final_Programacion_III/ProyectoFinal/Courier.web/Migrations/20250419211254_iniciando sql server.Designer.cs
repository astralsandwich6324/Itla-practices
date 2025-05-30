﻿// <auto-generated />
using System;
using Courier.Web.Components.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Courier.web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250419211254_iniciando sql server")]
    partial class iniciandosqlserver
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Courier.web.Components.Models.ClaseLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoginDB");
                });

            modelBuilder.Entity("Courier.web.Components.Models.Paquetes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("HistoryId")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<string>("Proveedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Retenido")
                        .HasColumnType("bit");

                    b.Property<double>("Volumen")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("PaquetesDB");
                });

            modelBuilder.Entity("Courier.web.Components.Models.PreAlertas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contenido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EntregaEstimada")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HistoryId")
                        .HasColumnType("int");

                    b.Property<string>("Proveedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tracking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trasportista")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Valor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PreaAlertasDb");
                });
#pragma warning restore 612, 618
        }
    }
}
