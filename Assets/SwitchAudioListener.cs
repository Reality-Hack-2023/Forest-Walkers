using UnityEngine;

public class SwitchAudioListener : MonoBehaviour
{
    public AudioSource audioSource; // assign in inspector
    public AudioClip newClip; // assign in inspector
    public GameObject targetObject; // this will be player
    public GameObject blobObject;

    public GameObject nextBlob;
    private AudioSource nextAudioSource;

    private bool switchedAudio = false;


    public float proximity = 2.0f;

    void Update() {
        float distance = Vector3.Distance(targetObject.transform.position, blobObject.transform.position);

        // Trigger this code when interaction occurs
        if (distance <= proximity && switchedAudio == false) {
            // Trigger this code when interaction occurs
            audioSource.Pause();
            audioSource.clip = newClip;
            audioSource.Play();

            // Play the next blob
            nextAudioSource = nextBlob.GetComponent<AudioSource>();
            nextAudioSource.Play();
            switchedAudio = true;
        }
    }
}
