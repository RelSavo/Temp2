﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurantSystem.POCOS
{
    public class MenuItem
    {
        public string Description { get; set; }
        public decimal CurrentPrice { get; set; }
        public int? Calories { get; set; }
        public string Comment { get; set; }
    }
}
