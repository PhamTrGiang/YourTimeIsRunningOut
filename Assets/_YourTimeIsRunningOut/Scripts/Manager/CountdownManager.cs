using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownManager : MonoBehaviour
{
    private int currentCount = 10;

    public void AddjustCount(int value)
    {
        currentCount += value;
        if(currentCount<=0) 
            Debug.Log("u lost");
    }
}
