using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        internal Node NextNode;
        internal Node PrevNode;
        internal object Content;

        internal Node(object content)
        {
            this.Content = content;
        }
    }
}
