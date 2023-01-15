using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f; // adjust the speed of the movement
    public float rotationSpeed = 10.0f;
    public Camera mainCamera;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
            mainCamera.transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            mainCamera.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}
