using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{

    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;

    }

    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    } 

    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }


    abstract class Engine { }
    abstract class CarPart { }


    class ElectricEngine : Engine { }
    class GasEngine : Engine { }


    class Battery : CarPart { }
    class Differential : CarPart { }
    class Wheel : CarPart  { }




   


}
