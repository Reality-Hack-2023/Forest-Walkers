using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalHaptic : MonoBehaviour
{
    [Range(0, 1)]
    public float breathingIntensity = 0.5f;
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
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && isTriggerPressed)
        {
            HapticController.SendHaptics(Mathf.Lerp(0.1f, 1f, breathingIntensity), 5f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isTriggerPressed = false;
    }
}
