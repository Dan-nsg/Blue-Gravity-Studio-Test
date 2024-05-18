using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopItemUI : MonoBehaviour
{
    public Image iconImage;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI priceText;
    public Button buyButton;

    public void Setup(ItemData itemData)
    {
        iconImage.sprite = itemData.icon;
        nameText.text = itemData.itemName;
        priceText.text = itemData.price.ToString();
        buyButton.onClick.AddListener(() => BuyItem(itemData));
    }

    void BuyItem(ItemData itemData)
    {
        // Adicione aqui a lógica para comprar o item
        Debug.Log("Comprou: " + itemData.itemName);
    }
}
