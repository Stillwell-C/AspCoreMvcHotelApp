using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Plugins.DataStore.SQL.Migrations
{
    /// <inheritdoc />
    public partial class Timezone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Timezone",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 1,
                column: "Timezone",
                value: "Asia/Bangkok");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 6,
                column: "Timezone",
                value: "Europe/Dublin");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 10,
                column: "Timezone",
                value: "Europe/Madrid");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 13,
                column: "Timezone",
                value: "America/Santiago");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 15,
                column: "Timezone",
                value: "Europe/London");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 16,
                column: "Timezone",
                value: "Asia/Hong_Kong");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 17,
                column: "Timezone",
                value: "America/Bogota");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 18,
                column: "Timezone",
                value: "Asia/Macau");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 25,
                column: "Timezone",
                value: "Pacific/Auckland");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 33,
                column: "Timezone",
                value: "Europe/Paris");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 34,
                column: "Timezone",
                value: "Europe/Madrid");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 36,
                column: "Timezone",
                value: "Europe/Rome");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 37,
                column: "Timezone",
                value: "America/Mexico_City");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 38,
                column: "Timezone",
                value: "America/Bogota");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 54,
                column: "Timezone",
                value: "Asia/Shanghai");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 59,
                column: "Timezone",
                value: "Asia/Tokyo");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 63,
                column: "Timezone",
                value: "America/New_York");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 66,
                column: "Timezone",
                value: "Asia/Shanghai");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 69,
                column: "Timezone",
                value: "America/New_York");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 71,
                column: "Timezone",
                value: "Europe/Paris");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 75,
                column: "Timezone",
                value: "America/Phoenix");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 78,
                column: "Timezone",
                value: "Europe/Brussels");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 85,
                column: "Timezone",
                value: "Asia/Tokyo");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 94,
                column: "Timezone",
                value: "Asia/Tokyo");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 97,
                column: "Timezone",
                value: "Europe/London");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 99,
                column: "Timezone",
                value: "Asia/Hong_Kong");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 102,
                column: "Timezone",
                value: "Europe/Rome");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 103,
                column: "Timezone",
                value: "Asia/Kolkata");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 107,
                column: "Timezone",
                value: "America/Chicago");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 109,
                column: "Timezone",
                value: "Asia/Tokyo");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 122,
                column: "Timezone",
                value: "Europe/London");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 123,
                column: "Timezone",
                value: "Asia/Kolkata");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 124,
                column: "Timezone",
                value: "Europe/Malta");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 127,
                column: "Timezone",
                value: "Europe/Madrid");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 130,
                column: "Timezone",
                value: "America/Bogota");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 131,
                column: "Timezone",
                value: "Asia/Kolkata");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 132,
                column: "Timezone",
                value: "America/Lima");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 135,
                column: "Timezone",
                value: "Africa/Cairo");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 136,
                column: "Timezone",
                value: "Asia/Tokyo");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 138,
                column: "Timezone",
                value: "Europe/Rome");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 140,
                column: "Timezone",
                value: "Europe/Madrid");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 141,
                column: "Timezone",
                value: "Africa/Nairobi");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 146,
                column: "Timezone",
                value: "Europe/Helsinki");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 147,
                column: "Timezone",
                value: "Europe/Berlin");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 149,
                column: "Timezone",
                value: "Asia/Taipei");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 150,
                column: "Timezone",
                value: "Europe/London");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Hotel_id",
                keyValue: 151,
                column: "Timezone",
                value: "Europe/Sofia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timezone",
                table: "Hotels");
        }
    }
}
