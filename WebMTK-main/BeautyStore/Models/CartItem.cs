﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeautyStore.Models
{
    public class CartItem
    {
        BeautyStoreEntities1 db = new BeautyStoreEntities1();
        public int ProductID { get; set; }
        public string NamePro { get; set; }
        public string ImagePro { get; set; }
        public decimal Price { get; set; }
        public int Number { get; set; }


        public decimal FinalPrice()
        {
            return Number * Price;
        }
        public CartItem(int ProductID)
        {
            this.ProductID = ProductID;
            var productDB = db.Products.Single(s => s.ProductID == this.ProductID);
            this.NamePro = productDB.ProductName;
            this.ImagePro = productDB.Image1;
            this.Price = productDB.Price;
            this.Number = 1;
        }
    }
}