﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compiler errors! Value types cannot be set to null!
            bool myBool = null;
            int myInt = null;

            // OK! Strings are reference types.
            string myString = null;
        }
    }
}
