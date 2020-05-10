using System;
using System.Collections.Generic;
using System.Text;

namespace Complex_Demo
{
    internal class Complex
    {
        private double iReal, iImag;
        public Complex(double iReal, double iImag)
        {
            this.iReal = iReal;
            this.iImag = iImag;
        }
        public static Complex operator +(Complex z1, Complex z2)
            => new Complex(z1.iReal + z2.iReal, z1.iImag + z2.iImag);
        public static Complex operator -(Complex z1, Complex z2)
            => new Complex(z1.iReal - z2.iReal, z1.iImag - z2.iImag);
        public static Complex operator +(double n, Complex z1)
            => new Complex(z1.iReal + n, z1.iImag);
        public static Complex operator +(Complex z1, double n)
            => n + z1;
        public static Complex operator -(double n, Complex z1)
            => new Complex(z1.iReal - n, z1.iImag);
        public static Complex operator -(Complex z1, double n)
            => new Complex(n - z1.iReal, z1.iImag);
        public static Complex operator -(Complex z1)
            => new Complex(-z1.iReal, -z1.iImag);
        public static bool operator ==(Complex z1, Complex z2)
            => z1.iReal == z2.iReal && z1.iImag == z2.iImag;
        public static bool operator !=(Complex z1, Complex z2)
            => z1.iReal != z2.iReal || z1.iImag != z2.iImag;
        public static Complex operator *(Complex z1, Complex z2) 
            => new Complex(z1.iReal * z2.iReal - z1.iImag * z2.iImag, z1.iReal * z2.iImag + z2.iReal * z1.iImag);
        public static Complex operator *(double n, Complex z)
            => new Complex(z.iReal * n, n * z.iImag);
        public static Complex operator *(Complex z, double n)
            => n * z;
        public static Complex operator /(Complex z1, Complex z2)
        {
            double imagen, real;
            real = (z1.iReal * z2.iReal + z1.iImag * z2.iImag) / (Math.Pow(z2.iReal,2) + Math.Pow(z2.iImag, 2));
            imagen = (z2.iReal * z1.iImag - z1.iReal * z2.iImag) / (Math.Pow(z2.iReal, 2) + Math.Pow(z2.iImag, 2));
            return new Complex(real, imagen);
        }
        public static Complex operator /(Complex z1, double n)
            => new Complex((z1.iReal * n) / Math.Pow(n, 2), (n * z1.iImag) / Math.Pow(n, 2));
        public static Complex operator /(double n, Complex z1) //TODU: Поправить! Так это не работает!!!!
            => new Complex( (n*z1.iReal)/(Math.Pow(z1.iReal,2) + Math.Pow(z1.iImag, 2)) , (-n * z1.iImag)/(Math.Pow(z1.iReal, 2) + Math.Pow(z1.iImag, 2)));

        public override string ToString()
        {
            string complex_to_string; 
            if (this.iImag < 0)
                complex_to_string = $"[{iReal} - {-iImag}i]";
            else complex_to_string = $"[{iReal} + {iImag}i]";
            return complex_to_string;
        }
    }
}
