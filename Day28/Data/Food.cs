﻿using System;
using System.Collections.Generic;

namespace Day28.Data
{
    public partial class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FoodCategory Category { get; set; }
    }
}
