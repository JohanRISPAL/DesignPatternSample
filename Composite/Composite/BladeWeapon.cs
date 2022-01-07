using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
    internal class BladeWeapon : IInventoryItem
    {

        private List<IInventoryItem> _bladeWeapons;

        public BladeWeapon()
        {
            _bladeWeapons = new List<IInventoryItem>();
        }
        public void DisplayName()
        {
            foreach (var bladeWeapon in _bladeWeapons)
            {
                bladeWeapon.DisplayName();
            }
        }

        public int GetWeight()
        {
            int totalBladeWeaponWeight = 0;

            foreach (var bladeWeapon in _bladeWeapons)
            {
                totalBladeWeaponWeight += bladeWeapon.GetWeight();
            }

            return totalBladeWeaponWeight;
        }

        public int GetPotionSpace()
        {
            int totalBladeWeaponPotionSpace = 0;

            foreach (var bladeWeapon in _bladeWeapons)
            {
                totalBladeWeaponPotionSpace += bladeWeapon.GetPotionSpace();
            }

            return totalBladeWeaponPotionSpace;
        }

        internal void AddBladeWeapon(IInventoryItem bladeWeaponToAdd)
        {
            _bladeWeapons.Add(bladeWeaponToAdd);
        }

        internal void RemoveBladeWeapon(IInventoryItem bladeWeaponToDelete)
        {
            _bladeWeapons.Remove(bladeWeaponToDelete);
        }

        public void Load(List<IInventoryItem> itemsList)
        {
            foreach (var component in _bladeWeapons)
            {
                component.Load(itemsList);
            }
        }
    }
}
