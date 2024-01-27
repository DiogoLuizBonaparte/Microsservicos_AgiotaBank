﻿// <auto-generated />
using BancoStandard.ClientAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BancoStandard.CadastroAPI.Migrations
{
    [DbContext(typeof(SQLContext))]
    [Migration("20240127002154_SeedCliente")]
    partial class SeedCliente
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BancoStandard.ClientAPI.Model.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.Property<string>("Profissao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("profissao");

                    b.HasKey("Id");

                    b.ToTable("cliente");

                    b.HasData(
                        new
                        {
                            Id = 3L,
                            Name = "Napoleão Bonaparte",
                            Profissao = "Imperador"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Edmond Safra",
                            Profissao = "Banqueiro"
                        },
                        new
                        {
                            Id = 5L,
                            Name = "Geroge H. Bush",
                            Profissao = "Político"
                        },
                        new
                        {
                            Id = 6L,
                            Name = "John Rockefeller",
                            Profissao = "Industrial"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
