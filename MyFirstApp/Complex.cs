using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Maths{
    internal class Complex{
        private int real,imag;

        public Complex()
        {
            this.real=0;
            this.imag=0;
        }
        public Complex(int r,int i){
            this.real=r;
            this.imag=i;
        }

        public override string ToString()
        {
            if(imag>0)
                return this.real + " + "+ this.imag+ "i";
            else
                return this.real + " - "+ this.imag+ "i";
        }
        public static Complex operator +(Complex left,Complex right){
            Complex temp=new Complex();
            temp.real=left.real+right.real;
            temp.imag=left.imag+right.imag;
            return temp;
        }
        public static Complex operator -(Complex left,Complex right){
            Complex temp = new Complex();
            temp.real = left.real - right.real;
            temp.imag = left.imag - right.imag;
            return temp;
        }
    }
}