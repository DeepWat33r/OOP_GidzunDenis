using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7CSharp
{
    public class Node
    {
        public Node(float data)
        {
            Data = data;
        }
        public float Data { get; set; }
        public Node Next { get; set; }
    }
}
