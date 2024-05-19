using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class SO_ItemData : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public int price;
}
