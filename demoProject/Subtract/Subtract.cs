﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoProject.Subtract
{
    public class SubtractIntegers
    {
        int a;
        int b;

        public SubtractIntegers()
        {
            this.a = 0;
            this.b = 0;
        }
        public SubtractIntegers(int a, int b) {
            this.a = a;
            this.b = b;
        }

        public int SubtractNumbers(int a, int b) {
            return a - b;
        }
    }
}
