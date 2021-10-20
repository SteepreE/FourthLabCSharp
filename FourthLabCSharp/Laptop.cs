using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthLabCSharp
{
    class Laptop : Gadget
    {
        private int _coresCount;
        private VideoCard _videoCard;

        public Laptop(Producer producer, OC operatingSystem,
            int storageCapacity, int coresCount, VideoCard videoCard) : base(producer, operatingSystem, storageCapacity)
        {
            _coresCount = coresCount;
            _videoCard = videoCard;
            _imgSrc = "Laptop.png";
        }

        public override string ToString()
        {
            return "Ноутбук " + _producer;
        }

        public override String GetInfo()
        {
            String info = this + " " + _storageCapacity + "gb\n" +
                          "Видеокарта: " + _videoCard + "\n" +
                          "Количество ядер: " + _coresCount + "\n" +
                          "Операционная система: " + _operatingSystem + "\n";

            return info;
        }
    }
}
