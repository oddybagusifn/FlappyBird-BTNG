using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;

    public TextMeshProUGUI scoreText;

    public GameObject levelCompleteUi;

    public void EndGame()
    {
        Invoke("Restart", 2f);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LevelComplete()
    {
        Debug.Log("Tes");
        levelCompleteUi.SetActive(true);
        
    }

        public void AddScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
    
}
