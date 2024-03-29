﻿using WebStore.DomainNew.Entities.Base.Interfaces;

namespace WebStore.ViewModels
{
    public class BrandViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        /// <summary>
        /// Количество товара данного бренда
        /// </summary>
        public int ProductsCount { get; set; }
    }
}
