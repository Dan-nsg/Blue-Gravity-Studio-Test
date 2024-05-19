using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopItemUI : MonoBehaviour
{
    public Image iconImage;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI priceText;
    public Button buyButton;
    private SO_ItemData itemData;
    private PlayerInventory playerInventory;

    public void Setup(SO_ItemData itemData, PlayerInventory playerInventory)
    {
        this.itemData = itemData;
        this.playerInventory = playerInventory;
        iconImage.sprite = itemData.icon;
        nameText.text = itemData.itemName;
        priceText.text = itemData.price.ToString();
        buyButton.onClick.AddListener(BuyItem);
    }

    void BuyItem()
    {
        if (playerInventory.CanAfford(itemData.price))
        {
            playerInventory.RemoveGold(itemData.price);
            playerInventory.AddItem(itemData);
            Debug.Log($"Bought: {itemData.itemName}");
            Destroy(gameObject); // Remove o item da loja
        }
        else
        {
            Debug.Log("Not enough gold");
        }
    }
}
