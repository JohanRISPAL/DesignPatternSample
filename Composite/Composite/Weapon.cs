using Composite.Composite;
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

        private BladeWeapon _bladeWeapons = new BladeWeapon();

        internal Weapon()
        {
            _weapons = new List<IInventoryItem>();
            _weapons.Add(_bladeWeapons);
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
            if (weaponToAdd.GetType().IsSubclassOf(typeof(BladeWeapon)))
            {
                _bladeWeapons.AddBladeWeapon(weaponToAdd);
            }
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

        public void LoadBladeWeapon(List<IInventoryItem> itemsList)
        {
            _bladeWeapons.Load(itemsList);
        }
    }
}
