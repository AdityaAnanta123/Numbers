using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public class Numbers
    {
        private int a,b;
        public int FindMinimum(int number1, int number2)
        {
            return number1 < number2 ? number1 : number2;
        }
        public int FindMinimum(int number1, int number2, float number3)
        {
            a = number1 < number3 ? number1 : (int)number3;
            b = number2 < number3 ? number2 : (int)number3;
            return a < b ? a : b;
        }
        public int FindMaximum(int number1, int number2)
        {
            return number1 < number2 ? number2 : number1;
        }
        public int FindMaximum(int number1, int number2, float number3)
        {
            a = number1 < number3 ? (int)number3 : number1;
            b = number2 < number3 ? (int)number3 : number2;
            return a < b ? b : a;
        }
    }
}