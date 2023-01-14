using UnityEngine;

public class RandomPlacement : MonoBehaviour
{
    public float xMin = -12.0f; // adjust as needed
    public float xMax = 12.0f; // adjust as needed
    public float zMin = -12.0f; // adjust as needed
    public float zMax = 3.0f; // adjust as needed

    void Start()
    {
        float x = Random.Range(xMin, xMax);
        float z = Random.Range(zMin, zMax);
        transform.position = new Vector3(x, transform.position.y+1, z);
    }
}