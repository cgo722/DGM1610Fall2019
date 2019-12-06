using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    public GameObject title;
    public Button button;
    public GameObject player;
    private Spawn_manager spawnManagerScript;
    public Button restartButton;
    public TextMeshProUGUI gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
        button.onClick.AddListener(StartGame);
        spawnManagerScript = GameObject.Find("Spawn manager").GetComponent<Spawn_manager>();
        restartButton.onClick.AddListener(RestartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore (int addToScore)
    {
        score += addToScore;
        scoreText.text = "Score: " + score;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Testing Ground");
        spawnManagerScript.isGameActive = true;
        player.gameObject.SetActive(true);
        score = 0;
        scoreText.text = "Score: " + score;
        UpdateScore(0);
        title.gameObject.SetActive(false);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GameOver()
    {
        gameOver.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        spawnManagerScript.isGameActive = false;
    }
}
