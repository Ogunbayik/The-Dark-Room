using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "High Score : " + PlayerPrefs.GetInt("highScore").ToString();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Debug.Log("Exit The Game");
    }

    public void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("highScore");
        FindObjectOfType<GameManager>().gameScore = 0;
    }
}
