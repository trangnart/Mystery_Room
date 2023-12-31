using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightToggle : MonoBehaviour
{
    // Start is called before the first frame update
    public Light flashlight;
    public bool on = false;

    void Start()
    {
        flashlight.enabled = false;
        on = false;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.F)) {
        if (on == true) {
            flashlight.enabled = false;
            on = false;
        }
        else {
            flashlight.enabled = true;
            on = true;
        }
       }
    }
}
