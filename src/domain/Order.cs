﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Ordering.Domain
{
    public class Order : Entity
    {
        public string Name { get; set; }

        public int Number { get; set; }
    }
}
