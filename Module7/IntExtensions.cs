using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Для класса int создайте 2 метода расширения: GetNegative() и GetPositive().

//Метод GetNegative должен возвращать отрицательное значение переменной (если оно положительно), либо саму переменную (если оно отрицательно или равно 0).

//Метод GetPositive должен, наоборот, возвращать положительное значение (если оно отрицательно), либо саму переменную (если оно положительно или равно 0).



namespace Module7
{
    static class IntExtensions
    {
        public static int GetNegative(this int num)
        {
            if (num > 0)
            {
                return -num;
            }
            else
            {
                return num;
            }

        }

        public static int GetPositive(this int num)
        {
            if (num < 0)
            {
                return -num;
            }
            else
            {
                return num;
            }

        }
    }
}

