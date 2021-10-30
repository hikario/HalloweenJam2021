using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ItemSlot : MonoBehaviour
{
    public InventoryItem item;
    private Inventory inventory;

    public Image image;
    private TextMeshProUGUI textBox;

    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    public void DisplayItem(InventoryItem thisItem)
    {
        item = thisItem;
        textBox.text = item.itemName;
        image.sprite = item.itemIcon;
        gameObject.SetActive(true);
    }

    public void ClearItem()
    {
        item = null;
        image.sprite = null;
        gameObject.SetActive(false);
    }
}
