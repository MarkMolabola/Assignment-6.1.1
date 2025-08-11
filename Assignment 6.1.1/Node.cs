using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._1._1
{
    public class Node
    {
        public Houses Value { get; set; }
        public Node Next { get; set; }
        public Node(Houses value)
        {
            Value = value;
            Next = null;
        }
    }
}
