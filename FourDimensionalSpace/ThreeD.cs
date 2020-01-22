using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FourDimensionalSpace
{
    class ThreeD
    {
      public List<Voxel> space = new List<Voxel>();
        
        public void SetVoxel(Voxel vx)
        {
            space.Add(vx);
        }
        public void SetVoxel(int X,int Y,int Z)
        {
            Voxel vx = new Voxel(X, Y, Z);
            space.Add(vx);
        }
        public Voxel GetVoxel(int index)
        {
            Voxel vx = space[index];
            return vx;
        }

        /*        public bool GetData(int X,int Y, int Z)
                {
                    Voxel vx = new Voxel(X, Y, Z);
                    bool exist = false;
                    return exist;
                } */

        public Point Computing(Voxel p,Camera cam)
        {
            Point point; 
            int px, py, pz;
            px = p.PX; //100
            py = p.PY; //0
            pz = p.PZ; //100
            int cx, cy, cz;
            cx = cam.XPOV;
            cy = cam.YPOV;
            cz = cam.ZPOV;
            int ca, cb, cc;
            ca = cam.APOV;
            cb = cam.BPOV;
            cc = cam.CPOV;
            //pontok koordinátái

            int x, y, z;
            x = px - cx;
            y = py - cy;
            z = pz - cz;

            int w0, w1,h0,h1;
            w0 = x - ca;
            w1 = z - cc;
            h0 = y - cb;
            h1 = z - cc;
            point = new Point(w0- w1+250, h0 - h1+250);
            return point;
        }
    }
    class Voxel
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
