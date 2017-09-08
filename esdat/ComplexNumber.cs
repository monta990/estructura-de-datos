using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esdat
{
    class ComplexNumber
    {
        private double real;
        private double imaginary;
        public ComplexNumber(double real, double imaginary)
        {
            //SetReal(GetReal);
        }
        public void SetReal(double value)
        {
            this.real = value;
        }
        public double GetReal()
        {
            return this.real;
        }
        public void SetImaginary(double value)
        {
            this.imaginary = value;
        }
        public void GetImaginary(double value)
        {

        }
    }
}
