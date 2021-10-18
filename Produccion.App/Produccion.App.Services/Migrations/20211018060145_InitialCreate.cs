using Microsoft.EntityFrameworkCore.Migrations;

namespace Produccion.App.Services.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    identification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_type_identification = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code_product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name_product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_type_product = table.Column<int>(type: "int", nullable: false),
                    date_expiration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_manufacturing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qty_available = table.Column<int>(type: "int", nullable: false),
                    qty_production = table.Column<int>(type: "int", nullable: false),
                    qty_order = table.Column<int>(type: "int", nullable: false),
                    lote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProductionOrder",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code_order = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_delivery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_status_op = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionOrder", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PurchanseOrder",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    num_oc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_customer = table.Column<int>(type: "int", nullable: false),
                    id_status_oc = table.Column<int>(type: "int", nullable: false),
                    date_delivery = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchanseOrder", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductionOrder");

            migrationBuilder.DropTable(
                name: "PurchanseOrder");
        }
    }
}
