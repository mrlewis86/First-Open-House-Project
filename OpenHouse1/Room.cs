﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHouse1
{
    class Room
    {
        public string Name { get; set; }
        public List<string> Descriptions { get; set; } = new List<string>();
        public List<Furniture> Furnitures { get; set; } = new List<Furniture>();
    }
}
