﻿using System;
using System.Collections.Generic;
using WebStore.Domain.Entities;
using WebStore.Infrasructure.Interfaces;

namespace WebStore.Infrasructure.Services
{
    public class MemoryProductService : IProductService
    {
        private readonly List<Section> _sections;
        private readonly List<Brand> _brands;

        public MemoryProductService()
        {
            _sections = new List<Section>
            {
                new Section
                {
                    Id = 1,
                    Name = "Sportswear",
                    Order = 0,
                    ParentId = null
                },
                new Section
                {
                    Id = 2,
                    Name = "Nike",
                    Order = 0,
                    ParentId = 1
                },
                new Section
                {
                    Id = 3,
                    Name = "Under Armour",
                    Order = 1,
                    ParentId = 1
                },
                new Section
                {
                    Id = 4,
                    Name = "Adidas",
                    Order = 2,
                    ParentId = 1
                },
                new Section
                {
                    Id = 5,
                    Name = "Puma",
                    Order = 3,
                    ParentId = 1
                },
                new Section
                {
                    Id = 6,
                    Name = "ASICS",
                    Order = 4,
                    ParentId = 1
                },
                new Section
                {
                    Id = 7,
                    Name = "Mens",
                    Order = 1,
                    ParentId = null
                },
                new Section
                {
                    Id = 8,
                    Name = "Fendi",
                    Order = 0,
                    ParentId = 7
                },
                new Section
                {
                    Id = 9,
                    Name = "Guess",
                    Order = 1,
                    ParentId = 7
                },
                new Section
                {
                    Id = 10,
                    Name = "Valentino",
                    Order = 2,
                    ParentId = 7
                },
                new Section
                {
                    Id = 11,
                    Name = "Dior",
                    Order = 3,
                    ParentId = 7
                },
                new Section
                {
                    Id = 12,
                    Name = "Versace",
                    Order = 4,
                    ParentId = 7
                },
                new Section
                {
                    Id = 13,
                    Name = "Armani",
                    Order = 5,
                    ParentId = 7
                },
                new Section
                {
                    Id = 14,
                    Name = "Prada",
                    Order = 6,
                    ParentId = 7
                },
                new Section
                {
                    Id = 15,
                    Name = "Dolce and Gabbana",
                    Order = 7,
                    ParentId = 7
                },
                new Section
                {
                    Id = 16,
                    Name = "Chanel",
                    Order = 8,
                    ParentId = 7
                },
                new Section
                {
                    Id = 17,
                    Name = "Gucci",
                    Order = 1,
                    ParentId = 7
                },
                new Section
                {
                    Id = 18,
                    Name = "Womens",
                    Order = 2,
                    ParentId = null
                },
                new Section
                {
                    Id = 19,
                    Name = "Fendi",
                    Order = 0,
                    ParentId = 18
                },
                new Section
                {
                    Id = 20,
                    Name = "Guess",
                    Order = 1,
                    ParentId = 18
                },
                new Section
                {
                    Id = 21,
                    Name = "Valentino",
                    Order = 2,
                    ParentId = 18
                },
                new Section
                {
                    Id = 22,
                    Name = "Dior",
                    Order = 3,
                    ParentId = 18
                },
                new Section
                {
                    Id = 23,
                    Name = "Versace",
                    Order = 4,
                    ParentId = 18
                },
                new Section
                {
                    Id = 24,
                    Name = "Kids",
                    Order = 3,
                    ParentId = null
                },
                new Section
                {
                    Id = 25,
                    Name = "Fashion",
                    Order = 4,
                    ParentId = null
                },
                new Section
                {
                    Id = 26,
                    Name = "Households",
                    Order = 5,
                    ParentId = null
                },
                new Section
                {
                    Id = 27,
                    Name = "Interiors",
                    Order = 6,
                    ParentId = null
                },
                new Section
                {
                    Id = 28,
                    Name = "Clothing",
                    Order = 7,
                    ParentId = null
                },
                new Section
                {
                    Id = 29,
                    Name = "Bags",
                    Order = 8,
                    ParentId = null
                },
                new Section
                {
                    Id = 30,
                    Name = "Shoes",
                    Order = 9,
                    ParentId = null
                }
            };
            _brands = new List<Brand>
            {
                new Brand
                {
                    Id = 1,
                    Name = "Acne",
                    Order = 0
                },
                new Brand
                {
                    Id = 2,
                    Name = "Grüne Erde",
                    Order = 1
                },
                new Brand
                {
                    Id = 3,
                    Name = "Albiro",
                    Order = 2
                },
                new Brand
                {
                    Id = 4,
                    Name = "Ronhill",
                    Order = 3
                },
                new Brand
                {
                    Id = 5,
                    Name = "Oddmolly",
                    Order = 4
                },
                new Brand
                {
                    Id = 6,
                    Name = "Boudestijn",
                    Order = 5
                },
                new Brand
                {
                    Id = 7,
                    Name = "Rösch creative culture",
                    Order = 6
                }
            };
        }

        public IEnumerable<Section> GetSections()
        {
            return _sections;
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _brands;
        }
    }
}