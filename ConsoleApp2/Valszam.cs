using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class WithoutLambda
    {
        private double lambda;
        private double ex;
        private double t;

        public WithoutLambda(double _ex, double _t)
        {
            t = _t;
            ex = _ex;
            lambda = 1 / _ex;
        }
        
        public void exponencialis()
        {
            double ft = 1 - Math.Pow(Math.E, -lambda * t);
            Console.WriteLine("Valószínűség, ha hamarabb: " + ft);
            Console.WriteLine("Valószínűség, ha később: " + (1 - ft));
        }
    }

    class WithLambda
    {
        private double lambda;
        private double ex;
        private double t;

        public WithLambda(double _lambda, double _t)
        {
            t = _t;
            lambda = _lambda;
            ex = 1 / lambda;        
        }

        public void exponencialis()
        {
            double ft = 1 - Math.Pow(Math.E, -lambda * t);
            Console.WriteLine("Valószínűség, ha hamarabb: " + ft);
            Console.WriteLine("Valószínűség, ha később: " + (1 - ft));
        }
    }

    class Combo
    {
        private double lambda;
        private double ex;
        private double t1;
        private double t2;

        public Combo(double _ex, double _t1, double _t2)
        {
            t1 = _t1;
            t2 = _t2;
            ex = _ex;
            lambda = 1 / _ex;
        }

        public void exponencialis()
        {
            double ft1 = 1 - Math.Pow(Math.E, -lambda * t1);
            double ft2 = 1 - Math.Pow(Math.E, -lambda * t2);
            Console.WriteLine("Valószínűség: " + (ft1 - ft2));
        }
    }

    class Reverse
    {
        private double lambda;
        private double ex;
        private double ft;
        private double t;

        public Reverse(double _ex, double p)
        {
            ft = p;
            ex = _ex;
            lambda = 1 / _ex;

        }

        public void exponencialis()
        {
            t = Math.Abs(Math.Log(1 - ft) / lambda);
            Console.WriteLine("Valószínűség: " + t);
        }
    }
}
