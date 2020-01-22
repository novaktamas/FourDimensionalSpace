using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDimensionalSpace
{
    class Camera
    {
        public int XPOV, YPOV, ZPOV, APOV, BPOV, CPOV, Lambda;
        public Camera(int X,int Y,int Z,int A, int B, int C, int scale)
        {
            XPOV = X;
            YPOV = Y;
            ZPOV = Z;
            APOV = A;
            BPOV = B;
            CPOV = C;
            Lambda = scale;

        }
    }
}
