using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive. Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle. Then, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", "https://m.media-amazon.com/images/I/81Fyh2mrw4L._AC_UF894,1000_QL80_.jpg", 7.99m, "Harry Potter and the Philosopher's Stone1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Зупиніться. Поставте на паузу щоденну метушню, вирвіться з її тенет і зазирніть до кафе на краю світу. Розгорніть меню й придивіться уважніше до останньої сторінки — там ви прочитаєте три запитання, від яких тікали все життя. Чому ви тут? Чи боїтеся ви смерті? Чи вдоволені ви? Ця книжка допоможе у пошуках відповідей. З нею ви запалите вогонь у душі, усвідомите, що цінне, а що — марнота, поглянете на життя під іншим кутом зору, незалежно від набутого досвіду. «Кафе на краю світу» — справжній видавничий феномен, бестселер поза часом, що надихнув мільйони людей у всьому світі на великі зміни. Чарівна, легка й наснажлива, ця книжка вплине на ваш світогляд і назавжди змінить життя.", "https://static.yakaboo.ua/media/cloudflare/product/webp/600x840/i/m/img_5185.jpg", 9.99m, "Кафе на краю світу" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Спати в одному ліжку, але ніколи не бачитися? Цілком можливо, якщо ви винаймаєте квартиру з суворою умовою: двом сусідам можна перебувати в ній лише в різний час. Тіффі працює вдень, а Леон — вночі, тож проблем не мало б виникати. Та завдяки раптовій потребі в листуванні між ними зав’язується дружба, а згодом і дещо більше… Чи можливо закохатися в того, кого ніколи не бачив, і довірити йому всі таємниці? І чи готові герої порушити через це всі правила? Ця книжка змусить вас пригадати романтику живого листування, занурить в авантюрні пригоди та підкорить увагою до деталей.", "https://static.yakaboo.ua/media/cloudflare/product/webp/600x840/i/m/img_59712.jpg", 5.99m, "Квартира на двох" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
