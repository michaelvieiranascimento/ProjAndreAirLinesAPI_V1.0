﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjAndreAirLinesAPI_V1._0.Data;

namespace ProjAndreAirLinesAPI_V1._0.Migrations
{
    [DbContext(typeof(ProjAndreAirLinesAPI_V1_0Context))]
    partial class ProjAndreAirLinesAPI_V1_0ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjAndreAirLinesAPI_V1._0.Model.Aeronave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacidade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aeronave");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V1._0.Model.Aeroporto", b =>
                {
                    b.Property<string>("Sigla")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sigla");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Aeroporto");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V1._0.Model.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V1._0.Model.Passageiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nome");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Passageiro");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V1._0.Model.Voo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AernaveId")
                        .HasColumnType("int");

                    b.Property<string>("AeroportoDestinoSigla")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AeroportoOrigemSigla")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("HorarioDesembarque")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioEmbarque")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PassageiroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AernaveId");

                    b.HasIndex("AeroportoDestinoSigla");

                    b.HasIndex("AeroportoOrigemSigla");

                    b.HasIndex("PassageiroId");

                    b.ToTable("Voo");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V1._0.Model.Aeroporto", b =>
                {
                    b.HasOne("ProjAndreAirLinesAPI_V1._0.Model.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V1._0.Model.Passageiro", b =>
                {
                    b.HasOne("ProjAndreAirLinesAPI_V1._0.Model.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V1._0.Model.Voo", b =>
                {
                    b.HasOne("ProjAndreAirLinesAPI_V1._0.Model.Aeronave", "Aernave")
                        .WithMany()
                        .HasForeignKey("AernaveId");

                    b.HasOne("ProjAndreAirLinesAPI_V1._0.Model.Aeroporto", "AeroportoDestino")
                        .WithMany()
                        .HasForeignKey("AeroportoDestinoSigla");

                    b.HasOne("ProjAndreAirLinesAPI_V1._0.Model.Aeroporto", "AeroportoOrigem")
                        .WithMany()
                        .HasForeignKey("AeroportoOrigemSigla");

                    b.HasOne("ProjAndreAirLinesAPI_V1._0.Model.Passageiro", "Passageiro")
                        .WithMany()
                        .HasForeignKey("PassageiroId");

                    b.Navigation("Aernave");

                    b.Navigation("AeroportoDestino");

                    b.Navigation("AeroportoOrigem");

                    b.Navigation("Passageiro");
                });
#pragma warning restore 612, 618
        }
    }
}
