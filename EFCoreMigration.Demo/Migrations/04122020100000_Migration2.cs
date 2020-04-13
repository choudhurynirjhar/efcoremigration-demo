using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace EFCoreMigration.Demo.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("04122020100000_Migration2")]
    public class Migration2 : Migration
    {
        protected override void Up([NotNullAttribute] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>("Age", "Employees", nullable: true);

            migrationBuilder.Sql("UPDATE Employees SET Age = 30");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Age", "Employees");
        }
    }
}
