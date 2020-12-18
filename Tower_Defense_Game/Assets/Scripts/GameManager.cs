using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool GameIsOver = false;

    public GameObject gameOverUI;
    public GameObject completeLevelUI;
    

    public SceneFader sceneFader;


    // Start is called before the first frame update
    void Start()
    {
        GameIsOver = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (GameIsOver) return;

        if (Input.GetKeyDown("e"))
        {
            EndGame();
        }

        if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        if(!GameIsOver) Debug.Log("Game Over!");

        gameOverUI.SetActive(true);
    }

    public void WinLevel() {
        Debug.Log("LEVEL WON!");
        GameIsOver = true;
        completeLevelUI.SetActive(true);
    }



}
