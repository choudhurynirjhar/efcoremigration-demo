using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace EFCoreMigration.Demo.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("02052020101000_Migration1")]
    public class Migration1 : Migration
    {
        protected override void Up(
            [NotNullAttribute] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: cb => new
                {
                    Id = cb.Column<int>(nullable: false)
                            .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = cb.Column<string>(nullable: false),
                    LastName = cb.Column<string>(nullable: false),
                    Address = cb.Column<string>(nullable: true)
                },
                constraints: ctb => ctb.PrimaryKey("PK_EmployeeID_Key", x => x.Id)
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Employees");
        }
    }
}
