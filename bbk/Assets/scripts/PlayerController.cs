using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 movementVector=Vector3.zero;
    private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController.GetComponent<CharacterController>();
        
    }
    void Movement(){
        float verticalInput=Input.GetAxis("Vertical");
        float horizontalInput=Input.GetAxis("Horizontal");

         movementVector=Vector3.ClampMagnitude(transform.right*horizontalInput+transform.forward*verticalInput,1.0f);
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
