using UnityEngine;

public class GreenBlobSinging : MonoBehaviour {

    public float proximity = 5.0f;
    public float maxVolume = 1.0f;
    public GameObject targetObject;
    private AudioSource audioSource;

    public Color farEmissionColor = Color.white;
    public Color closeEmissionColor = Color.blue;
    public float lerpSpeed = 0.1f; // adjust as needed
    public Material materialToChange; // assign in inspector
    private Color currentEmissionColor;



    private Renderer renderer;

    void Start() {
        audioSource = GetComponent<AudioSource>();
        renderer = GetComponent<Renderer>();
    }

    void Update() {
        float distance = Vector3.Distance(targetObject.transform.position, transform.position);

        if (distance <= proximity) {
            audioSource.volume = maxVolume * (1 - distance / proximity);
        } else {
            audioSource.volume = 0;
        }

        float lerpValue = Mathf.InverseLerp(0, proximity, distance);
        currentEmissionColor = Color.Lerp(closeEmissionColor, farEmissionColor, lerpValue);
        materialToChange.SetColor("_EmissionColor", currentEmissionColor);
    }
}
