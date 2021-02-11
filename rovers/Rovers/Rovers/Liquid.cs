﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rovers
{
    public class Liquid
    {
        public string name { get; set; }

        public static readonly Liquid A = new Liquid() { name = "A" };
        public static readonly Liquid B = new Liquid() { name = "B" };
        public static readonly Liquid C = new Liquid() { name = "C" };
        public static readonly Liquid D = new Liquid() { name = "D" };

    }
}
