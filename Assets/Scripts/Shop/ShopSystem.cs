using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopSystem : MonoBehaviour
{
    public List<Item> itemsForSale;
    public GameObject itemButtonPrefab;
    public Transform itemButtonContainer;
    public PlayerInventory playerInventory;

    void Start()
    {
        PopulateShop();
    }

    void PopulateShop()
    {
        foreach (Item item in itemsForSale)
        {
            GameObject button = Instantiate(itemButtonPrefab, itemButtonContainer);
            button.GetComponentInChildren<Text>().text = $"{item.itemName} - {item.price} gold";
            button.GetComponent<Image>().sprite = item.icon;
            button.GetComponent<Button>().onClick.AddListener(() => BuyItem(item));
        }
    }

    void BuyItem(Item item)
    {
        if (playerInventory.gold >= item.price)
        {
            playerInventory.gold -= item.price;
            playerInventory.AddItem(item);
            Debug.Log($"Bought {item.itemName}");
        }
        else
        {
            Debug.Log("Not enough gold");
        }
    }
}
