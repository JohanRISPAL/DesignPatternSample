using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Consumable : IInventoryItem
    {

        private List<IInventoryItem> _consumables;

        internal Consumable()
        {
            _consumables = new List<IInventoryItem>();
        }
        public void DisplayName()
        {
            foreach(var consumable in _consumables)
            {
                consumable.DisplayName();
            }
        }

        public int GetWeight()
        {
            int totalConsumableWeight = 0;

            foreach (var consumable in _consumables)
            {
                totalConsumableWeight += consumable.GetWeight();
            }

            return totalConsumableWeight;
        }

        public int GetPotionSpace()
        {
            int totalConsumablePotionSpace = 0;

            foreach (var consumable in _consumables)
            {
                totalConsumablePotionSpace += consumable.GetPotionSpace();
            }

            return totalConsumablePotionSpace;
        }

        public void AddConsumable(IInventoryItem consumableToAdd)
        {
            _consumables.Add(consumableToAdd);
        }

        internal void RemoveConsumable(IInventoryItem consumableToDelete)
        {
            _consumables.Remove(consumableToDelete);
        }

        public void Load(List<IInventoryItem> itemsList)
        {
            foreach (var component in _consumables)
            {
                component.Load(itemsList);
            }
        }
    }
}
