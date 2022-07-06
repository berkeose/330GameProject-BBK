using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public int speed = 2;



    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed, 0, Space.World);
        
    }
}
