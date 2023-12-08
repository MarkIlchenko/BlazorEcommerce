using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class UpdatedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Title", "Views" },
                values: new object[] { 12, 1, "Одного дня у звичайній школі учні отримують зовсім не звичайне завдання від свого учителя інформатики — написати твір про робітничі професії. І не просто твір, а цілу історію, з міфами та легендами, з містичними деталями. Здавалося б, що може бути цікавого в таких спеціальностях? Що саме робить їх незамінними, престижними, загадковими і ненудними? Спершу діти ставляться до цього скептично, але електрик, що виявляється справжнісіньким новітнім Прометеєм, колишній шахтар, що наче той гном із казки шукав колись під землею безцінні скарби, столяр, що вміє розмовляти з деревом, та інші представники професій, де потрібно працювати чи щось виготовляти своїми руками, змушують їх усвідомити, що кожен фах — поважний, престижний і відповідальний.", "https://static.yakaboo.ua/media/cloudflare/product/webp/600x840/9/7/978-966-448-221-6_2_cr.jpg", "Вісім крафтових історій", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
