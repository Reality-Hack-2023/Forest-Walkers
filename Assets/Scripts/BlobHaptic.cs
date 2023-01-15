using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobHaptic : MonoBehaviour
{
    public GameObject _EmissiveObject;
    public Material mat;
    public HapticController hapticControllerHelper;
    [Range(0, 1)]
    public float breathingIntensity = 0.5f;
    [Range(0, 1)]
    public float breathingDuration = 2f;
    // Start is called before the first frame update
    void Awake()
    {
        //mat = _EmissiveObject.GetComponent<Renderer>().material;
        _EmissiveObject.GetComponent<SkinnedMeshRenderer>().material.DisableKeyword("_EMISSION");
        //_EmissiveObject.GetComponent<SkinnedMeshRenderer>().material.SetColor("_EmissionColor", Color.black);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        hapticControllerHelper.SendHaptics(breathingIntensity, breathingDuration);
        /*mat.DisableKeyword("_EMISSION");
        mat.globalIlluminationFlags = MaterialGlobalIlluminationFlags.EmissiveIsBlack;
        mat.SetColor("_EmissionColor", Color.black);*/

        if (other.tag == "Player")
        {
            _EmissiveObject.GetComponent<SkinnedMeshRenderer>().material.EnableKeyword("_EMISSION");
        }
    }

   /* private void OnTriggerExit(Collider other)
    {
        //hapticControllerHelper.SendHaptics(breathingIntensity, breathingDuration);
        mat("_EMISSION");
        mat.globalIlluminationFlags = MaterialGlobalIlluminationFlags.EmissiveIsBlack;
        mat.SetColor("_EmissionColor", Color.white);
        if (other.tag == "Player")
        {
        }
    }*/
}
