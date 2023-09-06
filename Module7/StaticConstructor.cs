using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Измените класс Obj так, чтобы статические поля инициализировались в статическом конструкторе:
namespace Module7
{
    internal class StaticConstructor
    {
        

    }
    class Obj1
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;
        static Obj1()
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;
        }

    }
}
