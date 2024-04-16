﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XML.Context;

#nullable disable

namespace XML.Migrations
{
    [DbContext(typeof(Contextt))]
    [Migration("20231127134032_cn")]
    partial class cn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("XML.Entity.CountryInfo", b =>
                {
                    b.Property<string>("sCapitalCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sContinentCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sCountryFlag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sCurrencyISOCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sISOCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sPhoneCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("CountryInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
