﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_Final_Registro_CESIM.Data;

namespace Proyecto_Final_Registro_CESIM.Migrations
{
    [DbContext(typeof(Proyecto_Final_Registro_CESIMContext))]
    [Migration("20191204183814_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proyecto_Final_Registro_CESIM.Models.Docente", b =>
                {
                    b.Property<int>("docenteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Sexo")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("docenteID");

                    b.ToTable("Docente");
                });

            modelBuilder.Entity("Proyecto_Final_Registro_CESIM.Models.Estudiante", b =>
                {
                    b.Property<int>("estudianteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Sexo")
                        .HasColumnType("int");

                    b.Property<int>("tutorID")
                        .HasColumnType("int");

                    b.HasKey("estudianteID");

                    b.HasIndex("tutorID");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("Proyecto_Final_Registro_CESIM.Models.Grado", b =>
                {
                    b.Property<int>("gradoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Nivel")
                        .HasColumnType("int");

                    b.Property<int>("docenteID")
                        .HasColumnType("int");

                    b.HasKey("gradoID");

                    b.HasIndex("docenteID");

                    b.ToTable("Grado");
                });

            modelBuilder.Entity("Proyecto_Final_Registro_CESIM.Models.Matricula", b =>
                {
                    b.Property<int>("matriculaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Grad")
                        .HasColumnType("int");

                    b.Property<int>("estudianteID")
                        .HasColumnType("int");

                    b.Property<int>("gradoID")
                        .HasColumnType("int");

                    b.Property<int>("periodoID")
                        .HasColumnType("int");

                    b.HasKey("matriculaID");

                    b.HasIndex("estudianteID");

                    b.HasIndex("gradoID");

                    b.HasIndex("periodoID");

                    b.ToTable("Matricula");
                });

            modelBuilder.Entity("Proyecto_Final_Registro_CESIM.Models.Periodo", b =>
                {
                    b.Property<int>("periodoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Parcial")
                        .HasColumnType("int");

                    b.HasKey("periodoID");

                    b.ToTable("Periodo");
                });

            modelBuilder.Entity("Proyecto_Final_Registro_CESIM.Models.Tutor", b =>
                {
                    b.Property<int>("tutorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("tutorID");

                    b.ToTable("Tutor");
                });

            modelBuilder.Entity("Proyecto_Final_Registro_CESIM.Models.Usuario", b =>
                {
                    b.Property<int>("usuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("matriculaID")
                        .HasColumnType("int");

                    b.HasKey("usuarioID");

                    b.HasIndex("matriculaID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Proyecto_Final_Registro_CESIM.Models.Estudiante", b =>
                {
                    b.HasOne("Proyecto_Final_Registro_CESIM.Models.Tutor", "Tutor")
                        .WithMany("Estudiantes")
                        .HasForeignKey("tutorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto_Final_Registro_CESIM.Models.Grado", b =>
                {
                    b.HasOne("Proyecto_Final_Registro_CESIM.Models.Docente", "docente")
                        .WithMany("Grados")
                        .HasForeignKey("docenteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto_Final_Registro_CESIM.Models.Matricula", b =>
                {
                    b.HasOne("Proyecto_Final_Registro_CESIM.Models.Estudiante", "Estudiante")
                        .WithMany("Matriculas")
                        .HasForeignKey("estudianteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_Final_Registro_CESIM.Models.Grado", "Grado")
                        .WithMany("matriculas")
                        .HasForeignKey("gradoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_Final_Registro_CESIM.Models.Periodo", "Periodo")
                        .WithMany("Matriculas")
                        .HasForeignKey("periodoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto_Final_Registro_CESIM.Models.Usuario", b =>
                {
                    b.HasOne("Proyecto_Final_Registro_CESIM.Models.Matricula", "Matricula")
                        .WithMany("Usuarios")
                        .HasForeignKey("matriculaID");
                });
#pragma warning restore 612, 618
        }
    }
}
