using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camRotTry : MonoBehaviour
{
    public Transform target;
    public float speed =15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.rotation=Quaternion.Lerp(transform.rotation,target.rotation,speed*Time.deltaTime);
        
    }
}
