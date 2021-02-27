﻿// <auto-generated />
using System;
using LES.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LES.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210227223358_verificacao")]
    partial class verificacao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LES.Models.Entity.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cid_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("cid_dt_cadastro");

                    b.Property<int>("FK_CID_EST")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cid_nome");

                    b.HasKey("Id")
                        .HasName("PK_CID");

                    b.HasIndex("FK_CID_EST");

                    b.ToTable("CIDADES");
                });

            modelBuilder.Entity("LES.Models.Entity.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cli_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cli_cpf");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("cli_dt_cadastro");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("cli_dt_nascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cli_email");

                    b.Property<int>("FK_CLI_TEL")
                        .HasColumnType("int");

                    b.Property<int>("Genero")
                        .HasColumnType("int")
                        .HasColumnName("cli_genero");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cli_nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cli_senha");

                    b.HasKey("Id")
                        .HasName("PK_CLI");

                    b.HasIndex("FK_CLI_TEL");

                    b.ToTable("CLIENTES");
                });

            modelBuilder.Entity("LES.Models.Entity.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("end_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("end_cep");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("end_complemento");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("end_dt_cadastro");

                    b.Property<bool>("ECobranca")
                        .HasColumnType("bit")
                        .HasColumnName("end_e_cobranca");

                    b.Property<bool>("EEntrega")
                        .HasColumnType("bit")
                        .HasColumnName("end_e_entrega");

                    b.Property<bool>("EResidencia")
                        .HasColumnType("bit")
                        .HasColumnName("end_e_residencia");

                    b.Property<int?>("FK_CLI_END")
                        .HasColumnType("int");

                    b.Property<int>("FK_END_CID")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("end_logradouro");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("end_numero");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("end_observacoes");

                    b.Property<int>("TipoEndereco")
                        .HasColumnType("int")
                        .HasColumnName("end_tipo");

                    b.HasKey("Id")
                        .HasName("PK_END");

                    b.HasIndex("FK_CLI_END");

                    b.HasIndex("FK_END_CID");

                    b.ToTable("ENDERECOS");
                });

            modelBuilder.Entity("LES.Models.Entity.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("est_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("est_dt_cadastro");

                    b.Property<int>("FK_EST_PAI")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("est_nome");

                    b.HasKey("Id")
                        .HasName("PK_EST");

                    b.HasIndex("FK_EST_PAI");

                    b.ToTable("ESTADOS");
                });

            modelBuilder.Entity("LES.Models.Entity.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("pai_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("pai_dt_cadastro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("pai_nome");

                    b.HasKey("Id")
                        .HasName("PK_PAI");

                    b.ToTable("PAISES");
                });

            modelBuilder.Entity("LES.Models.Entity.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tel_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ddd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tel_ddd");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("tel_dt_cadastro");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tel_numero");

                    b.Property<int>("TipoTelefone")
                        .HasColumnType("int")
                        .HasColumnName("tel_tipo");

                    b.HasKey("Id")
                        .HasName("PK_TEL");

                    b.ToTable("TELEFONES");
                });

            modelBuilder.Entity("LES.Models.Entity.Cidade", b =>
                {
                    b.HasOne("LES.Models.Entity.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("FK_CID_EST")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("LES.Models.Entity.Cliente", b =>
                {
                    b.HasOne("LES.Models.Entity.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("FK_CLI_TEL")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Telefone");
                });

            modelBuilder.Entity("LES.Models.Entity.Endereco", b =>
                {
                    b.HasOne("LES.Models.Entity.Cliente", null)
                        .WithMany("Enderecos")
                        .HasForeignKey("FK_CLI_END");

                    b.HasOne("LES.Models.Entity.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("FK_END_CID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("LES.Models.Entity.Estado", b =>
                {
                    b.HasOne("LES.Models.Entity.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("FK_EST_PAI")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("LES.Models.Entity.Cliente", b =>
                {
                    b.Navigation("Enderecos");
                });
#pragma warning restore 612, 618
        }
    }
}
