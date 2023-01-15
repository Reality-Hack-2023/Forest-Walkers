using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color startColor;
    public Color endColor;
    public float speed = 1.0f;

    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        float t = Mathf.Sin(Time.time * speed);
        renderer.material.color = Color.Lerp(startColor, endColor, t);
    }
}
