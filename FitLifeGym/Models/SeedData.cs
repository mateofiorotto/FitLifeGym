using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FitLifeGym.Data;
using System;
using System.Linq;

namespace FitLifeGym.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new FitLifeGymContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<FitLifeGymContext>>()))
        {
            // Look for any Products.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }
            context.Product.AddRange(
                new Product
                {
                    Name = "Adjustable Dumbbells",
                    Description = "Pair of adjustable dumbbells, perfect for home workouts. Easily change weights from 5kg to 25kg.",
                    Price = 129.99M,
                    Stock = 15,
                    Type = "equipment",
                    ImageUrl = "https://example.com/images/adjustable-dumbbells.jpg"
                },
new Product
{
    Name = "Resistance Bands Set",
    Description = "Set of 5 resistance bands with varying levels of resistance for full-body workouts. Ideal for stretching, strength training, and rehab.",
    Price = 19.99M,
    Stock = 50,
    Type = "equipment",
    ImageUrl = "https://example.com/images/resistance-bands.jpg"
},
new Product
{
    Name = "Yoga Mat",
    Description = "Non-slip yoga mat for comfort during workouts and stretches. Includes a carrying strap for easy portability.",
    Price = 24.99M,
    Stock = 30,
    Type = "equipment",
    ImageUrl = "https://example.com/images/yoga-mat.jpg"
},
new Product
{
    Name = "Protein Powder (Vanilla Flavor)",
    Description = "High-quality whey protein powder to support muscle recovery and growth. 25g of protein per serving.",
    Price = 34.99M,
    Stock = 100,
    Type = "supply",
    ImageUrl = "https://example.com/images/protein-powder.jpg"
},
new Product
{
    Name = "Pre-Workout Supplement",
    Description = "Boost your energy and endurance with this pre-workout formula. Contains caffeine, beta-alanine, and creatine for enhanced performance.",
    Price = 29.99M,
    Stock = 75,
    Type = "supply",
    ImageUrl = "https://example.com/images/pre-workout.jpg"
},
new Product
{
    Name = "Gym Bag",
    Description = "Stylish and spacious gym bag with multiple compartments for your workout gear, shoes, and accessories.",
    Price = 39.99M,
    Stock = 20,
    Type = "equipment",
    ImageUrl = "https://example.com/images/gym-bag.jpg"
},
new Product
{
    Name = "Jump Rope",
    Description = "Durable jump rope for cardio workouts. Adjustable length for all heights, perfect for improving coordination and endurance.",
    Price = 14.99M,
    Stock = 40,
    Type = "equipment",
    ImageUrl = "https://example.com/images/jump-rope.jpg"
},
new Product
{
    Name = "Fitness Tracker Watch",
    Description = "Track your heart rate, calories burned, steps, and more with this sleek fitness tracker. Syncs with your smartphone.",
    Price = 79.99M,
    Stock = 25,
    Type = "equipment",
    ImageUrl = "https://example.com/images/fitness-tracker.jpg"
},
new Product
{
    Name = "Whey Protein Isolate (Chocolate)",
    Description = "High-quality whey protein isolate, perfect for muscle building and fat loss. 27g of protein per serving.",
    Price = 39.99M,
    Stock = 60,
    Type = "supply",
    ImageUrl = "https://example.com/images/whey-protein-isolate.jpg"
},
new Product
{
    Name = "Foam Roller",
    Description = "Foam roller for muscle recovery and massage. Helps reduce soreness and tightness after intense workouts.",
    Price = 22.99M,
    Stock = 50,
    Type = "equipment",
    ImageUrl = "https://example.com/images/foam-roller.jpg"
}
            );
            context.SaveChanges();
        }
    }
}