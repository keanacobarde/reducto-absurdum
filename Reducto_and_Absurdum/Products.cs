﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reducto_and_Absurdum
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public string ProductTypeId { get; set; }
        public DateTime DateStocked { get; set; }

        public int DaysOnShelf
        {
            get
            {
                TimeSpan timeOnShelf = DateTime.Now - DateStocked;
                return timeOnShelf.Days;
            }
        }

    }
}
