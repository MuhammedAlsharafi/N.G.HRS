﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace N.G.HRS.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "additionalAccountInformation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PercentageOnTheCompany = table.Column<int>(type: "int", nullable: false),
                    PercentageOnTheEmployee = table.Column<int>(type: "int", nullable: false),
                    percentage = table.Column<int>(type: "int", nullable: false),
                    HealthInsuranceIncluded = table.Column<bool>(type: "bit", nullable: false),
                    IncludesRetirementInsurance = table.Column<bool>(type: "bit", nullable: false),
                    IncludesTheWorkShareInRetirementInsurance = table.Column<bool>(type: "bit", nullable: false),
                    IncludesTaxCalculation = table.Column<bool>(type: "bit", nullable: false),
                    AllowancesIncluded = table.Column<bool>(type: "bit", nullable: false),
                    IncludesAdditionalData = table.Column<bool>(type: "bit", nullable: false),
                    TaxFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day = table.Column<DateOnly>(type: "date", nullable: false),
                    FromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ToDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_additionalAccountInformation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "allowancesAndDiscounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Taxable = table.Column<bool>(type: "bit", nullable: false),
                    AddedToAllEmployees = table.Column<bool>(type: "bit", nullable: false),
                    CumulativeAllowance = table.Column<bool>(type: "bit", nullable: false),
                    SubjectToInsurance = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_allowancesAndDiscounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    dwVerifyMode = table.Column<int>(type: "int", nullable: false),
                    dwInOutMode = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.AttendanceId);
                });

            migrationBuilder.CreateTable(
                name: "basicDataForTheSalaryStatements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthInsuranceIncluded = table.Column<bool>(type: "bit", nullable: false),
                    RetirementInsuranceIncluded = table.Column<bool>(type: "bit", nullable: false),
                    IncludesTheWorkShareInRetirementInsurance = table.Column<bool>(type: "bit", nullable: false),
                    IncludesTaxCalculation = table.Column<bool>(type: "bit", nullable: false),
                    TaxFrom = table.Column<bool>(type: "bit", nullable: false),
                    AllowancesIncluded = table.Column<bool>(type: "bit", nullable: false),
                    IncludesAdditionalData = table.Column<bool>(type: "bit", nullable: false),
                    FromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ToDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Percentage = table.Column<int>(type: "int", nullable: false),
                    PercentageOnEmployee = table.Column<int>(type: "int", nullable: false),
                    PercentageOnCompany = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_basicDataForTheSalaryStatements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "basicDataForWagesAndSalaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfMonthsDays = table.Column<int>(type: "int", nullable: false),
                    AbsencePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DelayPerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OneFingerPrintPerHourDelay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ToDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TypeOfWage = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_basicDataForWagesAndSalaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contracts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CurrencyNotes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CurrentPriceOfCurrency = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PreviousPriceOfCurrency = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "educationalQualifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_educationalQualifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinanceAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceAccount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinanceAccountType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceAccountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "fingerprintDevices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DevicesName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DeviceType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeviceStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ConnectionType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfPurchase = table.Column<DateOnly>(type: "date", nullable: false),
                    VendorName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    VendorPhon = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    VendorAdress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ManufactureCompany = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DeviceSpecifications = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsConnected = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fingerprintDevices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "functionalFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_functionalFiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "jobRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RankName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobRanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "maritalStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maritalStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "membershipOfTheBoardOfs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOFMembership = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_membershipOfTheBoardOfs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "months",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<DateOnly>(type: "date", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Closed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_months", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nationality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalityName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nationality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "officialVacations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacationsName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ToDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_officialVacations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "periods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeriodsName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FromTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Saturday = table.Column<bool>(type: "bit", nullable: false),
                    SunDay = table.Column<bool>(type: "bit", nullable: false),
                    Monday = table.Column<bool>(type: "bit", nullable: false),
                    Tuesday = table.Column<bool>(type: "bit", nullable: false),
                    Wednesday = table.Column<bool>(type: "bit", nullable: false),
                    Thursday = table.Column<bool>(type: "bit", nullable: false),
                    Friday = table.Column<bool>(type: "bit", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_periods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "permanenceModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermanenceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ToDate = table.Column<DateOnly>(type: "date", nullable: false),
                    FlexibleWorkingHours = table.Column<bool>(type: "bit", nullable: false),
                    WorkBetweenTwoShifts = table.Column<bool>(type: "bit", nullable: false),
                    ShiftTime = table.Column<bool>(type: "bit", nullable: false),
                    Working24Hours = table.Column<bool>(type: "bit", nullable: false),
                    FromTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoursOfWorks = table.Column<int>(type: "int", nullable: true),
                    AddAttendanceAndDeparturePermission = table.Column<bool>(type: "bit", nullable: false),
                    AllowanceForLateAttendance = table.Column<int>(type: "int", nullable: true),
                    EarlyDeparturePermission = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permanenceModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PermissionStatus = table.Column<bool>(type: "bit", nullable: false),
                    PermissionsDuration = table.Column<int>(type: "int", nullable: false),
                    RepeatPermissionDuringTheMonth = table.Column<int>(type: "int", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "permissionToAttendAndLeaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermanencyStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissionToAttendAndLeaves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "publicAdministrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicAdministrationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nots = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publicAdministrations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "publicHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HolidayName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    VacationsBalance = table.Column<int>(type: "int", nullable: true),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    DayCount = table.Column<int>(type: "int", nullable: true),
                    RotationDuration = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publicHolidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "qualifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceivedDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qualifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "relativesTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelativeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relativesTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "religion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_religion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sex",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sex", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "specialties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specialties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Violations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViolationsName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Violations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contractTerms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    StatementOfConditions = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContractsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contractTerms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_contractTerms_contracts_ContractsId",
                        column: x => x.ContractsId,
                        principalTable: "contracts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "governorates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_governorates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_governorates_country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "country",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "functionalCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriesName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_functionalCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_functionalCategories_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "functionalClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_functionalClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_functionalClasses_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "guarantees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    NameOfTheBusiness = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CommercialRegistrationNo = table.Column<int>(type: "int", nullable: false),
                    ShopAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HomeAdress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NumberOfDependents = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MaritalStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guarantees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_guarantees_maritalStatuses_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalTable: "maritalStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "boardOfDirectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    CouncilName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NameOfMembership = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MembershipOfTheBoardOfDirectorsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_boardOfDirectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_boardOfDirectors_membershipOfTheBoardOfs_MembershipOfTheBoardOfDirectorsId",
                        column: x => x.MembershipOfTheBoardOfDirectorsId,
                        principalTable: "membershipOfTheBoardOfs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "adjustingTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffTimeStatues = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FromTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ToDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PermanenceModelsId = table.Column<int>(type: "int", nullable: false),
                    PeriodsId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adjustingTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_adjustingTimes_periods_PeriodsId",
                        column: x => x.PeriodsId,
                        principalTable: "periods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_adjustingTimes_permanenceModels_PermanenceModelsId",
                        column: x => x.PermanenceModelsId,
                        principalTable: "permanenceModels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "weekends",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaturDay = table.Column<bool>(type: "bit", nullable: false),
                    SunDay = table.Column<bool>(type: "bit", nullable: false),
                    MonDay = table.Column<bool>(type: "bit", nullable: false),
                    Tuesday = table.Column<bool>(type: "bit", nullable: false),
                    Wednesday = table.Column<bool>(type: "bit", nullable: false),
                    Thursday = table.Column<bool>(type: "bit", nullable: false),
                    Friday = table.Column<bool>(type: "bit", nullable: false),
                    PermanenceModelsId = table.Column<int>(type: "int", nullable: false),
                    PeriodsId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(34)", maxLength: 34, nullable: false),
                    NumbersOfHours = table.Column<int>(type: "int", nullable: true),
                    PermanenceModelsId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weekends", x => x.Id);
                    table.ForeignKey(
                        name: "FK_weekends_periods_PeriodsId",
                        column: x => x.PeriodsId,
                        principalTable: "periods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_weekends_permanenceModels_PermanenceModelsId",
                        column: x => x.PermanenceModelsId,
                        principalTable: "permanenceModels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_weekends_permanenceModels_PermanenceModelsId1",
                        column: x => x.PermanenceModelsId1,
                        principalTable: "permanenceModels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EducationalQualificationAndQualification",
                columns: table => new
                {
                    EducationalQualificationId = table.Column<int>(type: "int", nullable: false),
                    qualificationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalQualificationAndQualification", x => new { x.EducationalQualificationId, x.qualificationsId });
                    table.ForeignKey(
                        name: "FK_EducationalQualificationAndQualification_educationalQualifications_EducationalQualificationId",
                        column: x => x.EducationalQualificationId,
                        principalTable: "educationalQualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationalQualificationAndQualification_qualifications_qualificationsId",
                        column: x => x.qualificationsId,
                        principalTable: "qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecialtiesAndQualification",
                columns: table => new
                {
                    SpecialtiesId = table.Column<int>(type: "int", nullable: false),
                    qualificationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialtiesAndQualification", x => new { x.SpecialtiesId, x.qualificationsId });
                    table.ForeignKey(
                        name: "FK_SpecialtiesAndQualification_qualifications_qualificationsId",
                        column: x => x.qualificationsId,
                        principalTable: "qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecialtiesAndQualification_specialties_SpecialtiesId",
                        column: x => x.SpecialtiesId,
                        principalTable: "specialties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UniversitiesAndQualification",
                columns: table => new
                {
                    qualificationsId = table.Column<int>(type: "int", nullable: false),
                    universitiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversitiesAndQualification", x => new { x.qualificationsId, x.universitiesId });
                    table.ForeignKey(
                        name: "FK_UniversitiesAndQualification_Universities_universitiesId",
                        column: x => x.universitiesId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UniversitiesAndQualification_qualifications_qualificationsId",
                        column: x => x.qualificationsId,
                        principalTable: "qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "directorates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_directorates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_directorates_governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "governorates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobDescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JopName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    JobQualifications = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Authorities = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Responsibilities = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FunctionalCategoriesId = table.Column<int>(type: "int", nullable: true),
                    FunctionalClassId = table.Column<int>(type: "int", nullable: true),
                    JobRanksId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobDescription_functionalCategories_FunctionalCategoriesId",
                        column: x => x.FunctionalCategoriesId,
                        principalTable: "functionalCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobDescription_functionalClasses_FunctionalClassId",
                        column: x => x.FunctionalClassId,
                        principalTable: "functionalClasses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobDescription_jobRanks_JobRanksId",
                        column: x => x.JobRanksId,
                        principalTable: "jobRanks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LicenseNumber = table.Column<int>(type: "int", nullable: false),
                    TypeOfBusinessActivity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ComponyLogo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ComponyAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BoardOfDirectorsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_company_boardOfDirectors_BoardOfDirectorsId",
                        column: x => x.BoardOfDirectorsId,
                        principalTable: "boardOfDirectors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchesName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BranchesAdress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BranchesPhone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    BranchesEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: true),
                    DirectorateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_branches_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_branches_country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_branches_directorates_DirectorateId",
                        column: x => x.DirectorateId,
                        principalTable: "directorates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_branches_governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "governorates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "sectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectorsName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BranchesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sectors_branches_BranchesId",
                        column: x => x.BranchesId,
                        principalTable: "branches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubAdministration = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SectorsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_sectors_SectorsId",
                        column: x => x.SectorsId,
                        principalTable: "sectors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionsName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DepartmentsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNumber = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: false),
                    DateOfEmployment = table.Column<DateOnly>(type: "date", nullable: false),
                    PlacementDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EmploymentStatus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RehireDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DateOfStoppingWork = table.Column<DateOnly>(type: "date", nullable: true),
                    UsedFingerprint = table.Column<bool>(type: "bit", nullable: false),
                    SubjectToInsurance = table.Column<bool>(type: "bit", nullable: false),
                    DateInsurance = table.Column<DateOnly>(type: "date", nullable: true),
                    FingerPrintImage = table.Column<byte>(type: "tinyint", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DepartmentsId = table.Column<int>(type: "int", nullable: false),
                    SectionsId = table.Column<int>(type: "int", nullable: false),
                    JobDescriptionId = table.Column<int>(type: "int", nullable: false),
                    FingerprintDevicesId = table.Column<int>(type: "int", nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employee_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_JobDescription_JobDescriptionId",
                        column: x => x.JobDescriptionId,
                        principalTable: "JobDescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_Sections_SectionsId",
                        column: x => x.SectionsId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_employee_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_fingerprintDevices_FingerprintDevicesId",
                        column: x => x.FingerprintDevicesId,
                        principalTable: "fingerprintDevices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SectionsAccounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FinanceAccountTypeId = table.Column<int>(type: "int", nullable: false),
                    FinanceAccountId = table.Column<int>(type: "int", nullable: false),
                    SectionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionsAccounts", x => x.id);
                    table.ForeignKey(
                        name: "FK_SectionsAccounts_FinanceAccountType_FinanceAccountTypeId",
                        column: x => x.FinanceAccountTypeId,
                        principalTable: "FinanceAccountType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionsAccounts_FinanceAccount_FinanceAccountId",
                        column: x => x.FinanceAccountId,
                        principalTable: "FinanceAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionsAccounts_Sections_SectionsId",
                        column: x => x.SectionsId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    FinanceAccountTypeId = table.Column<int>(type: "int", nullable: false),
                    FinanceAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeAccount_FinanceAccountType_FinanceAccountTypeId",
                        column: x => x.FinanceAccountTypeId,
                        principalTable: "FinanceAccountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeAccount_FinanceAccount_FinanceAccountId",
                        column: x => x.FinanceAccountId,
                        principalTable: "FinanceAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeAccount_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeArchives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descriotion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeArchives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeArchives_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesQualifications",
                columns: table => new
                {
                    employeesId = table.Column<int>(type: "int", nullable: false),
                    qualificationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesQualifications", x => new { x.employeesId, x.qualificationsId });
                    table.ForeignKey(
                        name: "FK_EmployeesQualifications_employee_employeesId",
                        column: x => x.employeesId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeesQualifications_qualifications_qualificationsId",
                        column: x => x.qualificationsId,
                        principalTable: "qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Family",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RelativesTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Family", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Family_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Family_relativesTypes_RelativesTypeId",
                        column: x => x.RelativesTypeId,
                        principalTable: "relativesTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "financialStatements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NatureOfEmployment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsuranceAccountNumber = table.Column<int>(type: "int", nullable: false),
                    BankAccountNumber = table.Column<int>(type: "int", nullable: false),
                    SalaryStartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SalaryEndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_financialStatements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_financialStatements_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_financialStatements_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "linkingEmployeesToShiftPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfStartWork = table.Column<DateOnly>(type: "date", nullable: false),
                    DateOfEndWork = table.Column<DateOnly>(type: "date", nullable: false),
                    DepartmentsId = table.Column<int>(type: "int", nullable: false),
                    SectionsId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PermanenceModelsId = table.Column<int>(type: "int", nullable: false),
                    PeriodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_linkingEmployeesToShiftPeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_linkingEmployeesToShiftPeriods_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_linkingEmployeesToShiftPeriods_Sections_SectionsId",
                        column: x => x.SectionsId,
                        principalTable: "Sections",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_linkingEmployeesToShiftPeriods_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_linkingEmployeesToShiftPeriods_periods_PeriodsId",
                        column: x => x.PeriodsId,
                        principalTable: "periods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_linkingEmployeesToShiftPeriods_permanenceModels_PermanenceModelsId",
                        column: x => x.PermanenceModelsId,
                        principalTable: "permanenceModels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "oneFingerprints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    OneDayFingerprint = table.Column<bool>(type: "bit", nullable: false),
                    FromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ToDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oneFingerprints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_oneFingerprints_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "openingBalancesForVacations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BalanceYear = table.Column<DateOnly>(type: "date", nullable: false),
                    Balance = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PublicHolidaysId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_openingBalancesForVacations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_openingBalancesForVacations_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_openingBalancesForVacations_publicHolidays_PublicHolidaysId",
                        column: x => x.PublicHolidaysId,
                        principalTable: "publicHolidays",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "personalDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    HomePhone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CardType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ToRelease = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CardNumber = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CardExpiryDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    GuaranteesId = table.Column<int>(type: "int", nullable: false),
                    SexId = table.Column<int>(type: "int", nullable: false),
                    NationalityId = table.Column<int>(type: "int", nullable: false),
                    ReligionId = table.Column<int>(type: "int", nullable: false),
                    MaritalStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personalDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_personalDatas_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personalDatas_guarantees_GuaranteesId",
                        column: x => x.GuaranteesId,
                        principalTable: "guarantees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personalDatas_maritalStatuses_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalTable: "maritalStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_personalDatas_nationality_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "nationality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personalDatas_religion_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "religion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personalDatas_sex_SexId",
                        column: x => x.SexId,
                        principalTable: "sex",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "practicalExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExperiencesName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PlacToGainExperience = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    FromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ToDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_practicalExperiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_practicalExperiences_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "staffTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorksFullTimeFromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    PermanenceModelsId = table.Column<int>(type: "int", nullable: true),
                    SectionsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_staffTimes_Sections_SectionsId",
                        column: x => x.SectionsId,
                        principalTable: "Sections",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_staffTimes_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_staffTimes_permanenceModels_PermanenceModelsId",
                        column: x => x.PermanenceModelsId,
                        principalTable: "permanenceModels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "statementOfEmployeeFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilesStatus = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statementOfEmployeeFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_statementOfEmployeeFiles_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trainingCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCourses = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    WhereToGetIt = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ToDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainingCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trainingCourses_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FunctionalFilesOfStatementOfEmployeeFiles",
                columns: table => new
                {
                    FunctionalFilesId = table.Column<int>(type: "int", nullable: false),
                    StatementOfEmployeeFilesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunctionalFilesOfStatementOfEmployeeFiles", x => new { x.FunctionalFilesId, x.StatementOfEmployeeFilesId });
                    table.ForeignKey(
                        name: "FK_FunctionalFilesOfStatementOfEmployeeFiles_functionalFiles_FunctionalFilesId",
                        column: x => x.FunctionalFilesId,
                        principalTable: "functionalFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FunctionalFilesOfStatementOfEmployeeFiles_statementOfEmployeeFiles_StatementOfEmployeeFilesId",
                        column: x => x.StatementOfEmployeeFilesId,
                        principalTable: "statementOfEmployeeFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Penalties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PenaltiesName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Deduction = table.Column<bool>(type: "bit", nullable: false),
                    DiscountFromWorkingHours = table.Column<bool>(type: "bit", nullable: false),
                    DeductionFromTheDailyWage = table.Column<bool>(type: "bit", nullable: false),
                    DeductionFromSalary = table.Column<bool>(type: "bit", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: true),
                    Percent = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PenaltiesAndViolationsFormsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penalties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "penaltiesAndViolationsForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NumberOfTime = table.Column<int>(type: "int", nullable: false),
                    ViolationsId = table.Column<int>(type: "int", nullable: false),
                    PenaltiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_penaltiesAndViolationsForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_penaltiesAndViolationsForms_Penalties_PenaltiesId",
                        column: x => x.PenaltiesId,
                        principalTable: "Penalties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_penaltiesAndViolationsForms_Violations_ViolationsId",
                        column: x => x.ViolationsId,
                        principalTable: "Violations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_adjustingTimes_PeriodsId",
                table: "adjustingTimes",
                column: "PeriodsId");

            migrationBuilder.CreateIndex(
                name: "IX_adjustingTimes_PermanenceModelsId",
                table: "adjustingTimes",
                column: "PermanenceModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_boardOfDirectors_MembershipOfTheBoardOfDirectorsId",
                table: "boardOfDirectors",
                column: "MembershipOfTheBoardOfDirectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_branches_CompanyId",
                table: "branches",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_branches_CountryId",
                table: "branches",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_branches_DirectorateId",
                table: "branches",
                column: "DirectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_branches_GovernorateId",
                table: "branches",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_company_BoardOfDirectorsId",
                table: "company",
                column: "BoardOfDirectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_contractTerms_ContractsId",
                table: "contractTerms",
                column: "ContractsId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_SectorsId",
                table: "Departments",
                column: "SectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_directorates_GovernorateId",
                table: "directorates",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalQualificationAndQualification_qualificationsId",
                table: "EducationalQualificationAndQualification",
                column: "qualificationsId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_DepartmentsId",
                table: "employee",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_FingerprintDevicesId",
                table: "employee",
                column: "FingerprintDevicesId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_JobDescriptionId",
                table: "employee",
                column: "JobDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_ManagerId",
                table: "employee",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_SectionsId",
                table: "employee",
                column: "SectionsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAccount_EmployeeId",
                table: "EmployeeAccount",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAccount_FinanceAccountId",
                table: "EmployeeAccount",
                column: "FinanceAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAccount_FinanceAccountTypeId",
                table: "EmployeeAccount",
                column: "FinanceAccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeArchives_EmployeeId",
                table: "EmployeeArchives",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesQualifications_qualificationsId",
                table: "EmployeesQualifications",
                column: "qualificationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Family_EmployeeId",
                table: "Family",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Family_RelativesTypeId",
                table: "Family",
                column: "RelativesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_financialStatements_CurrencyId",
                table: "financialStatements",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_financialStatements_EmployeeId",
                table: "financialStatements",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_functionalCategories_CurrencyId",
                table: "functionalCategories",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_functionalClasses_CurrencyId",
                table: "functionalClasses",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionalFilesOfStatementOfEmployeeFiles_StatementOfEmployeeFilesId",
                table: "FunctionalFilesOfStatementOfEmployeeFiles",
                column: "StatementOfEmployeeFilesId");

            migrationBuilder.CreateIndex(
                name: "IX_governorates_CountryId",
                table: "governorates",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_guarantees_MaritalStatusId",
                table: "guarantees",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_JobDescription_FunctionalCategoriesId",
                table: "JobDescription",
                column: "FunctionalCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_JobDescription_FunctionalClassId",
                table: "JobDescription",
                column: "FunctionalClassId");

            migrationBuilder.CreateIndex(
                name: "IX_JobDescription_JobRanksId",
                table: "JobDescription",
                column: "JobRanksId");

            migrationBuilder.CreateIndex(
                name: "IX_linkingEmployeesToShiftPeriods_DepartmentsId",
                table: "linkingEmployeesToShiftPeriods",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_linkingEmployeesToShiftPeriods_EmployeeId",
                table: "linkingEmployeesToShiftPeriods",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_linkingEmployeesToShiftPeriods_PeriodsId",
                table: "linkingEmployeesToShiftPeriods",
                column: "PeriodsId");

            migrationBuilder.CreateIndex(
                name: "IX_linkingEmployeesToShiftPeriods_PermanenceModelsId",
                table: "linkingEmployeesToShiftPeriods",
                column: "PermanenceModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_linkingEmployeesToShiftPeriods_SectionsId",
                table: "linkingEmployeesToShiftPeriods",
                column: "SectionsId");

            migrationBuilder.CreateIndex(
                name: "IX_oneFingerprints_EmployeeId",
                table: "oneFingerprints",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_openingBalancesForVacations_EmployeeId",
                table: "openingBalancesForVacations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_openingBalancesForVacations_PublicHolidaysId",
                table: "openingBalancesForVacations",
                column: "PublicHolidaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Penalties_PenaltiesAndViolationsFormsId",
                table: "Penalties",
                column: "PenaltiesAndViolationsFormsId");

            migrationBuilder.CreateIndex(
                name: "IX_penaltiesAndViolationsForms_PenaltiesId",
                table: "penaltiesAndViolationsForms",
                column: "PenaltiesId");

            migrationBuilder.CreateIndex(
                name: "IX_penaltiesAndViolationsForms_ViolationsId",
                table: "penaltiesAndViolationsForms",
                column: "ViolationsId");

            migrationBuilder.CreateIndex(
                name: "IX_personalDatas_EmployeeId",
                table: "personalDatas",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_personalDatas_GuaranteesId",
                table: "personalDatas",
                column: "GuaranteesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_personalDatas_MaritalStatusId",
                table: "personalDatas",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_personalDatas_NationalityId",
                table: "personalDatas",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_personalDatas_ReligionId",
                table: "personalDatas",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_personalDatas_SexId",
                table: "personalDatas",
                column: "SexId");

            migrationBuilder.CreateIndex(
                name: "IX_practicalExperiences_EmployeeId",
                table: "practicalExperiences",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_DepartmentsId",
                table: "Sections",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionsAccounts_FinanceAccountId",
                table: "SectionsAccounts",
                column: "FinanceAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionsAccounts_FinanceAccountTypeId",
                table: "SectionsAccounts",
                column: "FinanceAccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionsAccounts_SectionsId",
                table: "SectionsAccounts",
                column: "SectionsId");

            migrationBuilder.CreateIndex(
                name: "IX_sectors_BranchesId",
                table: "sectors",
                column: "BranchesId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialtiesAndQualification_qualificationsId",
                table: "SpecialtiesAndQualification",
                column: "qualificationsId");

            migrationBuilder.CreateIndex(
                name: "IX_staffTimes_EmployeeId",
                table: "staffTimes",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_staffTimes_PermanenceModelsId",
                table: "staffTimes",
                column: "PermanenceModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_staffTimes_SectionsId",
                table: "staffTimes",
                column: "SectionsId");

            migrationBuilder.CreateIndex(
                name: "IX_statementOfEmployeeFiles_EmployeeId",
                table: "statementOfEmployeeFiles",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_trainingCourses_EmployeeId",
                table: "trainingCourses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_UniversitiesAndQualification_universitiesId",
                table: "UniversitiesAndQualification",
                column: "universitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_weekends_PeriodsId",
                table: "weekends",
                column: "PeriodsId");

            migrationBuilder.CreateIndex(
                name: "IX_weekends_PermanenceModelsId",
                table: "weekends",
                column: "PermanenceModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_weekends_PermanenceModelsId1",
                table: "weekends",
                column: "PermanenceModelsId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Penalties_penaltiesAndViolationsForms_PenaltiesAndViolationsFormsId",
                table: "Penalties",
                column: "PenaltiesAndViolationsFormsId",
                principalTable: "penaltiesAndViolationsForms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Penalties_penaltiesAndViolationsForms_PenaltiesAndViolationsFormsId",
                table: "Penalties");

            migrationBuilder.DropTable(
                name: "additionalAccountInformation");

            migrationBuilder.DropTable(
                name: "adjustingTimes");

            migrationBuilder.DropTable(
                name: "allowancesAndDiscounts");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "basicDataForTheSalaryStatements");

            migrationBuilder.DropTable(
                name: "basicDataForWagesAndSalaries");

            migrationBuilder.DropTable(
                name: "contractTerms");

            migrationBuilder.DropTable(
                name: "EducationalQualificationAndQualification");

            migrationBuilder.DropTable(
                name: "EmployeeAccount");

            migrationBuilder.DropTable(
                name: "EmployeeArchives");

            migrationBuilder.DropTable(
                name: "EmployeesQualifications");

            migrationBuilder.DropTable(
                name: "Family");

            migrationBuilder.DropTable(
                name: "financialStatements");

            migrationBuilder.DropTable(
                name: "FunctionalFilesOfStatementOfEmployeeFiles");

            migrationBuilder.DropTable(
                name: "linkingEmployeesToShiftPeriods");

            migrationBuilder.DropTable(
                name: "months");

            migrationBuilder.DropTable(
                name: "officialVacations");

            migrationBuilder.DropTable(
                name: "oneFingerprints");

            migrationBuilder.DropTable(
                name: "openingBalancesForVacations");

            migrationBuilder.DropTable(
                name: "permissions");

            migrationBuilder.DropTable(
                name: "permissionToAttendAndLeaves");

            migrationBuilder.DropTable(
                name: "personalDatas");

            migrationBuilder.DropTable(
                name: "practicalExperiences");

            migrationBuilder.DropTable(
                name: "publicAdministrations");

            migrationBuilder.DropTable(
                name: "SectionsAccounts");

            migrationBuilder.DropTable(
                name: "SpecialtiesAndQualification");

            migrationBuilder.DropTable(
                name: "staffTimes");

            migrationBuilder.DropTable(
                name: "trainingCourses");

            migrationBuilder.DropTable(
                name: "UniversitiesAndQualification");

            migrationBuilder.DropTable(
                name: "weekends");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "contracts");

            migrationBuilder.DropTable(
                name: "educationalQualifications");

            migrationBuilder.DropTable(
                name: "relativesTypes");

            migrationBuilder.DropTable(
                name: "functionalFiles");

            migrationBuilder.DropTable(
                name: "statementOfEmployeeFiles");

            migrationBuilder.DropTable(
                name: "publicHolidays");

            migrationBuilder.DropTable(
                name: "guarantees");

            migrationBuilder.DropTable(
                name: "nationality");

            migrationBuilder.DropTable(
                name: "religion");

            migrationBuilder.DropTable(
                name: "sex");

            migrationBuilder.DropTable(
                name: "FinanceAccountType");

            migrationBuilder.DropTable(
                name: "FinanceAccount");

            migrationBuilder.DropTable(
                name: "specialties");

            migrationBuilder.DropTable(
                name: "Universities");

            migrationBuilder.DropTable(
                name: "qualifications");

            migrationBuilder.DropTable(
                name: "periods");

            migrationBuilder.DropTable(
                name: "permanenceModels");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "maritalStatuses");

            migrationBuilder.DropTable(
                name: "JobDescription");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "fingerprintDevices");

            migrationBuilder.DropTable(
                name: "functionalCategories");

            migrationBuilder.DropTable(
                name: "functionalClasses");

            migrationBuilder.DropTable(
                name: "jobRanks");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "sectors");

            migrationBuilder.DropTable(
                name: "branches");

            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropTable(
                name: "directorates");

            migrationBuilder.DropTable(
                name: "boardOfDirectors");

            migrationBuilder.DropTable(
                name: "governorates");

            migrationBuilder.DropTable(
                name: "membershipOfTheBoardOfs");

            migrationBuilder.DropTable(
                name: "country");

            migrationBuilder.DropTable(
                name: "penaltiesAndViolationsForms");

            migrationBuilder.DropTable(
                name: "Penalties");

            migrationBuilder.DropTable(
                name: "Violations");
        }
    }
}