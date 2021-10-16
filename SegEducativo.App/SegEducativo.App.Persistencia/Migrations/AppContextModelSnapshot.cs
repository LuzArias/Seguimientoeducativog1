﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SegEducativo.App.Persistencia;

namespace SegEducativo.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SegEducativo.App.Dominio.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfesorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Grupo");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstudianteId");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persona");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Recomendaciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstudianteId");

                    b.ToTable("Recomendaciones");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstudianteId");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Acudiente", b =>
                {
                    b.HasBaseType("SegEducativo.App.Dominio.Persona");

                    b.Property<string>("Parentesco")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Acudiente");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Estudiante", b =>
                {
                    b.HasBaseType("SegEducativo.App.Dominio.Persona");

                    b.Property<int?>("AcudienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.HasIndex("AcudienteId");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Profesor", b =>
                {
                    b.HasBaseType("SegEducativo.App.Dominio.Persona");

                    b.Property<int?>("EstudianteId")
                        .HasColumnType("int");

                    b.HasIndex("EstudianteId");

                    b.HasDiscriminator().HasValue("Profesor");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Grupo", b =>
                {
                    b.HasOne("SegEducativo.App.Dominio.Profesor", null)
                        .WithMany("Grupos")
                        .HasForeignKey("ProfesorId");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Materia", b =>
                {
                    b.HasOne("SegEducativo.App.Dominio.Estudiante", null)
                        .WithMany("Materias")
                        .HasForeignKey("EstudianteId");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Recomendaciones", b =>
                {
                    b.HasOne("SegEducativo.App.Dominio.Estudiante", null)
                        .WithMany("Recomendaciones")
                        .HasForeignKey("EstudianteId");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Tarea", b =>
                {
                    b.HasOne("SegEducativo.App.Dominio.Estudiante", null)
                        .WithMany("Tareas")
                        .HasForeignKey("EstudianteId");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Estudiante", b =>
                {
                    b.HasOne("SegEducativo.App.Dominio.Acudiente", "Acudiente")
                        .WithMany()
                        .HasForeignKey("AcudienteId");

                    b.Navigation("Acudiente");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Profesor", b =>
                {
                    b.HasOne("SegEducativo.App.Dominio.Estudiante", null)
                        .WithMany("Profesores")
                        .HasForeignKey("EstudianteId");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Estudiante", b =>
                {
                    b.Navigation("Materias");

                    b.Navigation("Profesores");

                    b.Navigation("Recomendaciones");

                    b.Navigation("Tareas");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Profesor", b =>
                {
                    b.Navigation("Grupos");
                });
#pragma warning restore 612, 618
        }
    }
}
