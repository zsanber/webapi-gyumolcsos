using Microsoft.EntityFrameworkCore.Migrations;
using Solution.Core.Models.Entities;

#nullable disable

namespace Solution.Core.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NutritionInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalCalories = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Carbohydrate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Protein = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fruits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SourceUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 4096, nullable: false),
                    NutritionInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fruits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fruits_NutritionInfo_NutritionInfoId",
                        column: x => x.NutritionInfoId,
                        principalTable: "NutritionInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "NutritionInfo",
                columns: new[] { "Id", "Amount", "TotalCalories", "Carbohydrate", "Protein", "Fat" },
                values: new object[,]
                {
                    { 1, "100gr", "52cal",  "14gr",  "0.3gr",  "0.2gr" },
                    { 2, "100gr", "89cal",  "23gr",  "1.1gr", "0.3gr" },
                    { 3, "100gr", "50cal", "13gr",  "0.5gr", "0.1gr" },
                    { 4, "100gr", "60cal", "15gr", "0.8gr", "0.4gr" },
                    { 5, "100gr", "57cal", "15gr", "0.4gr", "0.1gr" },
                    { 6, "100gr", "61cal", "15gr", "1.1gr", "0.5gr" },
                    { 7, "100gr", "105cal", "14gr", "2.3gr", "1.7gr" },
                    { 8, "100gr", "75cal", "18gr",  "1.7gr", "0.7gr"},
                    { 9, "100gr", "68cal", "15.5gr", "2.7", "0.8gr"}
                });

            migrationBuilder.InsertData(
                table: "Fruits",
                columns: new[] { "Id", "Name", "SourceUrl", "Description", "NutritionInfoId" },
                values: new object[,]
                {
                    {1, "Apple","https://m.media-amazon.com/images/G/01/voicehub/vesper_fruit_skill/licensed_images/Apple.jpg", "Apple- king of all fruits have long been associated with the biblical story of Adam and Eve. Between the Caspin and the Black Sea, the fruit was originated in the Middle East just about 4000 years ago! It is one of the most favorite and popular fruits ever known. As with the well-known adage 'An apple a day keeps a doctor away' the fruit has been doing much good to people who are health conscious. In addition, even the fitness freaks prefer having this wonderful nutrient packed fruit. By all aspects, the fruit is indispensable. Apart from health care and nutrition, it is also known for medicinal values. While the study of apples health benefits dates back to early stages, research to date suggests that its nutrients may play a role in promoting human health in a number of ways",1},
                    {2, "Banana", "https://m.media-amazon.com/images/G/01/voicehub/vesper_fruit_skill/licensed_images/Banana.jpg", "Bananas are great super food which provides us with energy, make us feel full and provide our body with essential nutrients and high amount of fiber. The scientific name of banana is Masa acuminata and Masa balbisiana. It is natural that we always mistake a banana for a plantain. Plantains are a member of the banana family. They are bigger in size and bright green. When compared to bananas plantains are thick skinned. While banana can be eaten raw plantains are not usually eaten raw because of its starch content. They serve an important role in many traditional diets. When used in cooking they are treated more like a vegetable than a fruit. Plantain contains less sugar and so they usually cooked or processed before being eaten. When it is little mature they can be fried, boiled, baked, micro-waved etc. The chips made out of green plantains are one of the favorite dishes in the Southwestern Indian state of Kerala.",2 },
                    {3, "Pineapple", "https://m.media-amazon.com/images/G/01/voicehub/vesper_fruit_skill/licensed_images/Pineapple.jpg", "Pineapple is widely grown in Asia (Thailand,Philippines,Malaysia,China, andIndia), South Central America (Brazil,Costa Rica).Brazilis the world’s largest producer of pineapple, followed byThailand, Phillipines, andCosta Rica. Although some claim that pineapples were brought toSouth Africaby Jan van Riebeeck in 1665, it is more widely accepted that they were introduced toNatalfromCeylon- present daySri Lanka- in the early 19th century. A native to the tropics, the crop requires areas where the climate is warm, humid and free from extreme temperatures (25 °C being the optimal temperature). The fruit is grown all year round, although the sweetness of the fruit varies depending on various conditions. InSouth Africa, pineapples are grown mainly in theEastern Capeand northernKwaZulu-Nataland, to a lesser extent,Limpopo.", 3 },
                    {4, "Mango", "https://m.media-amazon.com/images/G/01/voicehub/vesper_fruit_skill/licensed_images/Mango.jpg", "Mangoes are tropical stone fruits, plump and oval in shape and about the size of a grapefruit. They have an inedible skin that ranges in colour from yellow to green through to red-green, depending on the variety, whilst inside is a soft, edible yellow flesh and a hard inedible stone. Mangoes only grow in warmer climates. They are native to Southern Asia, but they are now grown in other countries including the US, Mexico and the Caribbean. ", 4 },
                    {5, "Pear", "https://m.media-amazon.com/images/G/01/voicehub/vesper_fruit_skill/licensed_images/Pear.jpg", "Pears are fruits produced and consumed around the world, growing on a tree and harvested in the Northern Hemisphere in late summer into October. The pear tree and shrub are a species of genus Pyrus /ˈpaɪrəs/, in the family Rosaceae, bearing the pomaceous fruit of the same name. Several species of pears are valued for their edible fruit and juices, while others are cultivated as trees.", 5},
                    {6, "Kiwi", "https://m.media-amazon.com/images/G/01/voicehub/vesper_fruit_skill/licensed_images/Kiwi.jpg", "Kiwi vines are dioecious, meaning that male and female flowers are borne on separate individuals. Generally, one male plant can facilitate the pollination of three to eight female plants. The ellipsoidal kiwi fruit is a true berry and has furry brownish green skin. The firm translucent green flesh has numerous edible purple-black seeds embedded around a white centre. The deciduous leaves are borne alternately on long petioles (leaf stems), and young leaves are covered with reddish hairs.", 6},
                    {7, "Mandarin", "https://upload.wikimedia.org/wikipedia/commons/6/6a/CSIRO_ScienceImage_7943_Merbeingold_Mandarin.jpg", "Shrub or small tree having flattened globose fruit with very sweet aromatic pulp and thin yellow-orange to flame-orange rind that is loose and easily removed; native to southeastern Asia", 7 },
                    {8, "Cherry", "https://upload.wikimedia.org/wikipedia/commons/f/f6/Cherry_season_%2848216568227%29.jpg", "A cherry is the fruit of many plants of the genus Prunus, and is a fleshy drupe (stone fruit).", 8 },
                    {9, "Watermelon", "https://upload.wikimedia.org/wikipedia/commons/4/47/Taiwan_2009_Tainan_City_Organic_Farm_Watermelon_FRD_7962.jpg", "Watermelon (Citrullus lanatus) is a flowering plant species of the Cucurbitaceae family and the name of its edible fruit. A scrambling and trailing vine-like plant, it is a highly cultivated fruit worldwide, with more than 1,000 varieties.", 9 },
                 });

            migrationBuilder.CreateIndex(
                name: "IX_Fruits_NutritionInfoId",
                table: "Fruits",
                column: "NutritionInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fruits");

            migrationBuilder.DropTable(
                name: "NutritionInfo");
        }
    }
}
