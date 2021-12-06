﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SsoProject.Admin.EntityFramework.Shared.DbContexts;

namespace SsoProject.Admin.EntityFramework.PostgreSQL.Migrations.AuditLogging
{
    [DbContext(typeof(AdminAuditLogDbContext))]
    partial class AdminAuditLogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Skoruba.AuditLogging.EntityFramework.Entities.AuditLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Action")
                        .HasColumnType("text");

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Data")
                        .HasColumnType("text");

                    b.Property<string>("Event")
                        .HasColumnType("text");

                    b.Property<string>("Source")
                        .HasColumnType("text");

                    b.Property<string>("SubjectAdditionalData")
                        .HasColumnType("text");

                    b.Property<string>("SubjectIdentifier")
                        .HasColumnType("text");

                    b.Property<string>("SubjectName")
                        .HasColumnType("text");

                    b.Property<string>("SubjectType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AuditLog");
                });
#pragma warning restore 612, 618
        }
    }
}








