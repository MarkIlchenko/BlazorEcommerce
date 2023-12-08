using BlazorEcommerce.Server.Migrations;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Edition> Editions { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
                );

            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Harry Potter and the Philosopher's Stone1",
                    Description = "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive. Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle. Then, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!",
                    ImageUrl = "https://m.media-amazon.com/images/I/81Fyh2mrw4L._AC_UF894,1000_QL80_.jpg",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Кафе на краю світу",
                    Description = "Зупиніться. Поставте на паузу щоденну метушню, вирвіться з її тенет і зазирніть до кафе на краю світу. Розгорніть меню й придивіться уважніше до останньої сторінки — там ви прочитаєте три запитання, від яких тікали все життя. Чому ви тут? Чи боїтеся ви смерті? Чи вдоволені ви? Ця книжка допоможе у пошуках відповідей. З нею ви запалите вогонь у душі, усвідомите, що цінне, а що — марнота, поглянете на життя під іншим кутом зору, незалежно від набутого досвіду. «Кафе на краю світу» — справжній видавничий феномен, бестселер поза часом, що надихнув мільйони людей у всьому світі на великі зміни. Чарівна, легка й наснажлива, ця книжка вплине на ваш світогляд і назавжди змінить життя.",
                    ImageUrl = "https://static.yakaboo.ua/media/cloudflare/product/webp/600x840/i/m/img_5185.jpg",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Квартира на двох",
                    Description = "Спати в одному ліжку, але ніколи не бачитися? Цілком можливо, якщо ви винаймаєте квартиру з суворою умовою: двом сусідам можна перебувати в ній лише в різний час. Тіффі працює вдень, а Леон — вночі, тож проблем не мало б виникати. Та завдяки раптовій потребі в листуванні між ними зав’язується дружба, а згодом і дещо більше… Чи можливо закохатися в того, кого ніколи не бачив, і довірити йому всі таємниці? І чи готові герої порушити через це всі правила? Ця книжка змусить вас пригадати романтику живого листування, занурить в авантюрні пригоди та підкорить увагою до деталей.",
                    ImageUrl = "https://static.yakaboo.ua/media/cloudflare/product/webp/600x840/i/m/img_59712.jpg",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "The Matrix",
                    Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                },
                    new Product
                    {
                        Id = 5,
                        CategoryId = 2,
                        Title = "Back to the Future",
                        Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                    },
                    new Product
                    {
                        Id = 6,
                        CategoryId = 2,
                        Title = "Toy Story",
                        Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",

                    },
                    new Product
                    {
                        Id = 7,
                        CategoryId = 3,
                        Title = "Half-Life 2",
                        Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",

                    },
                    new Product
                    {
                        Id = 8,
                        CategoryId = 3,
                        Title = "Diablo II",
                        Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                    },
                    new Product
                    {
                        Id = 9,
                        CategoryId = 3,
                        Title = "Day of the Tentacle",
                        Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                    },
                    new Product
                    {
                        Id = 10,
                        CategoryId = 3,
                        Title = "Xbox",
                        Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                    },
                    new Product
                    {
                        Id = 11,
                        CategoryId = 3,
                        Title = "Super Nintendo Entertainment System",
                        Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                    },
                    new Product
                    {
                        Id = 12,
                        CategoryId = 1,
                        Title = "Вісім крафтових історій",
                        Description = "Одного дня у звичайній школі учні отримують зовсім не звичайне завдання від свого учителя інформатики — написати твір про робітничі професії. І не просто твір, а цілу історію, з міфами та легендами, з містичними деталями. Здавалося б, що може бути цікавого в таких спеціальностях? Що саме робить їх незамінними, престижними, загадковими і ненудними? Спершу діти ставляться до цього скептично, але електрик, що виявляється справжнісіньким новітнім Прометеєм, колишній шахтар, що наче той гном із казки шукав колись під землею безцінні скарби, столяр, що вміє розмовляти з деревом, та інші представники професій, де потрібно працювати чи щось виготовляти своїми руками, змушують їх усвідомити, що кожен фах — поважний, престижний і відповідальний.",
                        ImageUrl = "https://static.yakaboo.ua/media/cloudflare/product/webp/600x840/9/7/978-966-448-221-6_2_cr.jpg",
                    }
            );

            modelBuilder.Entity<Edition>().HasData(
                    new Edition { Id = 1, Name = "Default" },
                    new Edition { Id = 2, Name = "Paperback" },
                    new Edition { Id = 3, Name = "E-Book" },
                    new Edition { Id = 4, Name = "Audiobook" },
                    new Edition { Id = 5, Name = "PC" },
                    new Edition { Id = 6, Name = "PlayStation" },
                    new Edition { Id = 7, Name = "Xbox" }
                );


            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 4,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 2,
                    Price = 7.99m,
                    OriginalPrice = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 2,
                    Price = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 1,
                    Price = 166.66m,
                    OriginalPrice = 249.00m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 1,
                    Price = 159.99m,
                    OriginalPrice = 299m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 1,
                    Price = 73.74m,
                    OriginalPrice = 400m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 5,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 6,
                    Price = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 7,
                    Price = 49.99m,
                    OriginalPrice = 59.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    EditionId = 5,
                    Price = 9.99m,
                    OriginalPrice = 24.99m,
                },
                new ProductVariant
                {
                    ProductId = 9,
                    EditionId = 5,
                    Price = 14.99m
                }
            );

            /*modelBuilder.Entity<Edition>().HasData(
                    new Edition { Id = 1, Name = "Paperback" },
                    new Edition { Id = 2, Name = "E-Book" },
                    new Edition { Id = 3, Name = "Audiobook" },
                    new Edition { Id = 4, Name = "PC" },
                    new Edition { Id = 5, Name = "PlayStation" },
                    new Edition { Id = 6, Name = "Xbox" }
                ); */

            /*modelBuilder.SharedTypeEntity<Dictionary<string, object>>("EditionProduct")
                .HasData(
                    new { EditionsId = 1, ProductsId = 1 },
                    new { EditionsId = 2, ProductsId = 1 },
                    new { EditionsId = 3, ProductsId = 1 },
                    new { EditionsId = 1, ProductsId = 2 },
                    new { EditionsId = 2, ProductsId = 2 },
                    new { EditionsId = 4, ProductsId = 7 },
                    new { EditionsId = 5, ProductsId = 7 },
                    new { EditionsId = 6, ProductsId = 7 }
                ); */
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Shared.Stats> Stats { get; set; }
    }
}
