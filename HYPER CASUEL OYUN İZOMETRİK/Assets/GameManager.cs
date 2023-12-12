using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject LoseUI;
    public GameObject winUI;
    public int Score;
    public Text loseScoreText, winScoreText;
    public Text InGameScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void LevelEnd()
    {
        LoseUI.SetActive(true);
        loseScoreText.text= "Toplam Puan"  +Score;
        InGameScoreText.gameObject.SetActive(false);
    }

    public void WinLevel()
    {
        winUI.SetActive(true);
        winScoreText.text = "Toplam Puan" + Score;
        InGameScoreText.gameObject.SetActive(false);

    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void AddScore(int pointValue)
    {
        Score += pointValue;
       InGameScoreText.text = "Puan:" + Score;
    }

    public void StartApp()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AppQuit()
    {
        Application.Quit();
    }
}
