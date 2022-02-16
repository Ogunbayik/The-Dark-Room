using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int gameScore =0;
    public GameObject gameOverPanel;
    public bool gameIsOver;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + gameScore.ToString();


        if(gameScore > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", gameScore);
        }
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        scoreText.gameObject.SetActive(false);
        Debug.Log("Game is Over");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    
   
}
