using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon3
{
    class Coordinate
    {


        private int up;
        private int down;
        private int lefe;
        private int right;

        int _x =0;
        int _y =0;

       
        public int coordinateX(int up, int down)
        {

            return _y + up - down;
        }

        public int coordinateY(int left, int right)
        {
            return _x + right - left;
        }

    }
}
