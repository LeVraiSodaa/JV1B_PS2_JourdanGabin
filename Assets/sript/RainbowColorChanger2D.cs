using UnityEngine;

public class RainbowColorChanger2D : MonoBehaviour
{
    public float colorChangeSpeed = 1.0f; // Vitesse de changement de couleur
    private SpriteRenderer spriteRenderer;
    private float hue = 0;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer component is missing from this game object.");
        }
    }

    void Update()
    {
        if (spriteRenderer != null)
        {
            hue += colorChangeSpeed * Time.deltaTime;
            if (hue > 1) hue -= 1;

            Color newColor = Color.HSVToRGB(hue, 1, 1);
            spriteRenderer.color = newColor;
        }
    }
}
