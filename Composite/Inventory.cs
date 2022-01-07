using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Inventory
    {

        private List<IInventoryItem> _inventoryItems;

        private Weapon _weaponComposite = new Weapon();
        private Consumable _consumableComposite = new Consumable();

        public Inventory()
        {
            _inventoryItems = new List<IInventoryItem>();
            _inventoryItems.Add(_weaponComposite);
            _inventoryItems.Add(_consumableComposite);
        }

        public List<IInventoryItem> InventoryItems
        {
            get => _inventoryItems;
        }

        internal void DisplayName()
        {
            Console.WriteLine($"Charge totale de l'inventaire : {GetTotalWeightOfInventory()}/100");
            Console.WriteLine($"Consomable dans l'inventaire : {GetTotalPotionSpaceFill()}/5");
            foreach (var item in InventoryItems)
            {
                item.DisplayName();
            }
        }

        internal void AddWeaponInInventory(IInventoryItem weaponToAdd)
        {
            if(GetTotalWeightOfInventory() + weaponToAdd.GetWeight() < 100)
            {
                _weaponComposite.AddWeapon(weaponToAdd);
            }
        }

        internal void RemoveWeaponFromInventory(IInventoryItem weaponToDelete)
        {
            _weaponComposite.RemoveWeapon(weaponToDelete);
        }

        internal void LoadWeaponList(List<IInventoryItem> weaponsList)
        {
            _weaponComposite.Load(weaponsList);
        }

        internal void AddConsumableInInventory(IInventoryItem consumableToAdd)
        {
            if(GetTotalPotionSpaceFill() + 1 < 6)
            {
                _consumableComposite.AddConsumable(consumableToAdd);
            }
        }

        internal void RemoveConsumableFromInventory(IInventoryItem consumableToDelete)
        {
            _consumableComposite.RemoveConsumable(consumableToDelete);
        }

        internal void LoadConsumableList(List<IInventoryItem> consumablesList)
        {
            _consumableComposite.Load(consumablesList);
        }

        internal int GetTotalWeightOfInventory()
        {
            int totalWeight = 0;

            foreach(var item in _inventoryItems)
            {
                totalWeight += item.GetWeight();
            }

            return totalWeight;
        }

        internal int GetTotalPotionSpaceFill()
        {
            int totalPotionSpaceFill = 0;

            foreach (var item in _inventoryItems)
            {
                totalPotionSpaceFill += item.GetPotionSpace();
            }

            return totalPotionSpaceFill;
        }
       
    }
}
