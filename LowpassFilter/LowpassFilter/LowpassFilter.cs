using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLowpassFilter
{
    public class LowpassFilter
    {
        double Yp;
        double Ypp;
        double Yppp;
        double Xp;
        double Xpp;

        //public static double oneOrder_lowpassFilter(double X, double Yp, double beta)
        public double firstOrder_lowpassFilter(double X, double beta)
        {
            double Y;

            Y = beta * X + (1 - beta) * Yp;
            Yp = Y;

            return Y;
        }

        //public static double twoOrder_lowpassFilter(double X, double Xp, double Ypp, double beta)
        public double secondOrder_lowpassFilter(double X, double beta)
        {
            double Y;

            Y = beta * X + beta * (1 - beta) * Xp + (1 - beta) * (1 - beta) * Ypp;

            Xp = X;
            Ypp = Yp;
            Yp = Y;

            return Y;
        }

        public double thirdOrder_lowpassFilter(double X, double beta)
        {
            double Y;
            
            Y = beta * X + beta * (1 - beta) * Xp + beta * (1 - beta) * (1 - beta) * Xpp + (1 - beta) * (1 - beta) * (1 - beta) * Yppp;

            Xpp = Xp;
            Xp = X;
            Yppp = Ypp;
            Ypp = Yp;
            Yp = Y;

            return Y;
        }

        public void Clear()
        {
            Yp = 0;
            Ypp = 0;
            Yppp = 0;
            Xp = 0;
            Xpp = 0;
        }

    }
}
