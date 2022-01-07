using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Weapon : IInventoryItem
    {

        private List<IInventoryItem> _weapons;

        internal Weapon()
        {
            _weapons = new List<IInventoryItem>();
        }

        public void DisplayName()
        {
            foreach(var weapon in _weapons)
            {
                weapon.DisplayName();
            }
        }

        public int GetWeight()
        {
            int totalWeaponWeight = 0;

            foreach(var weapon in _weapons)
            {
                totalWeaponWeight += weapon.GetWeight();
            }

            return totalWeaponWeight;
        }

        public int GetPotionSpace()
        {
            int totalWeaponPotionSpace = 0;

            foreach (var weapon in _weapons)
            {
                totalWeaponPotionSpace += weapon.GetPotionSpace();
            }

            return totalWeaponPotionSpace;
        }

        internal void AddWeapon(IInventoryItem weaponToAdd)
        {
            _weapons.Add(weaponToAdd);
        }

        internal void RemoveWeapon(IInventoryItem weaponToDelete)
        {
            _weapons.Remove(weaponToDelete);
        }

        public void Load(List<IInventoryItem> itemsList)
        {
            foreach (var component in _weapons)
            {
                component.Load(itemsList);
            }
        }
    }
}
