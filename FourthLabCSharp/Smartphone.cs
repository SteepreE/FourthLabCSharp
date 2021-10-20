using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthLabCSharp
{
    class Smartphone : Gadget
    {
        private int _simcardsCount;
        private int _megaPixelesCount;

        public Smartphone(Producer producer, OC operatingSystem,
            int storageCapacity, int simcardsCount, int megaPixelesCount) : base(producer, operatingSystem, storageCapacity)
        {
            _simcardsCount = simcardsCount;
            _megaPixelesCount = megaPixelesCount;
            _imgSrc = "Smartphone.png";
        }

        public override string ToString()
        {
            return "Смартфон " + _producer;
        }

        public override String GetInfo()
        {
            String info = this + " " + _storageCapacity + "gb\n" +
                          "Количество сим карт: " + _simcardsCount + "\n" +
                          "Количество магипкселей: " + _megaPixelesCount + "\n" +
                          "Операционная система: " + _operatingSystem + "\n";

            return info;
        }
    }
}
