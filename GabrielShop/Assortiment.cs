using System.Collections.Generic;

namespace GabrielShop
{
    public static class Assortiment
    {
        public static List<Product> products = new List<Product>() {
            new Product()
            {
                name = "Кот",
                source = "avares://GabrielShop/Source/Image1.jpg",
                price = 10000,
                quantity = 0,
                cost = 0
            },
            new Product()
            {
                name = "Не кот",
                source = "avares://GabrielShop/Source/Image2.jpg",
                price = 1000,
                quantity = 0,
                cost = 0
            },
            new Product()
            {
                name = "AAA",
                source = "avares://GabrielShop/Source/Image3.jpg",
                price = 100,
                quantity = 0,
                cost = 0
            }
        };
    }
}