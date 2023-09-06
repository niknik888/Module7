using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Создайте класс Helper и определите в нем статический метод Swap типа void, который принимает 2 переменные типа int и меняет их значения местами.
namespace Module7
{
    internal class Helper
    {
        public static void Swap(ref int a1, ref int a2)
        { 
            int temp = a1;
            a1 = a2;
            a2 = temp;
        }
    }
}
