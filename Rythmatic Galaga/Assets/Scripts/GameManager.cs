using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI title;

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
    }
}
