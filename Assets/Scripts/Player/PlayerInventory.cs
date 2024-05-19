using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int gold = 100;
    public List<SO_ItemData> inventory = new List<SO_ItemData>();

    public void AddItem(SO_ItemData item)
    {
        inventory.Add(item);
        Debug.Log($"Item added: {item.itemName}");
        // Atualize a UI do inventário se necessário
    }

    public void RemoveItem(SO_ItemData item)
    {
        inventory.Remove(item);
        Debug.Log($"Item removed: {item.itemName}");
        // Atualize a UI do inventário se necessário
    }

    public bool CanAfford(int price)
    {
        return gold >= price;
    }

    public void AddGold(int amount)
    {
        gold += amount;
        Debug.Log($"Gold added: {amount}. Current gold: {gold}");
        // Atualize a UI do ouro se necessário
    }

    public void RemoveGold(int amount)
    {
        gold -= amount;
        Debug.Log($"Gold removed: {amount}. Current gold: {gold}");
        // Atualize a UI do ouro se necessário
    }
}
