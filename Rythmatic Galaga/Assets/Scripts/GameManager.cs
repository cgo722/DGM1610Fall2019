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
    public TextMeshProUGUI title;
    private Spawn_manager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        
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

        score = 0;
        scoreText.text = "Score: " + score;
        UpdateScore(0);
        //title.gameObject.SetActive(false);
    }
}
