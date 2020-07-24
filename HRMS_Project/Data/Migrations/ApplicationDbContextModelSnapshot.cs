﻿// <auto-generated />
using System;
using HRMS_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HRMS_Project.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HRMS_Project.Models.AbsenceType", b =>
                {
                    b.Property<int>("IdAbsenceType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AbsenceTypeName")
                        .IsRequired()
                        .HasColumnName("AbsenceTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAbsenceType")
                        .HasName("AbsenceType_pk");

                    b.ToTable("AbsenceType");
                });

            modelBuilder.Entity("HRMS_Project.Models.AvailableAbsence", b =>
                {
                    b.Property<int>("IdAvailableAbsence")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvailableDays")
                        .HasColumnType("int");

                    b.Property<int>("IdAbsenceType")
                        .HasColumnType("int");

                    b.Property<string>("IdEmployee")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UsedAbsence")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("IdAvailableAbsence")
                        .HasName("AvailableAbsence_pk");

                    b.HasIndex("IdAbsenceType");

                    b.HasIndex("IdEmployee");

                    b.ToTable("AvailableAbsence");
                });

            modelBuilder.Entity("HRMS_Project.Models.Benefit", b =>
                {
                    b.Property<int>("IdBenefit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6, 2)");

                    b.HasKey("IdBenefit")
                        .HasName("Benefit_pk");

                    b.ToTable("Benefit");
                });

            modelBuilder.Entity("HRMS_Project.Models.Contract", b =>
                {
                    b.Property<int>("IdContract")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ContractEnd")
                        .HasColumnType("date");

                    b.Property<int>("ContractNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("ContractStart")
                        .HasColumnType("date");

                    b.Property<int>("IdContractStatus")
                        .HasColumnType("int");

                    b.Property<int>("IdContractType")
                        .HasColumnType("int");

                    b.Property<string>("IdEmployee")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("IdContract")
                        .HasName("Contract_pk");

                    b.HasIndex("IdContractStatus");

                    b.HasIndex("IdContractType");

                    b.HasIndex("IdEmployee");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("HRMS_Project.Models.ContractBenefit", b =>
                {
                    b.Property<int>("IdBenefitContract")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdBenefit")
                        .HasColumnName("IdBenefit")
                        .HasColumnType("int");

                    b.Property<int>("IdContract")
                        .HasColumnName("IdContract")
                        .HasColumnType("int");

                    b.Property<int?>("BenefitIdBenefit")
                        .HasColumnType("int");

                    b.Property<int?>("ContractIdContract")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("IdBenefitContract", "IdBenefit", "IdContract")
                        .HasName("ContractBenefit_pk");

                    b.HasIndex("BenefitIdBenefit");

                    b.HasIndex("ContractIdContract");

                    b.ToTable("ContractBenefit");
                });

            modelBuilder.Entity("HRMS_Project.Models.ContractStatus", b =>
                {
                    b.Property<int>("IdContractStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdContractStatus")
                        .HasName("ContractStatus_pk");

                    b.ToTable("ContractStatus");
                });

            modelBuilder.Entity("HRMS_Project.Models.ContractType", b =>
                {
                    b.Property<int>("IdContractType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContractTypeName")
                        .IsRequired()
                        .HasColumnName("ContractType")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdContractType")
                        .HasName("ContractType_pk");

                    b.ToTable("ContractType");
                });

            modelBuilder.Entity("HRMS_Project.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("IdCardNumber")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<int>("IdEmployee")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdJob")
                        .HasColumnType("int");

                    b.Property<int?>("IdManager")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesel")
                        .IsRequired()
                        .HasColumnName("PESEL")
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
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

            modelBuilder.Entity("HRMS_Project.Models.Job", b =>
                {
                    b.Property<int>("IdJob")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdJob")
                        .HasName("Job_pk");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("HRMS_Project.Models.Request", b =>
                {
                    b.Property<int>("IdRequest")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("IdEmployee")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IdRequestStatus")
                        .HasColumnType("int");

                    b.Property<int>("IdRequestType")
                        .HasColumnType("int");

                    b.Property<string>("ManagerComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("date");

                    b.Property<int>("RequestNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("IdRequest")
                        .HasName("Request_pk");

                    b.HasIndex("IdEmployee");

                    b.HasIndex("IdRequestStatus");

                    b.HasIndex("IdRequestType");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("HRMS_Project.Models.RequestStatus", b =>
                {
                    b.Property<int>("IdRequestStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdRequestStatus")
                        .HasName("RequestStatus_pk");

                    b.ToTable("RequestStatus");
                });

            modelBuilder.Entity("HRMS_Project.Models.RequestType", b =>
                {
                    b.Property<int>("IdRequestType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RequestTypeName")
                        .IsRequired()
                        .HasColumnName("RequestType")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdRequestType")
                        .HasName("RequestType_pk");

                    b.ToTable("RequestType");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HRMS_Project.Models.AvailableAbsence", b =>
                {
                    b.HasOne("HRMS_Project.Models.AbsenceType", "IdAbsenceTypeNavigation")
                        .WithMany("AvailableAbsence")
                        .HasForeignKey("IdAbsenceType")
                        .HasConstraintName("AvailableAbsence_AbsenceType")
                        .IsRequired();

                    b.HasOne("HRMS_Project.Models.Employee", "IdEmployeeNavigation")
                        .WithMany("AvailableAbsence")
                        .HasForeignKey("IdEmployee")
                        .HasConstraintName("AvailableAbsence_Emp")
                        .IsRequired();
                });

            modelBuilder.Entity("HRMS_Project.Models.Contract", b =>
                {
                    b.HasOne("HRMS_Project.Models.ContractStatus", "IdContractStatusNavigation")
                        .WithMany("Contract")
                        .HasForeignKey("IdContractStatus")
                        .HasConstraintName("Contract_ContractStatus")
                        .IsRequired();

                    b.HasOne("HRMS_Project.Models.ContractType", "IdContractTypeNavigation")
                        .WithMany("Contract")
                        .HasForeignKey("IdContractType")
                        .HasConstraintName("Contract_ContractType")
                        .IsRequired();

                    b.HasOne("HRMS_Project.Models.Employee", "IdEmployeeNavigation")
                        .WithMany("Contract")
                        .HasForeignKey("IdEmployee")
                        .HasConstraintName("Contract_Employee");
                });

            modelBuilder.Entity("HRMS_Project.Models.ContractBenefit", b =>
                {
                    b.HasOne("HRMS_Project.Models.Benefit", "Benefit")
                        .WithMany("ContractBenefit")
                        .HasForeignKey("BenefitIdBenefit");

                    b.HasOne("HRMS_Project.Models.Contract", "Contract")
                        .WithMany("ContractBenefit")
                        .HasForeignKey("ContractIdContract");
                });

            modelBuilder.Entity("HRMS_Project.Models.Request", b =>
                {
                    b.HasOne("HRMS_Project.Models.Employee", "IdEmployeeNavigation")
                        .WithMany("Request")
                        .HasForeignKey("IdEmployee")
                        .HasConstraintName("Request_Employee");

                    b.HasOne("HRMS_Project.Models.RequestStatus", "IdRequestStatusNavigation")
                        .WithMany("Request")
                        .HasForeignKey("IdRequestStatus")
                        .HasConstraintName("Request_RequestStatus")
                        .IsRequired();

                    b.HasOne("HRMS_Project.Models.RequestType", "IdRequestTypeNavigation")
                        .WithMany("Request")
                        .HasForeignKey("IdRequestType")
                        .HasConstraintName("Request_RequestType")
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
                    b.HasOne("HRMS_Project.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HRMS_Project.Models.Employee", null)
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

                    b.HasOne("HRMS_Project.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HRMS_Project.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
