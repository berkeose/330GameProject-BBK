using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camRotation : MonoBehaviour
{
    public Transform target;
    public float mouseSpeed;
    float xrot,yrot;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        xrot-=Input.GetAxis("Mouse Y")*Time.deltaTime*mouseSpeed;
        yrot+=Input.GetAxis("Mouse X")*Time.deltaTime*mouseSpeed;
        transform.localRotation=Quaternion.Euler(0,yrot,0);
     
     
        }
         void FixedUpdate() {
            transform.position=Vector3.Lerp(transform.position,target.transform.position,0.3f);
            
        }
        
    }

