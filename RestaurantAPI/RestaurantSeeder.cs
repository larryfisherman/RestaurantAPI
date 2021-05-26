﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantAPI.Entities;

namespace RestaurantAPI
{
    public class RestaurantSeeder
    {
        private readonly RestaurantDbContext _dbContext;
        public RestaurantSeeder(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            if(_dbContext.Database.CanConnect())
            {
                if(!_dbContext.Restaurants.Any())
                {
                    var restaurants = GetRestaurants();
                    _dbContext.Restaurants.AddRange(restaurants);
                    _dbContext.SaveChanges();
                }
            }
        }
        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Name = "KFC",
                    Category = "Fast Food",
                    Description = "KFC (short for Kentucy Fried Chicken) is an American fast food restaurant chain headquartered...",
                    ContactEmail = "contact@kfc.com",
                    ContactNumber = "61616161",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Nashville Hot Chicken",
                            Decimal = 10.30M,
                        },
                        new Dish()
                        {
                            Name = "Chicken Nuggets",
                            Decimal = 5.30M
                        },
                    },
                    Address = new Address()
                    {
                        City = "Kraków",
                        Street = "Długa 5",
                        PostalCode = "30-001"
                    },
                },

                new Restaurant()
                {
                    Name = "McDonald",
                    Category = "Fast Food",
                    Description = "McDonald USA yummy yumm",
                    ContactEmail = "contact@mcDonald.com",
                    ContactNumber = "61616161",
                    HasDelivery = false,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "BigMac",
                            Decimal = 10.00M
                        },
                        new Dish()
                        {
                            Name = "McRoyal",
                            Decimal = 12.00M
                        }
                    },
                     Address = new Address ()
                        {
                            City = "Kraków",
                            Street = "Długa 66",
                            PostalCode = "30-001"
                        }
                }
                
            };
            return restaurants;
        }
    }
}
