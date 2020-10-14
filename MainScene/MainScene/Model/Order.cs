﻿using System.Collections.Generic;

namespace MainScene.Model
{
    public class Order
    {
        public int OrderIdx { get; set; }
        public bool IsTakeout { get; set; }
        public Table Table { get; set; }
        public Payment Payment { get; set; }
        public List<Product> Products { get; set; }
    }
}
