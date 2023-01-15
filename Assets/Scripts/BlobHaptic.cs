using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobHaptic : MonoBehaviour
{
    public HapticController hapticControllerHelper;
    [Range(0, 1)]
    public float breathingIntensity = 0.5f;
    [Range(0, 1)]
    public float breathingDuration = 2f;
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
        hapticControllerHelper.SendHaptics(breathingIntensity, breathingDuration);

        /*if (other.tag == "Player")
        {
        }*/
    }
}
