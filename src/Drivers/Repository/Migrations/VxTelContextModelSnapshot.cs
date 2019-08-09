﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using vxTel.Repository.Context;

namespace vxTel.Repository.Migrations
{
    [DbContext(typeof(VxTelContext))]
    partial class VxTelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("vxTel.Domain.Entities.PlanoTelefonia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ChangedAT")
                        .HasColumnName("PDATA_ALTERACAO")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("CreateAT")
                        .HasColumnName("PDATA_CRIACAO")
                        .HasColumnType("DATETIME");

                    b.Property<Guid>("Guid")
                        .HasColumnName("PHASHCODE");

                    b.Property<decimal>("PrecoPorMinuto")
                        .HasColumnName("PPRECO_MINUTO")
                        .HasColumnType("decimal(3,2)");

                    b.Property<int>("TipoPlano")
                        .HasColumnName("PTIPO_PLANO");

                    b.HasKey("Id");

                    b.ToTable("PlanoTelefonia");
                });

            modelBuilder.Entity("vxTel.Domain.Entities.PlanoTelefonia", b =>
                {
                    b.OwnsOne("vxTel.Domain.ValueObjects.DDD", "Destino", b1 =>
                        {
                            b1.Property<int>("PlanoTelefoniaId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Code")
                                .HasColumnName("PDDD_DESTINO");

                            b1.HasKey("PlanoTelefoniaId");

                            b1.ToTable("PlanoTelefonia");

                            b1.HasOne("vxTel.Domain.Entities.PlanoTelefonia")
                                .WithOne("Destino")
                                .HasForeignKey("vxTel.Domain.ValueObjects.DDD", "PlanoTelefoniaId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("vxTel.Domain.ValueObjects.DDD", "Origem", b1 =>
                        {
                            b1.Property<int>("PlanoTelefoniaId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Code")
                                .HasColumnName("PDDD_ORIGEM");

                            b1.HasKey("PlanoTelefoniaId");

                            b1.ToTable("PlanoTelefonia");

                            b1.HasOne("vxTel.Domain.Entities.PlanoTelefonia")
                                .WithOne("Origem")
                                .HasForeignKey("vxTel.Domain.ValueObjects.DDD", "PlanoTelefoniaId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}