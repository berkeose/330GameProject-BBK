using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelDepth: MonoBehaviour //bu class yeniden doğmayı sağladı
{
    private void OnTriggerEnter()
    {
        SceneManager.LoadScene(0); //ilk sahnemizi açıp tekrardan başlatıyor
    }
}
