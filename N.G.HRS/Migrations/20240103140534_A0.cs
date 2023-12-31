﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace N.G.HRS.Migrations
{
    /// <inheritdoc />
    public partial class A0 : Migration
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
                    Day = table.Column<DateOnly>(type: "date", nullable: false),
                    FromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ToDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_additionalAccountInformation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "adjustingTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ToDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adjustingTimes", x => x.Id);
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
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.Id);
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
                name: "departmentAccounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departmentAccounts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAccount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employeeAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Family",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Family", x => x.Id);
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
                    PersonalDataId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guarantees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "linkingEmployeesToShiftPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfStartWork = table.Column<DateOnly>(type: "date", nullable: false),
                    DateOfEndWork = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_linkingEmployeesToShiftPeriods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "months",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<DateOnly>(type: "date", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_months", x => x.Id);
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
                name: "oneFingerprints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    OneDayFingerprint = table.Column<bool>(type: "bit", nullable: false),
                    FromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ToDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oneFingerprints", x => x.Id);
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
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_openingBalancesForVacations", x => x.Id);
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
                    Nots = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
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
                    VacationsBalance = table.Column<bool>(type: "bit", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    DayCount = table.Column<int>(type: "int", nullable: false),
                    RotationDuration = table.Column<int>(type: "int", nullable: false),
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
                name: "staffTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorksFullTimeFromDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffTimes", x => x.Id);
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
                    Discriminator = table.Column<string>(type: "nvarchar(34)", maxLength: 34, nullable: false),
                    NumbersOfHours = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weekends", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "boardOfDirectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    CouncilName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NameOfMembership = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_boardOfDirectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_boardOfDirectors_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
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
                    ContractsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contractTerms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_contractTerms_contracts_ContractsId",
                        column: x => x.ContractsId,
                        principalTable: "contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinanceAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeAccountId = table.Column<int>(type: "int", nullable: false),
                    DepartmentAccountsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinanceAccount_EmployeeAccount_EmployeeAccountId",
                        column: x => x.EmployeeAccountId,
                        principalTable: "EmployeeAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FinanceAccount_departmentAccounts_DepartmentAccountsId",
                        column: x => x.DepartmentAccountsId,
                        principalTable: "departmentAccounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeAccountId = table.Column<int>(type: "int", nullable: false),
                    DepartmentAccountsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceAccountType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinanceAccountType_EmployeeAccount_EmployeeAccountId",
                        column: x => x.EmployeeAccountId,
                        principalTable: "EmployeeAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FinanceAccountType_departmentAccounts_DepartmentAccountsId",
                        column: x => x.DepartmentAccountsId,
                        principalTable: "departmentAccounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "relativesTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelativeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FamilyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relativesTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_relativesTypes_Family_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Family",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Hours = table.Column<int>(type: "int", nullable: false),
                    LinkingEmployeesToShiftPeriodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_periods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_periods_linkingEmployeesToShiftPeriods_LinkingEmployeesToShiftPeriodsId",
                        column: x => x.LinkingEmployeesToShiftPeriodsId,
                        principalTable: "linkingEmployeesToShiftPeriods",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "educationalQualifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QualificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_educationalQualifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_educationalQualifications_qualifications_QualificationId",
                        column: x => x.QualificationId,
                        principalTable: "qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "specialties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QualificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specialties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_specialties_qualifications_QualificationId",
                        column: x => x.QualificationId,
                        principalTable: "qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QualificationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Universities_qualifications_QualificationsId",
                        column: x => x.QualificationsId,
                        principalTable: "qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    RehireDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DateOfStoppingWork = table.Column<DateOnly>(type: "date", nullable: false),
                    UsedFingerprint = table.Column<bool>(type: "bit", nullable: false),
                    SubjectToInsurance = table.Column<bool>(type: "bit", nullable: false),
                    DateInsurance = table.Column<DateOnly>(type: "date", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: true),
                    EmployeeAccountId = table.Column<int>(type: "int", nullable: false),
                    StaffTimeId = table.Column<int>(type: "int", nullable: false),
                    LinkingEmployeesToShiftPeriodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employee_EmployeeAccount_EmployeeAccountId",
                        column: x => x.EmployeeAccountId,
                        principalTable: "EmployeeAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_employee_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_linkingEmployeesToShiftPeriods_LinkingEmployeesToShiftPeriodsId",
                        column: x => x.LinkingEmployeesToShiftPeriodsId,
                        principalTable: "linkingEmployeesToShiftPeriods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_employee_staffTimes_StaffTimeId",
                        column: x => x.StaffTimeId,
                        principalTable: "staffTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    HoursOfWorks = table.Column<int>(type: "int", nullable: false),
                    AddAttendanceAndDeparturePermission = table.Column<bool>(type: "bit", nullable: false),
                    AllowanceForLateAttendance = table.Column<bool>(type: "bit", nullable: false),
                    EarlyDeparturePermission = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StaffTimeId = table.Column<int>(type: "int", nullable: false),
                    LinkingEmployeesToShiftPeriodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permanenceModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_permanenceModels_linkingEmployeesToShiftPeriods_LinkingEmployeesToShiftPeriodsId",
                        column: x => x.LinkingEmployeesToShiftPeriodsId,
                        principalTable: "linkingEmployeesToShiftPeriods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_permanenceModels_staffTimes_StaffTimeId",
                        column: x => x.StaffTimeId,
                        principalTable: "staffTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "membershipOfTheBoardOfs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOFMembership = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BoardOfDirectorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_membershipOfTheBoardOfs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_membershipOfTheBoardOfs_boardOfDirectors_BoardOfDirectorsId",
                        column: x => x.BoardOfDirectorsId,
                        principalTable: "boardOfDirectors",
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
                name: "financialStatements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NatureOfEmployment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsuranceAccountNumber = table.Column<int>(type: "int", nullable: false),
                    BankAccountNumber = table.Column<int>(type: "int", nullable: false),
                    SalaryStartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SalaryEndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_financialStatements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_financialStatements_employee_Id",
                        column: x => x.Id,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fingerprintDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_fingerprintDevices_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "jobDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JopName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    JobQualifications = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Authorities = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Responsibilities = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_jobDescriptions_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "personalDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    HomePhone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CardType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CardNumber = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CardExpiryDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personalDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_personalDatas_employee_Id",
                        column: x => x.Id,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personalDatas_guarantees_Id",
                        column: x => x.Id,
                        principalTable: "guarantees",
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
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionsName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DepartmentAccountsId = table.Column<int>(type: "int", nullable: false),
                    LinkingEmployeesToShiftPeriodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_departmentAccounts_DepartmentAccountsId",
                        column: x => x.DepartmentAccountsId,
                        principalTable: "departmentAccounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_linkingEmployeesToShiftPeriods_LinkingEmployeesToShiftPeriodsId",
                        column: x => x.LinkingEmployeesToShiftPeriodsId,
                        principalTable: "linkingEmployeesToShiftPeriods",
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
                name: "functionalCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriesName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    JobDescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_functionalCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_functionalCategories_jobDescriptions_JobDescriptionId",
                        column: x => x.JobDescriptionId,
                        principalTable: "jobDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "functionalClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    JobDescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_functionalClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_functionalClasses_jobDescriptions_JobDescriptionId",
                        column: x => x.JobDescriptionId,
                        principalTable: "jobDescriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "jobRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RankName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    JobDescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobRanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_jobRanks_jobDescriptions_JobDescriptionId",
                        column: x => x.JobDescriptionId,
                        principalTable: "jobDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "maritalStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PersonalDataId = table.Column<int>(type: "int", nullable: false),
                    GuaranteesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maritalStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_maritalStatuses_guarantees_GuaranteesId",
                        column: x => x.GuaranteesId,
                        principalTable: "guarantees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_maritalStatuses_personalDatas_PersonalDataId",
                        column: x => x.PersonalDataId,
                        principalTable: "personalDatas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "nationality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalityName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PersonalDataId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nationality", x => x.Id);
                    table.ForeignKey(
                        name: "FK_nationality_personalDatas_PersonalDataId",
                        column: x => x.PersonalDataId,
                        principalTable: "personalDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "religion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PersonalDataId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_religion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_religion_personalDatas_PersonalDataId",
                        column: x => x.PersonalDataId,
                        principalTable: "personalDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sex",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PersonalDataId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sex", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sex_personalDatas_PersonalDataId",
                        column: x => x.PersonalDataId,
                        principalTable: "personalDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubAdministration = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    SectionsId = table.Column<int>(type: "int", nullable: false),
                    LinkingEmployeesToShiftPeriodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Sections_SectionsId",
                        column: x => x.SectionsId,
                        principalTable: "Sections",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Departments_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Departments_linkingEmployeesToShiftPeriods_LinkingEmployeesToShiftPeriodsId",
                        column: x => x.LinkingEmployeesToShiftPeriodsId,
                        principalTable: "linkingEmployeesToShiftPeriods",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "functionalFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StatementOfEmployeeFilesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_functionalFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_functionalFiles_statementOfEmployeeFiles_StatementOfEmployeeFilesId",
                        column: x => x.StatementOfEmployeeFilesId,
                        principalTable: "statementOfEmployeeFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    PreviousPriceOfCurrency = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FinancialStatementsId = table.Column<int>(type: "int", nullable: false),
                    FunctionalClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Currency_financialStatements_FinancialStatementsId",
                        column: x => x.FinancialStatementsId,
                        principalTable: "financialStatements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Currency_functionalClasses_FunctionalClassId",
                        column: x => x.FunctionalClassId,
                        principalTable: "functionalClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectorsName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DepartmentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sectors_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
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
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    SectorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_branches_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_branches_sectors_SectorsId",
                        column: x => x.SectorsId,
                        principalTable: "sectors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BranchesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.Id);
                    table.ForeignKey(
                        name: "FK_country_branches_BranchesId",
                        column: x => x.BranchesId,
                        principalTable: "branches",
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
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    BranchesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_governorates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_governorates_branches_BranchesId",
                        column: x => x.BranchesId,
                        principalTable: "branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_governorates_country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "country",
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
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    BranchesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_directorates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_directorates_branches_BranchesId",
                        column: x => x.BranchesId,
                        principalTable: "branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_directorates_governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_boardOfDirectors_CompanyId",
                table: "boardOfDirectors",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_branches_CompanyId",
                table: "branches",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_branches_SectorsId",
                table: "branches",
                column: "SectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_contractTerms_ContractsId",
                table: "contractTerms",
                column: "ContractsId");

            migrationBuilder.CreateIndex(
                name: "IX_country_BranchesId",
                table: "country",
                column: "BranchesId");

            migrationBuilder.CreateIndex(
                name: "IX_Currency_FinancialStatementsId",
                table: "Currency",
                column: "FinancialStatementsId");

            migrationBuilder.CreateIndex(
                name: "IX_Currency_FunctionalClassId",
                table: "Currency",
                column: "FunctionalClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_EmployeeId",
                table: "Departments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_LinkingEmployeesToShiftPeriodsId",
                table: "Departments",
                column: "LinkingEmployeesToShiftPeriodsId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_SectionsId",
                table: "Departments",
                column: "SectionsId");

            migrationBuilder.CreateIndex(
                name: "IX_directorates_BranchesId",
                table: "directorates",
                column: "BranchesId");

            migrationBuilder.CreateIndex(
                name: "IX_directorates_GovernorateId",
                table: "directorates",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_educationalQualifications_QualificationId",
                table: "educationalQualifications",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_EmployeeAccountId",
                table: "employee",
                column: "EmployeeAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_LinkingEmployeesToShiftPeriodsId",
                table: "employee",
                column: "LinkingEmployeesToShiftPeriodsId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_ManagerId",
                table: "employee",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_StaffTimeId",
                table: "employee",
                column: "StaffTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeArchives_EmployeeId",
                table: "EmployeeArchives",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceAccount_DepartmentAccountsId",
                table: "FinanceAccount",
                column: "DepartmentAccountsId");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceAccount_EmployeeAccountId",
                table: "FinanceAccount",
                column: "EmployeeAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceAccountType_DepartmentAccountsId",
                table: "FinanceAccountType",
                column: "DepartmentAccountsId");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceAccountType_EmployeeAccountId",
                table: "FinanceAccountType",
                column: "EmployeeAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_fingerprintDevices_EmployeeId",
                table: "fingerprintDevices",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_functionalCategories_JobDescriptionId",
                table: "functionalCategories",
                column: "JobDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_functionalClasses_JobDescriptionId",
                table: "functionalClasses",
                column: "JobDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_functionalFiles_StatementOfEmployeeFilesId",
                table: "functionalFiles",
                column: "StatementOfEmployeeFilesId");

            migrationBuilder.CreateIndex(
                name: "IX_governorates_BranchesId",
                table: "governorates",
                column: "BranchesId");

            migrationBuilder.CreateIndex(
                name: "IX_governorates_CountryId",
                table: "governorates",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_jobDescriptions_EmployeeId",
                table: "jobDescriptions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_jobRanks_JobDescriptionId",
                table: "jobRanks",
                column: "JobDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_maritalStatuses_GuaranteesId",
                table: "maritalStatuses",
                column: "GuaranteesId");

            migrationBuilder.CreateIndex(
                name: "IX_maritalStatuses_PersonalDataId",
                table: "maritalStatuses",
                column: "PersonalDataId");

            migrationBuilder.CreateIndex(
                name: "IX_membershipOfTheBoardOfs_BoardOfDirectorsId",
                table: "membershipOfTheBoardOfs",
                column: "BoardOfDirectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_nationality_PersonalDataId",
                table: "nationality",
                column: "PersonalDataId");

            migrationBuilder.CreateIndex(
                name: "IX_periods_LinkingEmployeesToShiftPeriodsId",
                table: "periods",
                column: "LinkingEmployeesToShiftPeriodsId");

            migrationBuilder.CreateIndex(
                name: "IX_permanenceModels_LinkingEmployeesToShiftPeriodsId",
                table: "permanenceModels",
                column: "LinkingEmployeesToShiftPeriodsId");

            migrationBuilder.CreateIndex(
                name: "IX_permanenceModels_StaffTimeId",
                table: "permanenceModels",
                column: "StaffTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_practicalExperiences_EmployeeId",
                table: "practicalExperiences",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_relativesTypes_FamilyId",
                table: "relativesTypes",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_religion_PersonalDataId",
                table: "religion",
                column: "PersonalDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_DepartmentAccountsId",
                table: "Sections",
                column: "DepartmentAccountsId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_EmployeeId",
                table: "Sections",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_LinkingEmployeesToShiftPeriodsId",
                table: "Sections",
                column: "LinkingEmployeesToShiftPeriodsId");

            migrationBuilder.CreateIndex(
                name: "IX_sectors_DepartmentsId",
                table: "sectors",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_sex_PersonalDataId",
                table: "sex",
                column: "PersonalDataId");

            migrationBuilder.CreateIndex(
                name: "IX_specialties_QualificationId",
                table: "specialties",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_statementOfEmployeeFiles_EmployeeId",
                table: "statementOfEmployeeFiles",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_trainingCourses_EmployeeId",
                table: "trainingCourses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Universities_QualificationsId",
                table: "Universities",
                column: "QualificationsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "additionalAccountInformation");

            migrationBuilder.DropTable(
                name: "adjustingTimes");

            migrationBuilder.DropTable(
                name: "allowancesAndDiscounts");

            migrationBuilder.DropTable(
                name: "basicDataForTheSalaryStatements");

            migrationBuilder.DropTable(
                name: "basicDataForWagesAndSalaries");

            migrationBuilder.DropTable(
                name: "contractTerms");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "directorates");

            migrationBuilder.DropTable(
                name: "educationalQualifications");

            migrationBuilder.DropTable(
                name: "employeeAccounts");

            migrationBuilder.DropTable(
                name: "EmployeeArchives");

            migrationBuilder.DropTable(
                name: "FinanceAccount");

            migrationBuilder.DropTable(
                name: "FinanceAccountType");

            migrationBuilder.DropTable(
                name: "fingerprintDevices");

            migrationBuilder.DropTable(
                name: "functionalCategories");

            migrationBuilder.DropTable(
                name: "functionalFiles");

            migrationBuilder.DropTable(
                name: "jobRanks");

            migrationBuilder.DropTable(
                name: "maritalStatuses");

            migrationBuilder.DropTable(
                name: "membershipOfTheBoardOfs");

            migrationBuilder.DropTable(
                name: "months");

            migrationBuilder.DropTable(
                name: "nationality");

            migrationBuilder.DropTable(
                name: "officialVacations");

            migrationBuilder.DropTable(
                name: "oneFingerprints");

            migrationBuilder.DropTable(
                name: "openingBalancesForVacations");

            migrationBuilder.DropTable(
                name: "periods");

            migrationBuilder.DropTable(
                name: "permanenceModels");

            migrationBuilder.DropTable(
                name: "permissions");

            migrationBuilder.DropTable(
                name: "permissionToAttendAndLeaves");

            migrationBuilder.DropTable(
                name: "practicalExperiences");

            migrationBuilder.DropTable(
                name: "publicAdministrations");

            migrationBuilder.DropTable(
                name: "publicHolidays");

            migrationBuilder.DropTable(
                name: "relativesTypes");

            migrationBuilder.DropTable(
                name: "religion");

            migrationBuilder.DropTable(
                name: "sex");

            migrationBuilder.DropTable(
                name: "specialties");

            migrationBuilder.DropTable(
                name: "trainingCourses");

            migrationBuilder.DropTable(
                name: "Universities");

            migrationBuilder.DropTable(
                name: "weekends");

            migrationBuilder.DropTable(
                name: "contracts");

            migrationBuilder.DropTable(
                name: "financialStatements");

            migrationBuilder.DropTable(
                name: "functionalClasses");

            migrationBuilder.DropTable(
                name: "governorates");

            migrationBuilder.DropTable(
                name: "statementOfEmployeeFiles");

            migrationBuilder.DropTable(
                name: "boardOfDirectors");

            migrationBuilder.DropTable(
                name: "Family");

            migrationBuilder.DropTable(
                name: "personalDatas");

            migrationBuilder.DropTable(
                name: "qualifications");

            migrationBuilder.DropTable(
                name: "jobDescriptions");

            migrationBuilder.DropTable(
                name: "country");

            migrationBuilder.DropTable(
                name: "guarantees");

            migrationBuilder.DropTable(
                name: "branches");

            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropTable(
                name: "sectors");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "departmentAccounts");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "EmployeeAccount");

            migrationBuilder.DropTable(
                name: "linkingEmployeesToShiftPeriods");

            migrationBuilder.DropTable(
                name: "staffTimes");
        }
    }
}
