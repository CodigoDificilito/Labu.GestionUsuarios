using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Aspirante> Aspirante { get; set; }
        public DbSet<DatosContacto> DatosContacto { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Recruiter> Recruiter { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.ToTable("Empresa");
                entity.HasKey(ei => ei.EmpresaId);
                entity.Property(ei => ei.EmpresaId)
                      .ValueGeneratedOnAdd()
                      .IsRequired();
                entity.Property(ui => ui.UsuarioId)
                      .IsRequired();
                entity.Property(l => l.Logo)
                      .IsRequired()
                      .HasMaxLength(255);
                entity.Property(n => n.Nombre)
                      .IsRequired()
                      .HasMaxLength(50);
                entity.Property(p => p.Provincia)
                      .IsRequired()
                      .HasMaxLength(50);
                entity.Property(c => c.Ciudad)
                      .IsRequired()
                      .HasMaxLength(50);
                entity.Property(d => d.Direccion)
                      .IsRequired()
                      .HasMaxLength(50);
                entity.Property(se => se.SectorEmpresarial)
                      .IsRequired()
                      .HasMaxLength(50);
                entity.Property(pw => pw.PaginaWeb)
                      .IsRequired()
                      .HasMaxLength(255);
                entity.Property(d => d.Descripcion)
                      .IsRequired()
                      .HasMaxLength(500);


                entity.HasOne<Usuario>(u => u.Usuario)
                      .WithOne(e => e.Empresa)
                      .HasForeignKey<Empresa>(ui => ui.UsuarioId)
                      .OnDelete(DeleteBehavior.Cascade);


                entity.HasMany<Recruiter>(r => r.Recruiter)
                      .WithOne(e => e.Empresa)
                      .HasForeignKey(ei => ei.EmpresaId)
                      .OnDelete(DeleteBehavior.Cascade);

            });

            modelBuilder.Entity<DatosContacto>(entity =>
            {
                entity.ToTable("DatosContacto");
                entity.HasKey(dci => dci.DatosContactoId);
                entity.Property(dci => dci.DatosContactoId)
                      .ValueGeneratedOnAdd()
                      .IsRequired();
                entity.Property(ei => ei.EmpresaId)
                      .IsRequired();
                entity.Property(n => n.Nombre)
                      .IsRequired()
                      .HasMaxLength(50);
                entity.Property(n => n.Apellido)
                      .IsRequired()
                      .HasMaxLength(50);
                entity.Property(t => t.Telefono)
                      .IsRequired();


                entity.HasOne<Empresa>(e => e.Empresa)
                      .WithOne(dc => dc.DatosContacto)
                      .HasForeignKey<DatosContacto>(ei => ei.EmpresaId);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("Persona");
                entity.HasKey(pi => pi.PersonaId);
                entity.Property(pi => pi.PersonaId)
                      .ValueGeneratedOnAdd()
                      .IsRequired();
                entity.Property(ui => ui.UsuarioId)
                      .IsRequired();
                entity.Property(d => d.DNI)
                      .IsRequired();
                entity.Property(n => n.Nombre)
                      .IsRequired()
                      .HasMaxLength(50);
                entity.Property(n => n.Apellido)
                      .IsRequired()
                      .HasMaxLength(50);
                entity.Property(t => t.Telefono)
                      .IsRequired();
                entity.Property(p => p.Provincia)
                      .IsRequired()
                      .HasMaxLength(50);
                entity.Property(c => c.Ciudad)
                      .IsRequired()
                      .HasMaxLength(50);
                entity.Property(fn => fn.FechaNacimiento)
                      .IsRequired();


                entity.HasOne<Usuario>(u => u.Usuario)
                      .WithOne(p => p.Persona)
                      .HasForeignKey<Persona>(ui => ui.UsuarioId);
            });


            modelBuilder.Entity<Recruiter>(entity =>
            {
                entity.ToTable("Recruiter");
                entity.HasKey(ri => ri.RecruiterId);
                entity.Property(ri => ri.RecruiterId)
                      .ValueGeneratedOnAdd()
                      .IsRequired();
                entity.Property(pi => pi.PersonaId)
                      .IsRequired();
                entity.Property(ei => ei.EmpresaId)
                      .IsRequired();


                entity.HasOne<Persona>(e => e.Persona)
                      .WithOne(r => r.Recruiter)
                      .HasForeignKey<Recruiter>(pi => pi.PersonaId)
                      .OnDelete(DeleteBehavior.NoAction);



                entity.HasOne<Empresa>(e => e.Empresa)
                      .WithMany(r => r.Recruiter)
                      .HasForeignKey(ei => ei.EmpresaId);
            });

            modelBuilder.Entity<Aspirante>(entity =>
            {
                entity.ToTable("Aspirante");
                entity.HasKey(ai => ai.AspiranteId);
                entity.Property(ai => ai.AspiranteId)
                      .ValueGeneratedOnAdd()
                      .IsRequired();
                entity.Property(pi => pi.PersonaId)
                      .IsRequired();


                entity.HasOne<Persona>(e => e.Persona)
                      .WithOne(a => a.Aspirante)
                      .HasForeignKey<Aspirante>(pi => pi.PersonaId);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");
                entity.HasKey(ui => ui.UsuarioId);
                entity.Property(ui => ui.UsuarioId)
                      .ValueGeneratedOnAdd()
                      .IsRequired();
                entity.Property(e => e.Email)
                      .IsRequired()
                      .HasMaxLength(50);
                entity.Property(c => c.Contraseña)
                      .IsRequired()
                      .HasMaxLength(50);
            });
        }

    }
}
