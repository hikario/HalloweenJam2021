using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "New InventoryItem", order = 1)]
public class InventoryItem : ScriptableObject
{
    public bool itemOwned;

    public string itemName;
    public Sprite itemIcon;
}
