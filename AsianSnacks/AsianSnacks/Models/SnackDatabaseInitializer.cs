using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Diagnostics;
namespace AsianSnacks.Models
{
    public class SnackDatabaseInitializer:DropCreateDatabaseIfModelChanges<SnackContext>
    {
        protected override void Seed(SnackContext context)
        {
            
            GetCategories().ForEach(c => context.Categories.Add(c));
            Debug.Write("initialize2");
            GetSnacks().ForEach(p => context.Snacks.Add(p));
            Debug.Write("initialize");
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>{
                new Category{
                    CategoryID = 1,
                    CategoryName = "Gummies"
                },
                new Category{
                    CategoryID = 2,
                    CategoryName ="Candy"
                },
                new Category{
                    CategoryID = 3,
                    CategoryName = "RiceCracker"
                },
                new Category{
                    CategoryID = 4,
                    CategoryName = "Chips"
                },
                new Category{
                    CategoryID = 5,
                    CategoryName = "Yokan"
                },
                new Category{
                    CategoryID = 6,
                    CategoryName = "Pocky"
                },
            };
            return categories;
        }

        private static List<Snack> GetSnacks()
        {
            var snacks = new List<Snack>{
                new Snack{
                    SnackID = 1,
                    SnackName = "Mangosteen Gummy Candy",
                    Description = "Kasugai gummies are not your ordinary gummy. They are individually wrapped gourmet gummies made with real fruit juice. Each gummy is packed with a burst of refreshing fruit flavor and a most pleasant aroma.",
                    ImagePath = "gummy1.jpg",
                    UnitPrice = 2.99,
                    CategoryID = 1
                },
                new Snack{
                    SnackID = 2,
                    SnackName = "Muscat Gummy",
                    Description = "Kasugai gummies are not your ordinary gummy. They are individually wrapped gourmet gummies made with real fruit juice. Each gummy is packed with a burst of refreshing fruit flavor and a most pleasant aroma.",
                    ImagePath = "gummy2.jpg",
                    UnitPrice = 2.99,
                    CategoryID = 1
                },
                new Snack{
                    SnackID = 3,
                    SnackName = "Strawberry Gummy",
                    Description = "Kasugai gummies are not your ordinary gummy. They are individually wrapped gourmet gummies made with real fruit juice. Each gummy is packed with a burst of refreshing fruit flavor and a most pleasant aroma.",
                    ImagePath = "gummy3.jpg",
                    UnitPrice = 2.99,
                    CategoryID = 1
                },
                new Snack{
                    SnackID = 4,
                    SnackName = "Mango Gummy",
                    Description = "Kasugai gummies are not your ordinary gummy. They are individually wrapped gourmet gummies made with real fruit juice. Each gummy is packed with a burst of refreshing fruit flavor and a most pleasant aroma.",
                    ImagePath = "gummy4.jpg",
                    UnitPrice = 2.99,
                    CategoryID = 1
                },
                new Snack{
                    SnackID = 5,
                    SnackName = "Peach Gummy Candy",
                    Description = "Kasugai gummies are not your ordinary gummy. They are individually wrapped gourmet gummies made with real fruit juice. Each gummy is packed with a burst of refreshing fruit flavor and a most pleasant aroma.",
                    ImagePath = "gummy5.jpg",
                    UnitPrice = 2.99,
                    CategoryID = 1
                },
                new Snack{
                    SnackID = 6,
                    SnackName = "Strawberry Marshmallow",
                    Description = "This Hello Kitty treat is one of the most unique fusion candies you’ll try. It has an exterior texture like a thick marshmallow, and a creamy strawberry fruit filling. There are several marshmallow balls to a bag, so you can spread the treats around or keep them all to yourself!",
                    ImagePath = "candy1.jpg",
                    UnitPrice = 2.39,
                    CategoryID = 2
                },
                new Snack{
                    SnackID = 7,
                    SnackName = "Fujiya Pop Candy",
                    Description = "Delicious pack of Fujiya milk flavored lollipops.",
                    ImagePath = "candy2.jpg",
                    UnitPrice = 3.98,
                    CategoryID = 2
                },
                new Snack{
                    SnackID = 8,
                    SnackName = "White Rabbit",
                    Description = "Delicious milk candy.",
                    ImagePath = "candy3.jpg",
                    UnitPrice = 2.98,
                    CategoryID = 2
                },
                new Snack{
                    SnackID = 9,
                    SnackName = "KitKat Matcha Flavor",
                    Description = "Delicious milk candy.",
                    ImagePath = "candy4.jpg",
                    UnitPrice = 4.97,
                    CategoryID = 2
                },
                new Snack{
                    SnackID = 10,
                    SnackName = "Uni Suki Rice Crackers",
                    Description = "Crispy salty rice cracker clusters flavored with the unique taste of sea urchin.",
                    ImagePath = "ricecracker1.jpg",
                    UnitPrice = 4.18,
                    CategoryID = 3
                },
                new Snack{
                    SnackID = 11,
                    SnackName = "Wakabato Iso Ikakotsuru Cracker",
                    Description = "These circle crackers are full of flavor and texture. With a slightly spicy sea taste covered in seaweed bits, it is a nice salty and crunchy snack.",
                    ImagePath = "ricecracker2.jpg",
                    UnitPrice = 2.39,
                    CategoryID = 3
                },
                new Snack{
                    SnackID = 12,
                    SnackName = "Wakabato Iso Hineri Cracker",
                    Description = "These twisted crackers are full of flavor and texture. With a nice sea taste covered in seaweed bits, it is a nice salty and crunchy snack.",
                    ImagePath = "ricecracker3.jpg",
                    UnitPrice = 2.39,
                    CategoryID = 3
                },
                new Snack{
                    SnackID = 13,
                    SnackName = "Yamawaki Gyunyu Karinto Cracker",
                    Description = "Gokujyo Karinto Cracker is a unique and delicious treat with lots of crunch! It's a deep fried Japanese snack flavored with sweet milk and honey glaze. Specked with sugar, the taste is similar to Cracker Jacks. You will absolutely love these!",
                    ImagePath = "ricecracker4.jpg",
                    UnitPrice = 3.28,
                    CategoryID = 3
                },
                new Snack{
                    SnackID = 14,
                    SnackName = "Gokujyo Brown Sugar Karinto",
                    Description = "Sweet and crunchy deep fried Japanese snack flavored with caramelized brown sugar.",
                    ImagePath = "ricecracker5.jpg",
                    UnitPrice = 3.49,
                    CategoryID = 3
                },
                new Snack{
                    SnackID = 15,
                    SnackName = "Good Good Chicken Souce",
                    Description = "Delicious crackers",
                    ImagePath = "chipscracker1.jpg",
                    UnitPrice = 5.28,
                    CategoryID = 4
                },
                new Snack{
                    SnackID = 16,
                    SnackName = "Good Good Eat Chocolate",
                    Description = "These Chocolate flavor Japanese ramen noodle wheat crackers contain no preservatives and no artificial flavors. They are crunchy, delicious, and look like bundles of ramen noodles to boot!",
                    ImagePath = "chipscracker2.jpg",
                    UnitPrice = 5.28,
                    CategoryID = 4
                },
                new Snack{
                    SnackID = 17,
                    SnackName = "Good Good Eat Black Pepper",
                    Description = "Delicious crackers",
                    ImagePath = "chipscracker3.jpg",
                    UnitPrice = 5.28,
                    CategoryID = 4
                },
                new Snack{
                    SnackID = 18,
                    SnackName = "Oishi Sweet Corn Puff",
                    Description = "Delicious crackers",
                    ImagePath = "chipscracker4.jpg",
                    UnitPrice = 4.28,
                    CategoryID = 4
                },
                new Snack{
                    SnackID = 19,
                    SnackName = "Lonely God Popcorns",
                    Description = "Delicious crackers",
                    ImagePath = "chipscracker5.jpg",
                    UnitPrice = 4.28,
                    CategoryID = 4
                },
                new Snack{
                    SnackID = 20,
                    SnackName = "Good Good Eat BBQ",
                    Description = "Delicious crackers",
                    ImagePath = "chipscracker6.jpg",
                    UnitPrice = 5.28,
                    CategoryID = 4
                },
                new Snack{
                    SnackID = 21,
                    SnackName = "Mini Yokan Neri",
                    Description = "Delicious Yokan",
                    ImagePath = "yokan1.jpg",
                    UnitPrice = 4.58,
                    CategoryID = 5
                },
                new Snack{
                    SnackID = 22,
                    SnackName = "Mini Yokan Ogura",
                    Description = "Delicious Yokan",
                    ImagePath = "yokan2.jpg",
                    UnitPrice = 4.58,
                    CategoryID = 5
                },
                new Snack{
                    SnackID = 23,
                    SnackName = "Panda Pocky Cookies",
                    Description = "The flavor is Cookies and Cream. It has an inner stick of chocolate, and a creamy frosting coating with specks of crunchy wafer flakes. It offers an authentic take on cookies and cream, and provides the kind of delicious taste and texture that first made Pocky famous.",
                    ImagePath = "pocky1.jpg",
                    UnitPrice = 1.58,
                    CategoryID = 6
                },
                new Snack{
                    SnackID = 24,
                    SnackName = "Glico Chocolate Pocky",
                    Description = "Introducing the Thai version of Pocky’s very first flavor, Chocolate!!! We recently brought in several Thai Pocky products and this one has really captured the authentic flavor of original Pocky.",
                    ImagePath = "pocky2.jpg",
                    UnitPrice = 1.58,
                    CategoryID = 6
                },
                new Snack{
                    SnackID = 25,
                    SnackName = "Glico Pretz Salad",
                    Description = "These Pretz come with a uniquely delicious taste that may just be addictive. The party size comes with 150 sticks, and is a great idea for the next family get together. Use them as breadsticks to accompany a salad.",
                    ImagePath = "pocky3.jpg",
                    UnitPrice = 1.58,
                    CategoryID = 6
                },
                new Snack{
                    SnackID = 26,
                    SnackName = "Pejoy Chocolate",
                    Description = " It even looks like a more mature snack alternative to Pocky. The chocolate filling combined with buttery biscuit creates a lovely crunch. Grab a pack and share with your friends!",
                    ImagePath = "pocky4.jpg",
                    UnitPrice = 1.28,
                    CategoryID = 6
                },
                new Snack{
                    SnackID = 27,
                    SnackName = "Pocky Matcha",
                    Description = "The matcha green tea Pocky is one of the most sought after flavors, and now we have them! The crunchy biscuit stick is coated with a smooth layer of sweet green tea cream.",
                    ImagePath = "pocky5.jpg",
                    UnitPrice = 1.28,
                    CategoryID = 6
                },
                new Snack{
                    SnackID = 28,
                    SnackName = "Almond Crush Pocky",
                    Description = "Chocolate Almond Crush Pocky sticks are a unique variation on the original Pocky idea. They are covered in rich chocolate cream, then dipped in crushed almonds and then covered in more chocolate!",
                    ImagePath = "pocky6.jpg",
                    UnitPrice = 2.39,
                    CategoryID = 6
                }
            };
            return snacks;
        }
    }
}