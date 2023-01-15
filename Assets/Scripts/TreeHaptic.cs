using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHaptic : MonoBehaviour
{

    public HapticController hapticControllerHelper;

    [Range(0, 1)]
    public float breathingIntensity = 0.06f;
    public bool isTriggerPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTriggerPressed()
    {
        isTriggerPressed = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            hapticControllerHelper.SendHaptics(0.1f, 2f);

            /*if (isTriggerPressed)
            {
            }*/
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isTriggerPressed = false;
    }
}
