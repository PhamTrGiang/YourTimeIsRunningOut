using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownManager : MonoBehaviour
{
    public static CountdownManager Instance { get; private set; }

    private int currentCount = 10;

    private void Awake()
    {
        if (Instance != null && Instance == this)
            Destroy(this.gameObject);
        Instance = this;
    }

    public void AddjustCount(int value)
    {
        currentCount += value;
        if (currentCount <= 0)
            Debug.Log("game over");
    }
}
