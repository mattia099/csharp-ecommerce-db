using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_ecommerce_db.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_customer_CustomerId",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_CustomerId",
                table: "product");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "product");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "order_product",
                newName: "Quantity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "order_product",
                newName: "quantity");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_product_CustomerId",
                table: "product",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_product_customer_CustomerId",
                table: "product",
                column: "CustomerId",
                principalTable: "customer",
                principalColumn: "Id");
        }
    }
}
