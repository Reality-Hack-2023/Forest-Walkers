using UnityEngine;

public class ChangeOpacity : MonoBehaviour
{
    public Renderer renderer; // assign in inspector
    public float opacity = 0.5f; // adjust as needed

    void Start()
    {
        Color newColor = renderer.material.color;
        newColor.a = opacity;
        renderer.material.color = newColor;
    }
}