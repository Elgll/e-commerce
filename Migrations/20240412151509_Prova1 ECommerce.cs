using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace galli.mingucci._5i.Progetto_E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class Prova1ECommerce : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Password);
                });

            migrationBuilder.CreateTable(
                name: "Prenotations",
                columns: table => new
                {
                    TotalBill = table.Column<double>(type: "REAL", nullable: false),
                    HoursPrenoted = table.Column<int>(type: "INTEGER", nullable: false),
                    PeopleNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    ChoosenCircuit = table.Column<string>(type: "TEXT", nullable: true),
                    PTotMoto = table.Column<double>(type: "REAL", nullable: false),
                    CircuitPrice = table.Column<double>(type: "REAL", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prenotations", x => x.TotalBill);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    _Sex = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    LoginPassword = table.Column<string>(type: "TEXT", nullable: true),
                    PrenotationTotalBill = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Password);
                    table.ForeignKey(
                        name: "FK_ApplicationUsers_Logins_LoginPassword",
                        column: x => x.LoginPassword,
                        principalTable: "Logins",
                        principalColumn: "Password");
                    table.ForeignKey(
                        name: "FK_ApplicationUsers_Prenotations_PrenotationTotalBill",
                        column: x => x.PrenotationTotalBill,
                        principalTable: "Prenotations",
                        principalColumn: "TotalBill");
                });

            migrationBuilder.CreateTable(
                name: "Bikes",
                columns: table => new
                {
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    SetUp = table.Column<string>(type: "TEXT", nullable: true),
                    ProductionYear = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    Displacement = table.Column<int>(type: "INTEGER", nullable: false),
                    Power = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    Strokes = table.Column<int>(type: "INTEGER", nullable: false),
                    Cylinders = table.Column<int>(type: "INTEGER", nullable: false),
                    CylindersConfiguration = table.Column<string>(type: "TEXT", nullable: true),
                    CylinderDisposition = table.Column<string>(type: "TEXT", nullable: true),
                    Refrigeration = table.Column<string>(type: "TEXT", nullable: true),
                    StartUp = table.Column<string>(type: "TEXT", nullable: true),
                    Clutch = table.Column<string>(type: "TEXT", nullable: true),
                    ValvesNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Distribution = table.Column<string>(type: "TEXT", nullable: true),
                    PrenotationTotalBill = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bikes", x => x.Model);
                    table.ForeignKey(
                        name: "FK_Bikes_Prenotations_PrenotationTotalBill",
                        column: x => x.PrenotationTotalBill,
                        principalTable: "Prenotations",
                        principalColumn: "TotalBill");
                });

            migrationBuilder.CreateTable(
                name: "Circuits",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Site = table.Column<string>(type: "TEXT", nullable: true),
                    Tipology = table.Column<string>(type: "TEXT", nullable: true),
                    Editions = table.Column<int>(type: "INTEGER", nullable: false),
                    Laps = table.Column<int>(type: "INTEGER", nullable: false),
                    CircuitLenght = table.Column<int>(type: "INTEGER", nullable: false),
                    CurvesNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    RaceLenght = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    BikeModel = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuits", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Circuits_Bikes_BikeModel",
                        column: x => x.BikeModel,
                        principalTable: "Bikes",
                        principalColumn: "Model");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_LoginPassword",
                table: "ApplicationUsers",
                column: "LoginPassword");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_PrenotationTotalBill",
                table: "ApplicationUsers",
                column: "PrenotationTotalBill");

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_PrenotationTotalBill",
                table: "Bikes",
                column: "PrenotationTotalBill");

            migrationBuilder.CreateIndex(
                name: "IX_Circuits_BikeModel",
                table: "Circuits",
                column: "BikeModel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "Circuits");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Bikes");

            migrationBuilder.DropTable(
                name: "Prenotations");
        }
    }
}
