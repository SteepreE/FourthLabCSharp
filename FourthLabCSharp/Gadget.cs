using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthLabCSharp
{
    abstract class Gadget
    {
        protected Producer _producer;
        protected OC _operatingSystem;

        protected int _storageCapacity;

        protected String _imgSrc;

        protected Gadget(Producer producer, OC operatingSystem, int storageCapacity)
        {
            _producer = producer;
            _operatingSystem = operatingSystem;
            _storageCapacity = storageCapacity;
        }

        public string getImgSrc()
        {
            return _imgSrc;
        }

        public abstract String GetInfo();
    }
}
