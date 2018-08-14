﻿// <auto-generated />
using System;
using DemoDB.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoDB.Migrations
{
    [DbContext(typeof(DemoDbContext))]
    [Migration("20180813115518_thirdCreate")]
    partial class thirdCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoDB.Model.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BillName");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("CreatorId");

                    b.Property<int>("GroupId");

                    b.Property<byte[]>("Image");

                    b.HasKey("BillId");

                    b.HasIndex("GroupId");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("DemoDB.Model.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("CreatorId");

                    b.Property<string>("GroupName");

                    b.HasKey("GroupId");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("DemoDB.Model.GroupMember", b =>
                {
                    b.Property<int>("GroupMemberId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Group_Id");

                    b.Property<int>("User_Id");

                    b.HasKey("GroupMemberId");

                    b.HasIndex("Group_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("GroupMember");
                });

            modelBuilder.Entity("DemoDB.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DemoDB.Model.Bill", b =>
                {
                    b.HasOne("DemoDB.Model.Group", "Group")
                        .WithMany("Bills")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DemoDB.Model.GroupMember", b =>
                {
                    b.HasOne("DemoDB.Model.Group", "Group")
                        .WithMany("groupMembers")
                        .HasForeignKey("Group_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoDB.Model.User", "User")
                        .WithMany("groupMembers")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}