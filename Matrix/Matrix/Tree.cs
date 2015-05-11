using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Tree<T>
    {
        delegate int CompType(T a, T b);
        delegate void MapFunction(ref T elt);

        public CompType comp_type;
        Node<T> racine;


        public Tree(CompType comp, T value)
        {
            racine = new Node<T>(value);
            comp_type = comp;
        }



        public void depth_first_traversal(MapFunction function) //profondeur
        {
            function(ref racine.element);
            if (racine.fils_g != null)
                depth_first_traversal(function);
            if(racine.fils_d != null)
                depth_first_traversal(function);
        }


        public void breadth_first_traversal(MapFunction function) //largeur
        {

        }

    }
}
