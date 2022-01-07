using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class HealthPotion : IInventoryItem
    {
        private string _name;

        public HealthPotion(string name)
        {
            _name = name;
        }
        public void DisplayName()
        {
            Console.WriteLine(_name);
        }

        public int GetWeight()
        {
            return 0;
        }

        public int GetPotionSpace()
        {
            return 1;
        }

        public void Load(List<IInventoryItem> itemsList)
        {
            itemsList.Add(this);
        }
    }
}
