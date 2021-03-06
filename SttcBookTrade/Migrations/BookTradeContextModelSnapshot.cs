﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SttcBookTrade.Entities;

namespace SttcBookTrade.Migrations
{
    [DbContext(typeof(BookTradeContext))]
    partial class BookTradeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SttcBookTrade.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("Condition")
                        .HasMaxLength(50);

                    b.Property<string>("Edition")
                        .IsRequired();

                    b.Property<string>("ISBN10");

                    b.Property<string>("ISBN13");

                    b.Property<bool>("IsWishlisted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Notes");

                    b.Property<int>("Price");

                    b.Property<int?>("TradeId");

                    b.Property<int>("UserId");

                    b.HasKey("BookId");

                    b.HasIndex("TradeId");

                    b.HasIndex("UserId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("SttcBookTrade.Entities.BookTradeLink", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("TradeId");

                    b.HasKey("BookId", "TradeId");

                    b.HasIndex("TradeId");

                    b.ToTable("BookTradeLink");
                });

            modelBuilder.Entity("SttcBookTrade.Entities.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Info");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Website");

                    b.HasKey("SchoolId");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("SttcBookTrade.Entities.Trade", b =>
                {
                    b.Property<int>("TradeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OffererUserId");

                    b.Property<int>("ReceiverUserId");

                    b.HasKey("TradeId");

                    b.HasIndex("OffererUserId");

                    b.HasIndex("ReceiverUserId");

                    b.ToTable("Trade");
                });

            modelBuilder.Entity("SttcBookTrade.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(254);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Profile");

                    b.Property<int>("SchoolId");

                    b.Property<string>("StudentIdentification");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("UserId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SttcBookTrade.Entities.Book", b =>
                {
                    b.HasOne("SttcBookTrade.Entities.Trade")
                        .WithMany("Books")
                        .HasForeignKey("TradeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SttcBookTrade.Entities.User", "User")
                        .WithMany("Books")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SttcBookTrade.Entities.BookTradeLink", b =>
                {
                    b.HasOne("SttcBookTrade.Entities.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SttcBookTrade.Entities.Trade", "Trade")
                        .WithMany()
                        .HasForeignKey("TradeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SttcBookTrade.Entities.Trade", b =>
                {
                    b.HasOne("SttcBookTrade.Entities.User", "OffererUser")
                        .WithMany()
                        .HasForeignKey("OffererUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SttcBookTrade.Entities.User", "ReceiverUser")
                        .WithMany()
                        .HasForeignKey("ReceiverUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SttcBookTrade.Entities.User", b =>
                {
                    b.HasOne("SttcBookTrade.Entities.School", "School")
                        .WithMany("Users")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
