using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightToggle : MonoBehaviour
{
   public GameObject FlashlightObject;
    private bool FlashlightActive = false;
    public AudioSource FlashLightSound;

    // Start is called before the first frame update
    void Start()
    {
        FlashlightObject.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (FlashlightActive == false)
            {
                FlashlightObject.gameObject.SetActive(true);
                FlashlightActive = true;
                FlashLightSound.Play();
            }

            else
            {
                FlashlightObject.gameObject.SetActive(false);
                FlashlightActive = false;
                FlashLightSound.Play();
            }
        }
    }
}
