using UnityEngine;
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour
{
    public int gold = 100;
    public List<Item> inventory = new List<Item>();
    public InventoryUI inventoryUI;

    public void AddItem(Item item)
    {
        inventory.Add(item);
        inventoryUI.UpdateInventoryUI();
    }
}
