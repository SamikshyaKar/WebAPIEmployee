using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPIEmployeeFull.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departmentsprop",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departmentsprop", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Employeeprop",
                columns: table => new
                {
                    EmpID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpSalary = table.Column<int>(type: "int", nullable: false),
                    EmpCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpDateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpGender = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employeeprop", x => x.EmpID);
                    table.ForeignKey(
                        name: "FK_Employeeprop_departmentsprop_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "departmentsprop",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "departmentsprop",
                columns: new[] { "DepartmentID", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "PayRoll" },
                    { 4, "Staffing" }
                });

            migrationBuilder.InsertData(
                table: "Employeeprop",
                columns: new[] { "EmpID", "DepartmentId", "Email", "EmpCity", "EmpDateofBirth", "EmpFirstName", "EmpGender", "EmpLastName", "EmpSalary", "PhotoPath" },
                values: new object[] { 101, 1, "sara@gmail.com", null, new DateTime(2000, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara", 1, "Tondon", 0, "~/Wwwroot/Images/Flower1.jpg" });

            migrationBuilder.InsertData(
                table: "Employeeprop",
                columns: new[] { "EmpID", "DepartmentId", "Email", "EmpCity", "EmpDateofBirth", "EmpFirstName", "EmpGender", "EmpLastName", "EmpSalary", "PhotoPath" },
                values: new object[] { 102, 2, "John@gmail.com", null, new DateTime(2001, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", 0, "Srikant", 0, "~/Wwwroot/Images/Flower2.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_Employeeprop_DepartmentId",
                table: "Employeeprop",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employeeprop");

            migrationBuilder.DropTable(
                name: "departmentsprop");
        }
    }
}
