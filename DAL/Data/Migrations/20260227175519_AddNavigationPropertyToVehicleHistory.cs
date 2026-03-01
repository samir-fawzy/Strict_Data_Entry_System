using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNavigationPropertyToVehicleHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarAccessories");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Units",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleHistories_PreparationId",
                table: "VehicleHistories",
                column: "PreparationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleHistories_StatusId",
                table: "VehicleHistories",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleHistories_UnitId",
                table: "VehicleHistories",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleHistories_UsageId",
                table: "VehicleHistories",
                column: "UsageId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_Name",
                table: "Units",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleHistories_Preparations_PreparationId",
                table: "VehicleHistories",
                column: "PreparationId",
                principalTable: "Preparations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleHistories_Units_UnitId",
                table: "VehicleHistories",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleHistories_Usages_UsageId",
                table: "VehicleHistories",
                column: "UsageId",
                principalTable: "Usages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleHistories_statuses_StatusId",
                table: "VehicleHistories",
                column: "StatusId",
                principalTable: "statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleHistories_Preparations_PreparationId",
                table: "VehicleHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleHistories_Units_UnitId",
                table: "VehicleHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleHistories_Usages_UsageId",
                table: "VehicleHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleHistories_statuses_StatusId",
                table: "VehicleHistories");

            migrationBuilder.DropIndex(
                name: "IX_VehicleHistories_PreparationId",
                table: "VehicleHistories");

            migrationBuilder.DropIndex(
                name: "IX_VehicleHistories_StatusId",
                table: "VehicleHistories");

            migrationBuilder.DropIndex(
                name: "IX_VehicleHistories_UnitId",
                table: "VehicleHistories");

            migrationBuilder.DropIndex(
                name: "IX_VehicleHistories_UsageId",
                table: "VehicleHistories");

            migrationBuilder.DropIndex(
                name: "IX_Units_Name",
                table: "Units");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Units",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "CarAccessories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarAccessories", x => x.Id);
                });
        }
    }
}
