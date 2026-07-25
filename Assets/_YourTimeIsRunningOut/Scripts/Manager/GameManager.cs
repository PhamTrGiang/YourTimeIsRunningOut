using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Application.targetFrameRate = 60;

        if (Instance != null && Instance == this)
            Destroy(this.gameObject);
        Instance = this;
    }
}
