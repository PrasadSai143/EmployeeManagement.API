using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Context.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EMPID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HouseNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VillageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PinCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false),
                    CREATEDON = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATEDBY = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATEDON = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATEDBY = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GENDER = table.Column<bool>(type: "bit", nullable: false),
                    DATEOFBIRTH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOBILE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MARITALSTATUS = table.Column<bool>(type: "bit", nullable: false),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false),
                    CREATEDON = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATEDBY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATEDBY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATEDON = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EmpSalaries",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EMPID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EMPTYPE = table.Column<bool>(type: "bit", nullable: false),
                    SALARY = table.Column<double>(type: "float", nullable: false),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false),
                    CREATEDON = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATEDBY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATEDBY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATEDON = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpSalaries", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmpSalaries_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpSalaries_EmployeeID",
                table: "EmpSalaries",
                column: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "EmpSalaries");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
