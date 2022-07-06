using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonDash : MonoBehaviour
{
    public bool isDashing;
   private int dashAttempt;
   private float dashStartTime;
   PlayerController playerController;
  public CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        playerController=GetComponent<PlayerController>();
        characterController=GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleDash();
        
    }
void HandleDash(){
    bool isTryingDash=Input.GetKeyDown(KeyCode.E);
    if (isTryingDash && !isDashing)
    {
        if(dashAttempt<=50){
            OnStartDash();
        }
    }
    if(isDashing){
        if(Time.time-dashStartTime<=0.4f){
            if(playerController.movementVector.Equals(Vector3.zero)){
                //player ınput vermiyo sadece ileri dash atiyo
                characterController.Move(transform.forward*30f*Time.deltaTime);

            }
            else{characterController.Move(playerController.movementVector.normalized*30f*Time.deltaTime);}
        }
    }
}

   void OnStartDash(){

isDashing=true;
dashStartTime=Time.time;
dashAttempt=+1;

        
      
    }
    void OnEndDash(){
        isDashing=false;
        dashAttempt=0;
    }
}
