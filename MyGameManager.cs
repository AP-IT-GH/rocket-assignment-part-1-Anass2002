using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public GameObject rocket;
    public GameObject mainCanvas;
    public GameObject gameOverCanvas;
    private Health healthRocket;

    public enum GameStates
    {
        Playing,
        GameOver
    }

    public GameStates gameState = GameStates.Playing;
    // Start is called before the first frame update
    void Start()
    {
        if (rocket == null)
        {
            rocket = GameObject.Find("rocket");
        }
        healthRocket = rocket.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)

        {
            case GameStates.Playing:
                if (!healthRocket.isAlive)
                {
                    gameState = GameStates.GameOver;
                    mainCanvas.SetActive(false);
                    gameOverCanvas.SetActive(true);
                }
                break;
        }
    }
}
