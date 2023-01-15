using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5.0f; // adjust the speed of the movement

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
    }
}
