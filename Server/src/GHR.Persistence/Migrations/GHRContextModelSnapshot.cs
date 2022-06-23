﻿// <auto-generated />
using System;
using GHR.Persistence.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GHR.Persistence.Migrations
{
    [DbContext(typeof(GHRContext))]
    partial class GHRContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("GHR.Domain.DataBase.Cargos.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataEncerramento")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Funcao")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeCargo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Contas.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<bool>("Ativa")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Cadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Encerramento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ImagemURL")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Visao")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Contas.ContaFuncao", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Contas.Funcao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NomeFuncao")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Departamentos.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataHoraCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataHoraEncerramento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Diretor")
                        .HasColumnType("longtext");

                    b.Property<string>("Gerente")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeDepartamento")
                        .HasColumnType("longtext");

                    b.Property<string>("SiglaDepartamento")
                        .HasColumnType("longtext");

                    b.Property<string>("Supervisor")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Empresas.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativa")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("Desativacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Filial")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Logotipo")
                        .HasColumnType("longtext");

                    b.Property<int?>("MatrizId")
                        .HasColumnType("int");

                    b.Property<string>("NomeEmpresa")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("longtext");

                    b.Property<string>("SiglaEmpresa")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("MatrizId");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Empresas.EmpresaConta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ContasId")
                        .HasColumnType("int");

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ContasId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("EmpresasContas");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Funcionarios.DadoPessoal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext");

                    b.Property<string>("CarteiraTrabalho")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataExpedicaoCarteiraTrabalho")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataExpedicaoIdentidade")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("longtext");

                    b.Property<string>("Identidade")
                        .HasColumnType("longtext");

                    b.Property<string>("OrgaoExpedicaoIdentidade")
                        .HasColumnType("longtext");

                    b.Property<string>("TituloEleitor")
                        .HasColumnType("longtext");

                    b.Property<string>("UfIdentidade")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DadosPessoais");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Funcionarios.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasColumnType("longtext");

                    b.Property<string>("CEP")
                        .HasColumnType("longtext");

                    b.Property<string>("CaixaPostal")
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext");

                    b.Property<string>("Complemento")
                        .HasColumnType("longtext");

                    b.Property<string>("ComplementoEndereco")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataHoraCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<string>("Pais")
                        .HasColumnType("longtext");

                    b.Property<string>("UF")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Funcionarios.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("CargoId")
                        .HasColumnType("int");

                    b.Property<int?>("ContaId")
                        .HasColumnType("int");

                    b.Property<int?>("DadosPessoaisId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataDemissao")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<float>("Salario")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.HasIndex("ContaId");

                    b.HasIndex("DadosPessoaisId");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Funcionarios.FuncionarioMeta", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<int>("MetaId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartamentosId")
                        .HasColumnType("int");

                    b.Property<string>("FimAcordado")
                        .HasColumnType("longtext");

                    b.Property<string>("FimRealizado")
                        .HasColumnType("longtext");

                    b.Property<string>("InicioAcordado")
                        .HasColumnType("longtext");

                    b.Property<string>("InicioRealizado")
                        .HasColumnType("longtext");

                    b.Property<bool>("MetaCumprida")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Supervisor")
                        .HasColumnType("longtext");

                    b.HasKey("FuncionarioId", "MetaId");

                    b.HasIndex("DepartamentosId");

                    b.HasIndex("MetaId");

                    b.ToTable("FuncionariosMetas");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Metas.Meta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("FimPlanejado")
                        .HasColumnType("longtext");

                    b.Property<string>("FimRealizado")
                        .HasColumnType("longtext");

                    b.Property<string>("InicioPlanejado")
                        .HasColumnType("longtext");

                    b.Property<string>("InicioRealizado")
                        .HasColumnType("longtext");

                    b.Property<bool>("MetaAprovada")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("MetaCumprida")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NomeMeta")
                        .HasColumnType("longtext");

                    b.Property<string>("Supervisor")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Metas");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Cargos.Cargo", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Departamentos.Departamento", "Departamentos")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Contas.ContaFuncao", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Contas.Funcao", "Funcoes")
                        .WithMany("ContasFuncoes")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GHR.Domain.DataBase.Contas.Conta", "Contas")
                        .WithMany("ContasFuncoes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contas");

                    b.Navigation("Funcoes");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Empresas.EmpresaConta", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Contas.Conta", "Contas")
                        .WithMany("EmpresasContas")
                        .HasForeignKey("ContasId");

                    b.HasOne("GHR.Domain.DataBase.Empresas.Empresa", "Empresas")
                        .WithMany("EmpresasContas")
                        .HasForeignKey("EmpresaId");

                    b.Navigation("Contas");

                    b.Navigation("Empresas");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Funcionarios.Funcionario", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Cargos.Cargo", "Cargos")
                        .WithMany()
                        .HasForeignKey("CargoId");

                    b.HasOne("GHR.Domain.DataBase.Contas.Conta", "Contas")
                        .WithMany()
                        .HasForeignKey("ContaId");

                    b.HasOne("GHR.Domain.DataBase.Funcionarios.DadoPessoal", "DadosPessoais")
                        .WithMany()
                        .HasForeignKey("DadosPessoaisId");

                    b.HasOne("GHR.Domain.DataBase.Departamentos.Departamento", "Departamentos")
                        .WithMany()
                        .HasForeignKey("DepartamentoId");

                    b.HasOne("GHR.Domain.DataBase.Funcionarios.Endereco", "Enderecos")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.Navigation("Cargos");

                    b.Navigation("Contas");

                    b.Navigation("DadosPessoais");

                    b.Navigation("Departamentos");

                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Funcionarios.FuncionarioMeta", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Departamentos.Departamento", "Departamentos")
                        .WithMany()
                        .HasForeignKey("DepartamentosId");

                    b.HasOne("GHR.Domain.DataBase.Funcionarios.Funcionario", "Funcionarios")
                        .WithMany("FuncionariosMetas")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GHR.Domain.DataBase.Metas.Meta", "Metas")
                        .WithMany("FuncionariosMetas")
                        .HasForeignKey("MetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamentos");

                    b.Navigation("Funcionarios");

                    b.Navigation("Metas");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Contas.Funcao", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Contas.Conta", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Contas.Conta", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Contas.Conta", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Contas.Conta", b =>
                {
                    b.Navigation("ContasFuncoes");

                    b.Navigation("EmpresasContas");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Contas.Funcao", b =>
                {
                    b.Navigation("ContasFuncoes");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Empresas.Empresa", b =>
                {
                    b.Navigation("EmpresasContas");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Funcionarios.Funcionario", b =>
                {
                    b.Navigation("FuncionariosMetas");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Metas.Meta", b =>
                {
                    b.Navigation("FuncionariosMetas");
                });
#pragma warning restore 612, 618
        }
    }
}