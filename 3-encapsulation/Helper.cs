using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_encapsulation
{
    public class Helper
    {
        public int plus(int a, int b) {
            return a + b;
        }

        public int minus(int a, int b) {
            return a - b;
        }

        public double divide(int a, int b) {
            if(b == 0) {
                throw new DivideByZeroException("Cannot divide by zero");
            }

            return (double) a/ b;
        }

        public int multiply(int a, int b) {
            return a * b;
        }

        public void sortArray(int[] n) {
            if(n.Length == 0) {
                throw new ArgumentException("Array is empty");
            }
             Array.Sort(n);
        }

        public void reverseArray(int[] n) {
            if(n.Length == 0){
                throw new ArgumentException("Array is empty");
            }
             Array.Reverse(n);
        }
    }
}