﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Mexpense
    {
        public int Itemno { get; set; }
        public string Itemname { get; set; }
        public bool? Active { get; set; }
    }
}