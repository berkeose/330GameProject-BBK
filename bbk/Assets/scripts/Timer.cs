using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameObject timer;
    public bool isTime;
    public int seconds = 150;
    public static int extendScore;

    // Update is called once per frame
    private void Update()
  
    { 
         extendScore=seconds;
        if (isTime == false) //her frame i�in saniyeyi kontrol ediyoruz
            StartCoroutine(SubtractSecond());
    }

    private IEnumerator SubtractSecond()
    {
        isTime = true;
        seconds -= 1;
        timer.GetComponent<TextMeshProUGUI>().text = seconds.ToString(); //blank text +variable ekliyoruz
        yield return new WaitForSeconds(1);
        isTime = false;
    }
}