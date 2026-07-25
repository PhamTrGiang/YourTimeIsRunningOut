using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private int maxSlotValue = 10;

    [SerializeField] private List<ItemSO> allInventoryItem;

    private ItemSO currentItemSelect;

    public static InventoryManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance == this)
            Destroy(this.gameObject);
        Instance = this;
    }

    public void AddItem(ItemSO itemData)
    {
        allInventoryItem.Add(itemData);
    }

    public void RemoveItem(ItemSO itemData)
    {
        for (int i = 0; i < allInventoryItem.Count; i++)
        {
            if (allInventoryItem[i] == itemData)
            {
                allInventoryItem.Remove(itemData);
                return;
            }
        }

    }

    public List<ItemSO> GetAllItem()
    {
        return allInventoryItem;
    }

    public bool HaveItem() => allInventoryItem.Count > 0;

    public ItemSO GetItemSelect()
    {
        if (currentItemSelect == null)
        {
            Debug.Log("Please select item");
            return null;
        }

        return currentItemSelect;
    }

    public void SetItem(ItemSO item)
    {
        currentItemSelect = item;
    }
}
