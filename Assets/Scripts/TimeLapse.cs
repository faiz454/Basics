using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeLapse : MonoBehaviour
{
    public float timeRemaining = 30f;
    public TextMeshProUGUI Timer;
    public GameObject GameOverPanel;
    public AudioSource caraudioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            Timer.text = "Time: " + (int)timeRemaining;
        }
        else
        {
            timeRemaining = 0;
            GameOverPanel.SetActive(true);
            if (caraudioSource != null && caraudioSource.isPlaying)
            {
                caraudioSource.Pause();
            }
            Time.timeScale = 0f;
        }
    }
}
