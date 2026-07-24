using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    Home,
    Game
}

public class UIManager : MonoBehaviour
{

    [Header("Panels")]
    [SerializeField] private GameObject homePanel;
    [SerializeField] private GameObject gamePanel;

    private List<GameObject> panels = new List<GameObject>();

    private void Awake()
    {
        panels.AddRange(new GameObject[]{
            homePanel,
            gamePanel,
        });
    }

    public void SetGamestate(GameState gameState)
    {
        switch (gameState)
        {
            case GameState.Home:
                ShowPanel(homePanel);
                break;
            case GameState.Game:
                ShowPanel(gamePanel);
                break;
        }
    }

    private void ShowPanel(GameObject panel)
    {
        foreach (GameObject p in panels)
            p.SetActive(p == panel);

    }
}
