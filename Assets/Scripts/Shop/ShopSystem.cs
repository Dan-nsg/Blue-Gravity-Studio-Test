using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    public List<SO_ItemData> itemsForSale;
    public GameObject shopItemPrefab;
    public Transform shopItemContainer;
    public PlayerInventory playerInventory;

    void Start()
    {
        PopulateShop();
    }

    void PopulateShop()
    {
        foreach (SO_ItemData item in itemsForSale)
        {
            GameObject shopItem = Instantiate(shopItemPrefab, shopItemContainer);
            ShopItemUI shopItemUI = shopItem.GetComponent<ShopItemUI>();
            shopItemUI.Setup(item, playerInventory);
        }
    }
}
