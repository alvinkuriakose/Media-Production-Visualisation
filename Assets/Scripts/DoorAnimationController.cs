using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimationController : MonoBehaviour
{

    public Animator animator;
    public GameObject GameControllerObject;
    public AudioSource FenceOpen;
    public AudioSource FenceClose;

   
   private void OnTriggerEnter(Collider other){
       if(GameControllerObject.GetComponent<GameController>().thingPickedUp == 5){
           if(other.tag == "Player"){
           animator.SetBool("DoorOpen", true);
           FenceOpen.Play();
       }

       }
   }

   private void OnTriggerExit(Collider other){
       if(GameControllerObject.GetComponent<GameController>().thingPickedUp == 5){
           if(other.tag == "Player"){
           animator.SetBool("DoorOpen", false);
           FenceClose.Play();
       }

       }
   }
}
