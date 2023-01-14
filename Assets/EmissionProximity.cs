using UnityEngine;
using UnityEngine.Rendering.Universal;

public class EmissionProximity : MonoBehaviour
{
    public Renderer renderer; // assign in inspector
    public float maxEmission = 1.0f; // adjust as needed
    public float incrementSpeed = 0.1f; // adjust as needed
    private MaterialPropertyBlock propertyBlock;
    private float currentEmission = 0.0f;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        propertyBlock = new MaterialPropertyBlock();
    }

    void Update()
    {
        renderer.GetPropertyBlock(propertyBlock);
        currentEmission = Mathf.Min(maxEmission, currentEmission + incrementSpeed * Time.deltaTime);
        propertyBlock.SetFloat("_Emission", currentEmission);
        renderer.SetPropertyBlock(propertyBlock);
    }
}