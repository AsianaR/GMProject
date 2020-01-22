﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Binary3
{
    public class Node
    {
        public int value { get; private set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node()
        {
        }
        public Node(int value)
        {
            this.value = value;
        }
    }
}
