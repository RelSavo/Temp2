﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * THIS IS CONSIDERED A FLAT FILE AND HAS NO COLLETIONS OF DATA.
 * (ie. IEnumerable, NAVIGATION)
 * 
 */ 


namespace eRestaurantSystem.POCOs
{
    public class CategoryMenuItems
    {
        public string CategoryDescription { get; set; }
        public string ItemDescription { get; set; }
        public decimal Price { get; set; }
        public int? Calories { get; set; }
        public string Comment { get; set; }
    }
}
