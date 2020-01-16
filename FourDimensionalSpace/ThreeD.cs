using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDimensionalSpace
{
    class ThreeD
    {
      public List<Voxel> space = new List<Voxel>();

        public Voxel GetVoxel(int index)
        {
            Voxel vx = space[index];
            return vx;
        }

        public bool GetData(int X,int Y, int Z)
        {
            Voxel vx = new Voxel(X, Y, Z);
            bool exist = false;
            return exist;
        }
    }
    class Voxel : ThreeD 
    {
          public  int PX, PY, PZ;


        public Voxel(int X, int Y, int Z)
        {

            PX = X;
            PY = Y;
            PZ = Z;
        }
    }
}
