// See https://aka.ms/new-console-template for more information
using Composite;

Console.WriteLine("Hello, World!");

Inventory inventory = new Inventory();

Knife knife = new Knife("Couteau à beurre");
Knife knife2 = new Knife("Couteau à fromage");
Knife knife3 = new Knife("Couteau à couille");

inventory.AddWeaponInInventory(knife);
inventory.AddWeaponInInventory(knife2);
inventory.AddWeaponInInventory(knife3);

HealthPotion healthPotion = new HealthPotion("Potion de vie");
HealthPotion healthPotion2 = new HealthPotion("Potion de vie II");

inventory.AddConsumableInInventory(healthPotion);
inventory.AddConsumableInInventory(healthPotion2);

inventory.DisplayName();

inventory.RemoveWeaponFromInventory(knife);

Console.WriteLine("==============================");

inventory.DisplayName();

Console.WriteLine("==============================");
Console.WriteLine("Liste des armes : ");
List<IInventoryItem> weaponsSorted = new List<IInventoryItem>();

inventory.LoadWeaponList(weaponsSorted);

foreach(var weapon in weaponsSorted)
{
    weapon.DisplayName();
}

Console.WriteLine("==============================");
Console.WriteLine("Liste des consomables : ");
List<IInventoryItem> consumablesSorted = new List<IInventoryItem>();

inventory.LoadConsumableList(consumablesSorted);

foreach (var consumable in consumablesSorted)
{
    consumable.DisplayName();
}