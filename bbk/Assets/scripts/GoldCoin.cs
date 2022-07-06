using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCoin : MonoBehaviour
{
    public int goldCoin = 0;
    public GameObject score;
    public AudioSource CoinSound;
    void OnTriggerEnter() //altın toplandığında kayboluyo
    {

        //puanlama score burda yaz�lacak sonra //

        Score.currentScore += 100;
        
        //CoinSound.Play(); 
        Destroy(gameObject); 

        
    }
}
