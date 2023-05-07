﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StremioProjetos.MODEL;

public partial class CUsersAdminSourceReposStremioprojetosStremioprojetosDalDatabaseDatabaseMdfContext : DbContext
{
    public CUsersAdminSourceReposStremioprojetosStremioprojetosDalDatabaseDatabaseMdfContext()
    {
    }

    public CUsersAdminSourceReposStremioprojetosStremioprojetosDalDatabaseDatabaseMdfContext(DbContextOptions<CUsersAdminSourceReposStremioprojetosStremioprojetosDalDatabaseDatabaseMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Projeto> Projetos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\StremioProjetos\\StremioProjetos.DAL\\database\\database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Projeto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Projeto__3214EC0762608521");

            entity.ToTable("Projeto");

            entity.Property(e => e.DataFinal).HasColumnType("date");
            entity.Property(e => e.DataInicio).HasColumnType("date");
            entity.Property(e => e.Gerente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Resumo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
