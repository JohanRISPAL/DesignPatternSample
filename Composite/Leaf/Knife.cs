using Composite.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Knife : BladeWeapon, IInventoryItem
    {

        private string _name;
        private int _weight;

        private Random random = new Random();

        public Knife(string name)
        {
            _name = name;
            _weight = random.Next(1, 11);
        }
        public void DisplayName()
        {
            Console.WriteLine(_name);
        }

        public int GetWeight()
        {
            return _weight;
        }

        public int GetPotionSpace()
        {
            return 0;
        }

        public void Load(List<IInventoryItem> itemsList)
        {
            itemsList.Add(this);
        }
    }
}
