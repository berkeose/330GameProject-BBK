using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    public GameObject Player;
    public GameObject Border;

    private void OnTriggerEnter( )
    {
        Player.transform.parent = Border.transform;
    }

    private void OnTriggerExit( )
    {
        Player.transform.parent = null;
    }
}