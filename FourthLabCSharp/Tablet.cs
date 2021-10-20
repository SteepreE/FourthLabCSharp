using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthLabCSharp
{
    class Tablet : Gadget
    {
        private bool _isHaveKeyboard;
        private bool _isHaveCam;

        public Tablet(Producer producer, OC operatingSystem,
            int storageCapacity, bool isHaveKeyboard, bool isHaveCam) : base(producer, operatingSystem, storageCapacity)
        {
            _isHaveKeyboard = isHaveKeyboard;
            _isHaveCam = isHaveCam;
            _imgSrc = "Tablet.png";
        }

        public override string ToString()
        {
            return "Планшет " + _producer;
        }

        public override String GetInfo()
        {
            String info = this + " " + _storageCapacity + "gb\n" +
                          "Наличие клавиатуры: " + _isHaveKeyboard + "\n" +
                          "Наличие камеры: " + _isHaveCam + "\n" +
                          "Операционная система: " + _operatingSystem + "\n";

            return info;
        }
    }
}
