using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectLevel : MonoBehaviour
{
    public static int redirectlevel = 1;
    // Update is called once per frame
    void Update()
    {
        if (redirectlevel == 1)
        {
            SceneManager.LoadScene(redirectlevel);
        }
    }
}
