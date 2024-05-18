using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryUI;
    public GameObject itemSlotPrefab;
    public Transform itemSlotContainer;
    private bool isInventoryOpen = false;

    void Start()
    {
        inventoryUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            isInventoryOpen = !isInventoryOpen;
            inventoryUI.SetActive(isInventoryOpen);
        }
    }

    public void UpdateInventoryUI(List<Item> items)
    {
        foreach (Transform child in itemSlotContainer)
        {
            Destroy(child.gameObject);
        }

        foreach (Item item in items)
        {
            GameObject itemSlot = Instantiate(itemSlotPrefab, itemSlotContainer);
            itemSlot.GetComponentInChildren<Text>().text = item.itemName;
            itemSlot.GetComponentInChildren<Image>().sprite = item.icon;
        }
    }

    internal void UpdateInventoryUI()
    {
        throw new NotImplementedException();
    }
}
