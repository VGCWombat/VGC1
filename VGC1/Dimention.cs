﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGC1
{
    public class Dimention
    {
        private int x;
        private int y;

        public Dimention(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
    }
}
