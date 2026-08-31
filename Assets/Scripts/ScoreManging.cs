using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManging : MonoBehaviour
{
    public static ScoreManging instance;
    public TextMeshProUGUI ScoreText;
    public int Score = 0;

    private void Awake()
    {
        instance = this;
    }

    public void AddScore(int points)
    {
        Score += points;
        ScoreText.text = "Score: " + Score;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
