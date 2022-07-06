using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed=10f;
    private float xInput;
    private float zInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }
     void Awake() {
        rb=GetComponent<Rigidbody>();

        
    }
    private void FixedUpdate() {
        Move();
        

        
    }
    private void ProcessInputs(){
        xInput=Input.GetAxis("Horizontal");
        zInput=Input.GetAxis("Vertical");
    }
    private void Move(){
        rb.AddForce(new Vector3(xInput,0f,zInput)*moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }
}
