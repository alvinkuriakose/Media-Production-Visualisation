using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveText : MonoBehaviour
{

    public GameObject GameControllerObject;
    public Text ObjectiveInfo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameControllerObject.GetComponent<GameController>().thingPickedUp == 1){
           ObjectiveInfo.text = "You found a recycled battery";
       }

       else if(GameControllerObject.GetComponent<GameController>().thingPickedUp == 2){
           ObjectiveInfo.text = "You found a recycled speaker";
       }

       else if(GameControllerObject.GetComponent<GameController>().thingPickedUp == 3){
           ObjectiveInfo.text = "You found a recycled lens";
       }

       else if(GameControllerObject.GetComponent<GameController>().thingPickedUp == 4){
           ObjectiveInfo.text = "You found a recycled screen";
       }
       

        else if(GameControllerObject.GetComponent<GameController>().thingPickedUp == 5){
           ObjectiveInfo.text = "You found a recycled circuit, Head to the door gate";
       }
    }
}
