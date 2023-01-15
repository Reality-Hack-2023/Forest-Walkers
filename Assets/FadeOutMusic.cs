using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutMusic : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip newClip;
    public GameObject targetObject; // this will be player
    public GameObject blobObject;
    public float proximity = 2.0f;
    private bool switchedAudio = false;

    public Renderer blob1Renderer;
    public Renderer blob2Renderer;
    public Renderer blob3Renderer;
    public Renderer blob4Renderer;

    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;


    public Material newMaterial;

    // Start is called before the first frame update
    void Start()
    {
    }

    IEnumerator WaitFor15Seconds()
    {
        yield return new WaitForSeconds(30);
        // Execute the action you want to happen after 15 seconds here
    }

    void Update() {
        float distance = Vector3.Distance(targetObject.transform.position, blobObject.transform.position);

        // Trigger this code when interaction occurs
        if (distance <= proximity && switchedAudio == false) {
            // Trigger this code when interaction occurs
            audioSource.Pause();
            audioSource.clip = newClip;
            audioSource.Play();

            blob1Renderer.material = newMaterial;
            blob2Renderer.material = newMaterial;
            blob3Renderer.material = newMaterial;
            blob4Renderer.material = newMaterial;

            // StartCoroutine(WaitFor15Seconds());

            switchedAudio = true;

            audioSource.Pause();
            audioSource1.Pause();
            audioSource2.Pause();
            audioSource3.Pause();

        }
    }
}
