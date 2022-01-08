using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
    internal class BluntWeapon : IInventoryItem
    {
        private List<IInventoryItem> _bluntWeapons;

        public BluntWeapon()
        {
            _bluntWeapons = new List<IInventoryItem>();
        }
        public void DisplayName()
        {
            foreach (var bluntWeapon in _bluntWeapons)
            {
                bluntWeapon.DisplayName();
            }
        }

        public int GetWeight()
        {
            int totalBluntWeaponWeight = 0;

            foreach (var bluntWeapon in _bluntWeapons)
            {
                totalBluntWeaponWeight += bluntWeapon.GetWeight();
            }

            return totalBluntWeaponWeight;
        }

        public int GetPotionSpace()
        {
            int totalBluntWeaponPotionSpace = 0;

            foreach (var bluntWeapon in _bluntWeapons)
            {
                totalBluntWeaponPotionSpace += bluntWeapon.GetPotionSpace();
            }

            return totalBluntWeaponPotionSpace;
        }

        internal void AddBluntWeapon(IInventoryItem bluntWeaponToAdd)
        {
            _bluntWeapons.Add(bluntWeaponToAdd);
        }

        internal void RemoveBluntWeapon(IInventoryItem bluntWeaponToDelete)
        {
            _bluntWeapons.Remove(bluntWeaponToDelete);
        }

        public void Load(List<IInventoryItem> itemsList)
        {
            foreach (var component in _bluntWeapons)
            {
                component.Load(itemsList);
            }
        }
    }
}
