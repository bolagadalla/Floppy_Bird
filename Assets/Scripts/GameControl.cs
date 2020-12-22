using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// This Gamecontrol will manage our entire game
/// </summary>
public class GameControl : MonoBehaviour
{
    // This is an instance which we will use in other codes which will inharet everything about this class
    public static GameControl Instance;

    // Variables for speed and scores
    public float scrollSpeed = -1.5f;
    public bool isGameOver = false;
    public int score = 0;

    // this is for the UI
    public Text scoreText;
    public GameObject gameOverText;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update ()
    {
        // this will see if the user has died and then the user clicked the left mouse button, this will reload the current scene.
		if(isGameOver && Input.GetMouseButtonDown(0))
        {
            // this reloads the current scene (GetActiveScene())
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}

    /// <summary>
    /// This will manage the scoring of the game.
    /// </summary>
    public void Score()
    {
        if(isGameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score: " + score;
    }

    /// <summary>
    /// This will manage the user when he dies and changes the text
    /// </summary>
    public void Die()
    {
        isGameOver = true;
        gameOverText.SetActive(true);
    }
}
