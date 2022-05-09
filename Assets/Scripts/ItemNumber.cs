using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemNumber : MonoBehaviour
{

    public GameObject GameControllerObject;
    public Text ItemList;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       ItemList.text =  GameControllerObject.GetComponent<GameController>().thingPickedUp.ToString() + "/5";
    }
}
