using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobHaptic : MonoBehaviour
{
    [Range(0, 1)]
    public float breathingIntensity = 0.8f;
    [Range(0, 1)]
    public float breathingDuration = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            HapticController.SendHaptics(breathingIntensity, breathingDuration);
        }
    }
}
