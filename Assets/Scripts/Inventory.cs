using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using System.Linq;

public class Inventory : MonoBehaviour
{
    private MenuDialog[] menuDialogs;
    private SayDialog[] sayDialogs;
    public CanvasGroup canvasGroup;

    public InventoryItem[] inventoryItems;
    public ItemSlot[] itemSlots;

    private Flowchart[] flowcharts;

    void Start()
    {
        menuDialogs = FindObjectsOfType<MenuDialog>();
        sayDialogs = FindObjectsOfType<SayDialog>();
        canvasGroup = GetComponent<CanvasGroup>();
        flowcharts = FindObjectsOfType<Flowchart>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            ToggleInventory(!canvasGroup.interactable);
        }
    }

    private void ToggleInventory(bool setting)
    {
        ToggleCanvasGroup(canvasGroup, setting);
        InitializeItemSlots();

        foreach (MenuDialog menuDialog in menuDialogs)
        {
            ToggleCanvasGroup(menuDialog.GetComponent<CanvasGroup>(), !setting);
        }
    }

    public void InitializeItemSlots()
    {
        List<InventoryItem> ownedItems = GetOwnedItems(inventoryItems.ToList());
        for (int i = 0; i < itemSlots.Length; i++)
        {
            if (i < ownedItems.Count)
            {
                itemSlots[i].DisplayItem(ownedItems[i]);
            }
            else
            {
                itemSlots[i].ClearItem();
            }
        }
    }

    public List<InventoryItem> GetOwnedItems(List<InventoryItem> inventoryItems)
    {
        List<InventoryItem> ownedItems = new List<InventoryItem>();
        foreach (InventoryItem item in inventoryItems)
        {
            if (item.itemOwned)
            {
                ownedItems.Add(item);
            }
        }
        return ownedItems;
    }

    private void ToggleCanvasGroup(CanvasGroup canvasGroup, bool setting)
    {
        canvasGroup.alpha = setting ? 1f : 0f;
        canvasGroup.interactable = setting;
        canvasGroup.blocksRaycasts = setting;
    }
}
