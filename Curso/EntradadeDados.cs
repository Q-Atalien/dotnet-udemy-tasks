﻿
namespace Curso
{
    class EntradadeDados
    {
        public double A;
        public double B;
        public double C;


        public double AreaMaior()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}