using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создайте классы для следующих объектов компьютера: процессор (Processor), материнская карта (MotherBoard), видеокарта (GraphicCard). Унаследуйте их от класса ComputerPart.
//Добавьте в класс ComputerPart абстрактный метод Work без параметров и с типом void.

namespace Module7
{

    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class Processor : ComputerPart
    {
        public override void Work() { }
    }

    class MotherBoard : ComputerPart
    {
        public override void Work() { }
    }

    class GraphicCard : ComputerPart
    {
        public override void Work() { }
    }




}
