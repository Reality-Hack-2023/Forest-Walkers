using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerEmissivity : MonoBehaviour
{

    public Material material;
    public float emissivity = 0.0f;
    public float speed = 0.1f;
    private float currentEmissivity;

    // Start is called before the first frame update
    void Start()
    {
        currentEmissivity = material.GetFloat("_Emission");
        currentEmissivity = 0.0f;
        material.SetFloat("_Emission", currentEmissivity);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
