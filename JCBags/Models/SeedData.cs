/*
//  Student Name: Jabin Choi
//  Student ID: 300974443
//  Sec: 008
//  Date: 28th Nov, 2018
//  Title: Assignment 04
*/

using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace JCBags.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Rivington Backpack",
                        Price = 685,
                        Color = "BLACK/BLACK COPPER FINISH",
                        Category = "Backpacks",
                        Description = "This soft backpack is crafted in our lightest weight leather, making it the perfect bag for everyday.",
                        StyleNum = 36080,
                    },
                    new Product
                    {
                        Name = "Metropolitan Portfolio",
                        Price = 550,
                        Color = "CYPRESS/BLACK ANTIQUE NICKEL",
                        Category = "Briefcases",
                        Description = "The Metropolitan Portfolio is a no-fuss bag made for the modern man.",
                        StyleNum = 58097,
                    },
                    new Product
                    {
                        Name = "Rivington Utility Pack",
                        Price = 340,
                        Color = "RED CURRANT/BLACK COPPER FINISH",
                        Category = "Belt Bags",
                        Description = "Rivington mixes downtown cool with professional good looks.",
                        StyleNum = 37951,
                    },
                    new Product
                    {
                        Name = "Rivington Crossbody With Quilting",
                        Price = 375,
                        Color = "HEATHER GREY/BLACK COPPER FINISH",
                        Category = "Messenger Bags",
                        Description = "Crafted in our lightest weight leather with a distinctive quilting design.",
                        StyleNum = 37967,
                    },
                    new Product
                    {
                        Name = "Bleecker Backpack",
                        Price = 750,
                        Color = "BLACK/SADDLE/BLACK COPPER FINISH",
                        Category = "Backpacks",
                        Description = "Equal parts rugged and refined, the Bleecker backpack combines Coach craftsmanship with modern design.",
                        StyleNum = 35939,
                    },
                    new Product
                    {
                        Name = "Rogue Brief",
                        Price = 895,
                        Color = "DARK NAVY/LIGHT ANTIQUE NICKEL",
                        Category = "Briefcases",
                        Description = "Introducing a versatile, hardworking business bag.",
                        StyleNum = 11104,
                    },
                    new Product
                    {
                        Name = "Utility Pack",
                        Price = 375,
                        Color = "BLACK/BLACK COPPER FINISH",
                        Category = "Belt Bags",
                        Description = "Crafted of CORDURA® fabric, a durable material that is resistant to tears, scuffs and abrasions, the Utility Pack is designed for hands-free wear.",
                        StyleNum = 29494,
                    },
                    new Product
                    {
                        Name = "Dylan 27 In Signature Canvas",
                        Price = 455,
                        Color = "KHAKI/BLACK COPPER FINISH",
                        Category = "Messenger Bags",
                        Description = "The Dylan is inspired by flight bags from the 1970s.",
                        StyleNum = 43008,
                    },
                    new Product
                    {
                        Name = "Academy Travel Backpack",
                        Price = 695,
                        Color = "BLACK/BLACK COPPER FINISH",
                        Category = "Backpacks",
                        Description = "The lightweight Travel Backpack is perfect for long journeys with its expandable roll top design.",
                        StyleNum = 32237,
                    },
                    new Product
                    {
                        Name = "Metropolitan Double Zip Business Case",
                        Price = 875,
                        Color = "CHESTNUT/BLACK ANTIQUE NICKEL",
                        Category = "Briefcases",
                        Description = "Perfect for commuting, this two-compartment design in sport calf leather features 28 pockets for organization.",
                        StyleNum = 23791,
                    },
                    new Product
                    {
                        Name = "Academy Pack With Wild Beast Print",
                        Price = 375,
                        Color = "DENIM/BLACK COPPER FINISH",
                        Category = "Belt Bags",
                        Description = "Perfect for hiking, biking, or racing around town, the streamlined Pack has space for everyday essentials, including an iPad.",
                        StyleNum = 32245,
                    },
                    new Product
                    {
                        Name = "Dylan 27 With Landscape Print",
                        Price = 425,
                        Color = "BLACK/MATTE BLACK",
                        Category = "Messenger Bags",
                        Description = "Crafted of CORDURA® fabric, a durable material that is resistant to tears, scuffs and abrasions, the Dylan is inspired by flight bags from the 1970s.",
                        StyleNum = 37332,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
