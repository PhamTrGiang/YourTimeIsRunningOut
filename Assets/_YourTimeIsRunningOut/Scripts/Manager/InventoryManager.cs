using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private int maxSlotValue = 10;

    [SerializeField] private List<ItemSO> allItem;

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
        allItem.Add(itemData);
    }

    public void RemoveItem(ItemSO itemData)
    {
        for (int i = 0; i < allItem.Count; i++)
        {
            if (allItem[i] == itemData)
            {
                allItem.Remove(itemData);
                return;
            }
        }

    }

    public List<ItemSO> GetAllItem()
    {
        return allItem;
    }

    public bool HaveItem() => allItem.Count > 0;

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
