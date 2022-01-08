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
        private BluntWeapon _bluntWeapon = new BluntWeapon();

        internal Weapon()
        {
            _weapons = new List<IInventoryItem>();
            _weapons.Add(_bladeWeapons);
            _weapons.Add(_bluntWeapon);
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
            }else if (weaponToAdd.GetType().IsSubclassOf(typeof(BluntWeapon)))
            {
                _bluntWeapon.AddBluntWeapon(weaponToAdd);
            }
        }

        internal void RemoveWeapon(IInventoryItem weaponToDelete)
        {
            if (weaponToDelete.GetType().IsSubclassOf(typeof(BladeWeapon)))
            {
                _bladeWeapons.RemoveBladeWeapon(weaponToDelete);
            }
            else if (weaponToDelete.GetType().IsSubclassOf(typeof(BluntWeapon)))
            {
                _bluntWeapon.RemoveBluntWeapon(weaponToDelete);
            }
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
