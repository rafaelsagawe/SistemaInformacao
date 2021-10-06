﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.Data;

namespace Web.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211006150000_Equipamentos-Cameras-1")]
    partial class EquipamentosCameras1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControleAtivosTI.Models.Portifolio", b =>
                {
                    b.Property<int>("IdPortefolio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Acesso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BandoDados")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clientes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoFonte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Criticidade")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documentacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoDesenvolvimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hospedagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linguagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePlataforma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeSistema")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPortefolio");

                    b.ToTable("Portifolios");
                });

            modelBuilder.Entity("EquipamentosUnidades", b =>
                {
                    b.Property<int>("EquipamentosIdEquipamento")
                        .HasColumnType("int");

                    b.Property<int>("UnidadesIdUE")
                        .HasColumnType("int");

                    b.HasKey("EquipamentosIdEquipamento", "UnidadesIdUE");

                    b.HasIndex("UnidadesIdUE");

                    b.ToTable("EquipamentosUnidades");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Web.Models.Equipamentos", b =>
                {
                    b.Property<int>("IdEquipamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EquipDescricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipNuControle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipNuSerie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipOrigem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipTipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EquipValor")
                        .HasColumnType("int");

                    b.Property<int>("IdUE")
                        .HasColumnType("int");

                    b.HasKey("IdEquipamento");

                    b.ToTable("Equipamentos");
                });

            modelBuilder.Entity("Web.Models.Linha", b =>
                {
                    b.Property<int>("IdLinha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumeroLinha")
                        .HasColumnType("int");

                    b.Property<int?>("RamalidRamal")
                        .HasColumnType("int");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.Property<int>("Tronco")
                        .HasColumnType("int");

                    b.HasKey("IdLinha");

                    b.HasIndex("RamalidRamal");

                    b.ToTable("Linha");
                });

            modelBuilder.Entity("Web.Models.Ramal", b =>
                {
                    b.Property<int>("idRamal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IP")
                        .HasColumnType("int");

                    b.Property<int>("IdLinha")
                        .HasColumnType("int");

                    b.Property<string>("MACAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("localizacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idRamal");

                    b.ToTable("Ramal");
                });

            modelBuilder.Entity("Web.Models.SupImp", b =>
                {
                    b.Property<int>("IdSupImp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ModeloToner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QtdImpressoas")
                        .HasColumnType("int");

                    b.Property<int>("QtdToner")
                        .HasColumnType("int");

                    b.HasKey("IdSupImp");

                    b.ToTable("SupImp");
                });

            modelBuilder.Entity("Web.Models.Unidades", b =>
                {
                    b.Property<int>("IdUE")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CEP")
                        .HasColumnType("int");

                    b.Property<int>("CNPJ")
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("INEP")
                        .HasColumnType("int");

                    b.Property<int>("NProtocolo")
                        .HasColumnType("int");

                    b.Property<string>("NomeUE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UETel")
                        .HasColumnType("int");

                    b.Property<string>("URG")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUE");

                    b.ToTable("Unidades");
                });

            modelBuilder.Entity("EquipamentosUnidades", b =>
                {
                    b.HasOne("Web.Models.Equipamentos", null)
                        .WithMany()
                        .HasForeignKey("EquipamentosIdEquipamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Web.Models.Unidades", null)
                        .WithMany()
                        .HasForeignKey("UnidadesIdUE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Web.Models.Linha", b =>
                {
                    b.HasOne("Web.Models.Ramal", null)
                        .WithMany("Linhas")
                        .HasForeignKey("RamalidRamal");
                });

            modelBuilder.Entity("Web.Models.Ramal", b =>
                {
                    b.Navigation("Linhas");
                });
#pragma warning restore 612, 618
        }
    }
}
