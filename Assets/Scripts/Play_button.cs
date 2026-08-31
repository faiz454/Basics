using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_button : MonoBehaviour
{
    public GameObject play_button;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PlayGame()
    {
       // if (play_button != null)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
