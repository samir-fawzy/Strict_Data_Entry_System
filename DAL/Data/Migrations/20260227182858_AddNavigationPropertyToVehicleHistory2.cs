using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNavigationPropertyToVehicleHistory2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_VehicleHistories_BatterySizeId",
                table: "VehicleHistories",
                column: "BatterySizeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleHistories_EngineId",
                table: "VehicleHistories",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleHistories_ModelId",
                table: "VehicleHistories",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleHistories_PayloadId",
                table: "VehicleHistories",
                column: "PayloadId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleHistories_TireNumberId",
                table: "VehicleHistories",
                column: "TireNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleHistories_TireSizeId",
                table: "VehicleHistories",
                column: "TireSizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleHistories_BatterySizes_BatterySizeId",
                table: "VehicleHistories",
                column: "BatterySizeId",
                principalTable: "BatterySizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleHistories_Engines_EngineId",
                table: "VehicleHistories",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleHistories_Models_ModelId",
                table: "VehicleHistories",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleHistories_Payloads_PayloadId",
                table: "VehicleHistories",
                column: "PayloadId",
                principalTable: "Payloads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleHistories_TireNumbers_TireNumberId",
                table: "VehicleHistories",
                column: "TireNumberId",
                principalTable: "TireNumbers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleHistories_TireSizes_TireSizeId",
                table: "VehicleHistories",
                column: "TireSizeId",
                principalTable: "TireSizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleHistories_BatterySizes_BatterySizeId",
                table: "VehicleHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleHistories_Engines_EngineId",
                table: "VehicleHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleHistories_Models_ModelId",
                table: "VehicleHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleHistories_Payloads_PayloadId",
                table: "VehicleHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleHistories_TireNumbers_TireNumberId",
                table: "VehicleHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleHistories_TireSizes_TireSizeId",
                table: "VehicleHistories");

            migrationBuilder.DropIndex(
                name: "IX_VehicleHistories_BatterySizeId",
                table: "VehicleHistories");

            migrationBuilder.DropIndex(
                name: "IX_VehicleHistories_EngineId",
                table: "VehicleHistories");

            migrationBuilder.DropIndex(
                name: "IX_VehicleHistories_ModelId",
                table: "VehicleHistories");

            migrationBuilder.DropIndex(
                name: "IX_VehicleHistories_PayloadId",
                table: "VehicleHistories");

            migrationBuilder.DropIndex(
                name: "IX_VehicleHistories_TireNumberId",
                table: "VehicleHistories");

            migrationBuilder.DropIndex(
                name: "IX_VehicleHistories_TireSizeId",
                table: "VehicleHistories");
        }
    }
}
