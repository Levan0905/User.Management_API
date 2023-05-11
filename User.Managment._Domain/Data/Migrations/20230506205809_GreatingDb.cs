using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace User.Managment._Domain.Data.Migrations
{
    /// <inheritdoc />
    public partial class GreatingDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(16)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewUserRole",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewUserRole", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_NewUserRole_NewRoles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "NewRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewUserRole_NewUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "NewUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewUserRole_UsersId",
                table: "NewUserRole",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewUserRole");

            migrationBuilder.DropTable(
                name: "NewRoles");

            migrationBuilder.DropTable(
                name: "NewUsers");
        }
    }
}
