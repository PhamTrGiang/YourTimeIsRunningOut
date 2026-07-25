using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private int currentDay = 0;

    public static TimeManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance == this)
            Destroy(this.gameObject);
        Instance = this;
    }

    public void NextDay()
    {
        currentDay++;

        // open night market

        if (!InventoryManager.Instance.HaveItem())
        {
            Debug.Log("Haven't item for sell");
            EndDay();
            return;
        }

        // start spawn customer
    }

    public void EndDay()
    {
        CountdownManager.Instance.AddjustCount(-1);
        Debug.Log("Anim transition next day");
    }


    public void ResetDay() => currentDay = 0;
}
