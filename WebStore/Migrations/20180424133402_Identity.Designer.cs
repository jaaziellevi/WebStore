﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebStore.Data;

namespace WebStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180424133402_Identity")]
    partial class Identity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebStore.Data.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoriaNome");

                    b.Property<string>("Descricao");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("WebStore.Data.Models.Compra", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Complemento");

                    b.Property<DateTime>("DataCompra");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("PrimeiroNome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<decimal>("TotalCompra");

                    b.HasKey("CompraId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("WebStore.Data.Models.DetalhesCompra", b =>
                {
                    b.Property<int>("DetalhesCompraId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompraId");

                    b.Property<decimal>("Preco");

                    b.Property<int>("Quantidade");

                    b.Property<int>("RoupaId");

                    b.HasKey("DetalhesCompraId");

                    b.HasIndex("CompraId");

                    b.HasIndex("RoupaId");

                    b.ToTable("DetalhesCompras");
                });

            modelBuilder.Entity("WebStore.Data.Models.ItemDoCarrinho", b =>
                {
                    b.Property<int>("ItemDoCarrinhoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarrinhoDeComprasId");

                    b.Property<int>("Quantidade");

                    b.Property<int?>("RoupaId");

                    b.HasKey("ItemDoCarrinhoId");

                    b.HasIndex("RoupaId");

                    b.ToTable("ItensDoCarrinho");
                });

            modelBuilder.Entity("WebStore.Data.Models.Roupa", b =>
                {
                    b.Property<int>("RoupaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaId");

                    b.Property<string>("DescricaoLonga");

                    b.Property<string>("DescricaoPequena");

                    b.Property<string>("ImagemThumbnailUrl");

                    b.Property<string>("ImagemUrl");

                    b.Property<bool>("InStock");

                    b.Property<string>("Name");

                    b.Property<decimal>("Preco");

                    b.Property<bool>("RoupaPrefirada");

                    b.HasKey("RoupaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Roupas");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebStore.Data.Models.DetalhesCompra", b =>
                {
                    b.HasOne("WebStore.Data.Models.Compra", "Compra")
                        .WithMany("Compras")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebStore.Data.Models.Roupa", "Roupa")
                        .WithMany()
                        .HasForeignKey("RoupaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebStore.Data.Models.ItemDoCarrinho", b =>
                {
                    b.HasOne("WebStore.Data.Models.Roupa", "Roupa")
                        .WithMany()
                        .HasForeignKey("RoupaId");
                });

            modelBuilder.Entity("WebStore.Data.Models.Roupa", b =>
                {
                    b.HasOne("WebStore.Data.Models.Categoria", "Categoria")
                        .WithMany("Roupas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
