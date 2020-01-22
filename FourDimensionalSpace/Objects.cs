using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace FourDimensionalSpace
{
    class Objects : ThreeD 
    {
        public void DrawCube(Pens pen,Voxel vx,int Height,int Width, int Depht)
        {
            Voxel vx1 = vx;
            Voxel vx2 = new Voxel(vx.PX + Width, vx.PY, vx.PZ);
            Voxel vx3 = new Voxel(vx.PX + Width, vx.PY+Height, vx.PZ);
            Voxel vx4 = new Voxel(vx.PX + Width, vx.PY+Height, vx.PZ+Depht);

            Voxel vx5 = new Voxel(vx.PX+Width, vx.PY, vx.PZ+Depht);
            Voxel vx6 = new Voxel(vx.PX, vx.PY + Height, vx.PZ+Depht);
            Voxel vx7 = new Voxel(vx.PX, vx.PY, vx.PZ + Depht);
            Voxel vx8 = new Voxel(vx.PX, vx.PY + Height, vx.PZ);


        }
    }
}
