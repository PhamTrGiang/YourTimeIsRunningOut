using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{

    private float timeToSpawm = 0;
    private int spawnCount = 0;

    private void Update()
    {
        if (timeToSpawm > 0)
        {
            timeToSpawm = Mathf.Max(0, timeToSpawm - Time.deltaTime);
            return;
        }
        SpawnCustomer();
    }

    private void SpawnCustomer()
    {
        Debug.Log("Spawn Customer");

        spawnCount--;
    }

    public void StartSpawn()
    {
        timeToSpawm = Random.Range(3, 4);
    }

    public void NextCustomer()
    {
        if (spawnCount <= 0)
        {
            Debug.Log("Delay some second");
            TimeManager.Instance.EndDay();
        }
        StartSpawn();
    }
}
