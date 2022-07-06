using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject score;
    public static int currentScore;
    public int intScore;
    

    // Update is called once per frame
    void Update()

    {
        intScore = currentScore;
        score.GetComponent<TMPro.TextMeshProUGUI>().text = intScore.ToString  ();
    }
}
