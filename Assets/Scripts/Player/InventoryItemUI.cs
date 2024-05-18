using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryItemUI : MonoBehaviour
{
    public Image iconImage;
    public TextMeshProUGUI nameText;

    public void Setup(ItemData itemData)
    {
        iconImage.sprite = itemData.icon;
        nameText.text = itemData.itemName;
    }
}
