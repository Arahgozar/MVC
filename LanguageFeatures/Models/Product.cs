﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public class Product
    {
        /*
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        */
//        public string Name { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { set; get; }

    }
}