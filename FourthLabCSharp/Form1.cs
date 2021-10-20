using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourthLabCSharp
{
    public partial class Form1 : Form
    {
        private List<Gadget> _gadgets = new List<Gadget>();
        private static Random _random = new Random();

        private int _laptopCount = 0;
        private int _smartphoneCount = 0;
        private int _tabletCount = 0;

        public Form1()
        {
            InitializeComponent();

            RefillMachine();
        }

        private void UpdateLastGadgetsList()
        {
            GadgetsInfo.Text = $"Смартфонов: {_smartphoneCount}\nНоутбуков: {_laptopCount}\nПланшетов: {_tabletCount}";

            LastGadgetsList.Items.Clear();

            for (int i = 0; i < 3; i++)
            {
                LastGadgetsList.Items.Add("______________________________", i);
            }
        }

        private void RefillMachine()
        {
            GadgetsImgs.Images.Clear();
            _gadgets.Clear();

            _laptopCount = 0;
            _smartphoneCount = 0;
            _tabletCount = 0;

            for (int i=0; i<10; i++)
            {
                var gadget = GenerateGadget();
                Image image = Image.FromFile(gadget.getImgSrc());

                _gadgets.Add(gadget);
                GadgetsImgs.Images.Add(image);

                if (gadget is Laptop) 
                    _laptopCount++;
                else if (gadget is Smartphone) 
                    _smartphoneCount++;
                else if (gadget is Tablet) 
                    _tabletCount++;
            }

            UpdateLastGadgetsList();
        }

        private Gadget GenerateGadget()
        {
            switch (_random.Next() % 3)
            {
                case 0:
                    return new Laptop(
                        (Producer)_random.Next(4), 
                        (OC)_random.Next(3),
                        500 + _random.Next(6)*500,
                        (int)Math.Pow(2, 2 + _random.Next(4)),
                        (VideoCard)_random.Next(3)
                        );
                case 1:
                    return new Tablet(
                        (Producer)_random.Next(4),
                        (OC)(3 + _random.Next(2)),
                        (int)Math.Pow(2, 4 + _random.Next(7)),
                        _random.Next() % 2 == 0,
                        _random.Next() % 2 == 0
                        );
                default:
                    return new Smartphone(
                        (Producer)_random.Next(4),
                        (OC)(3 + _random.Next(2)),
                        (int)Math.Pow(2, 4 + _random.Next(7)),
                        1 + _random.Next(3),
                        (int)Math.Pow(2, 4 + _random.Next(6))
                        );
            }
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            if (_gadgets.Count == 0) RefillMachine();

            GadgedImg.Image = Image.FromFile(_gadgets[0].getImgSrc());
            GadgetInfo.Text = _gadgets[0].GetInfo();

            if (_gadgets[0] is Laptop)
                _laptopCount--;
            else if (_gadgets[0] is Smartphone)
                _smartphoneCount--;
            else if (_gadgets[0] is Tablet)
                _tabletCount--;

            GadgetsImgs.Images.RemoveAt(0);
            _gadgets.RemoveAt(0);

            UpdateLastGadgetsList();
        }
    }
}
