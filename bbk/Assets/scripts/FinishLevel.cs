using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLevel : MonoBehaviour
{
    public GameObject score;
    public GameObject totalScore;
    public GameObject timeLeft;
    public int timeCalculator;
    public int ScoreCalculator;
    public int totalScored;
    // Start is called before the first frame update
    void OnTriggerEnter(){
        timeCalculator=Timer.extendScore*100;
        timeLeft.GetComponent<Text>().text=" Time Left "+Timer.extendScore+" x 100 ";
        score.GetComponent<Text>().text=" Score: "+Score.currentScore;
        totalScored=Score.currentScore+timeCalculator;
        totalScore.GetComponent<Text>().text="Total Score "+totalScored;
        StartCoroutine(CalculateScore());
    }
    IEnumerator CalculateScore(){
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        score.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(0.25f);

    }
   
    }
