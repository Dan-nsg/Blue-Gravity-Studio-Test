using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    public List<ItemData> itemsForSale;
    public GameObject shopItemPrefab;
    public Transform shopItemContainer;

    void Start()
    {
        PopulateShop();
    }

    void PopulateShop()
    {
        foreach (ItemData item in itemsForSale)
        {
            GameObject shopItem = Instantiate(shopItemPrefab, shopItemContainer);
            ShopItemUI shopItemUI = shopItem.GetComponent<ShopItemUI>();
            shopItemUI.Setup(item);
        }
    }
}
