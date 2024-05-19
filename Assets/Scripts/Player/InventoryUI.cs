using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryItemPrefab; // Prefab do item no inventário
    public Transform inventoryItemContainer; // Container dos itens no inventário

    public void UpdateInventoryUI(List<SO_ItemData> items)
    {
        // Limpa os itens existentes no inventário
        foreach (Transform child in inventoryItemContainer)
        {
            Destroy(child.gameObject);
        }

        // Adiciona os novos itens ao inventário
        foreach (SO_ItemData item in items)
        {
            GameObject inventoryItem = Instantiate(inventoryItemPrefab, inventoryItemContainer);
            InventoryItemUI inventoryItemUI = inventoryItem.GetComponent<InventoryItemUI>();
            inventoryItemUI.Setup(item);
        }
    }
}
