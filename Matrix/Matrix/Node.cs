using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Node<T>
    {
        public T element;
        public Node<T> fils_g;
        public Node<T> fils_d;

        public Node(T value)
        {
            this.element = value;
            this.fils_g = null;
            this.fils_d = null;
        }

    }
}
