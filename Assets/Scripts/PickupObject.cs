using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupObject : MonoBehaviour
{
   
   public GameObject GameControllerObject;
   public AudioSource ItemPickupSound;
   
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log ("Triggered");
       
        if(other.gameObject.name == "PlayerCapsule")
        {
             Debug.Log ("Pick up");
             Destroy (gameObject);

             GameControllerObject.GetComponent<GameController>().thingPickedUp += 1;

            ItemPickupSound.Play();

        }
    }

}
