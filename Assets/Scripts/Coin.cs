using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    public AudioClip coinsound;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SportCar_4"))
        {
            if(coinsound != null)
            {
                AudioSource.PlayClipAtPoint(coinsound, transform.position);
            }
            ScoreManging.instance.AddScore(coinValue);
            Destroy(gameObject);
        }
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
