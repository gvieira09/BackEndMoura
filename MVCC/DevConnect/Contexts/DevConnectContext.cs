using System;
using System.Collections.Generic;
using DevConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Contexts;

public partial class DevConnectContext : DbContext
{
    public DevConnectContext()
    {
    }

    public DevConnectContext(DbContextOptions<DevConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbComentarios> TbComentarios { get; set; }

    public virtual DbSet<TbCurtidas> TbCurtidas { get; set; }

    public virtual DbSet<TbPubli> TbPubli { get; set; }

    public virtual DbSet<TbUsuario> TbUsuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DevCon_Windows");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbComentarios>(entity =>
        {
            entity.HasKey(e => e.IdComentarios).HasName("PK__tb_comen__2D23FC7C83A028FC");

            entity.HasOne(d => d.IdPubliNavigation).WithMany(p => p.TbComentarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_coment__ID_Pu__5535A963");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbComentarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_coment__ID_Pu__5441852A");
        });

        modelBuilder.Entity<TbCurtidas>(entity =>
        {
            entity.HasKey(e => e.IdCurtidas).HasName("PK__tb_curti__EDCB91054CFD8C15");

            entity.HasOne(d => d.IdPubliNavigation).WithMany(p => p.TbCurtidas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_curtid__ID_Pu__5165187F");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbCurtidas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_curtid__ID_Pu__5070F446");
        });

        modelBuilder.Entity<TbPubli>(entity =>
        {
            entity.HasKey(e => e.IdPubli).HasName("PK__tb_publi__5A27A42FC3DFEDF5");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbPubli).HasConstraintName("FK__tb_publi__ID_Usu__4D94879B");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__tb_usuar__DE4431C591CD6BD1");

            entity.HasMany(d => d.IdUsuarioNavigation).WithMany(p => p.IdUsuarioSeguidor)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__ID_Us__59063A47"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguidor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__ID_Us__5812160E"),
                    j =>
                    {
                        j.HasKey("IdUsuarioSeguidor", "IdUsuario").HasName("PK__tb_segui__7657448F6D46B276");
                        j.ToTable("tb_seguidor");
                        j.IndexerProperty<int>("IdUsuarioSeguidor").HasColumnName("ID_UsuarioSeguidor");
                        j.IndexerProperty<int>("IdUsuario").HasColumnName("ID_Usuario");
                    });

            entity.HasMany(d => d.IdUsuarioSeguidor).WithMany(p => p.IdUsuarioNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguidor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__ID_Us__5812160E"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__ID_Us__59063A47"),
                    j =>
                    {
                        j.HasKey("IdUsuarioSeguidor", "IdUsuario").HasName("PK__tb_segui__7657448F6D46B276");
                        j.ToTable("tb_seguidor");
                        j.IndexerProperty<int>("IdUsuarioSeguidor").HasColumnName("ID_UsuarioSeguidor");
                        j.IndexerProperty<int>("IdUsuario").HasColumnName("ID_Usuario");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
