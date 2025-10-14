using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    [SerializeField] private TMP_Text _bouncesText;
    [SerializeField] private TMP_Text _brightnessText;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Rigidbody2D _rigidbody;

    private int _bounces;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // STEP 1 -------------------------------------------------------------
        // Add one to the value of '_bounces' and update text
        _bounces += 1;
        _bouncesText.text = "Bounces: " + _bounces;
        // STEP 1 -------------------------------------------------------------

        // Get current RGB values
        float r = _spriteRenderer.color.r;
        float g = _spriteRenderer.color.g;
        float b = _spriteRenderer.color.b;

        // STEP 2 -------------------------------------------------------------
        // Add 0.1 to the red channel
        r += 0.1f;
        // STEP 2 -------------------------------------------------------------

        // STEP 3 -------------------------------------------------------------
        // If red goes above 1.0, reset to 0.0
        if (r > 1.0f)
        {
            r = 0.0f;
        }
        // STEP 3 -------------------------------------------------------------

        // STEP 4 -------------------------------------------------------------
        // Subtract 0.1 from green each bounce
        g -= 0.1f;
        // STEP 4 -------------------------------------------------------------

        // STEP 5 -------------------------------------------------------------
        // If green goes below 0.0, reset to 1.0
        if (g < 0.0f)
        {
            g = 1.0f;
        }
        // STEP 5 -------------------------------------------------------------

        // STEP 6 -------------------------------------------------------------
        // Multiply blue by 1.2 to increase intensity
        b *= 1.2f;
        // STEP 6 -------------------------------------------------------------

        // STEP 7 -------------------------------------------------------------
        // If blue >= 1.0, reset it to 0.1
        if (b >= 1.0f)
        {
            b = 0.1f;
        }
        // STEP 7 -------------------------------------------------------------

        // Apply new color
        Color newColor = new Color(r, g, b);
        _spriteRenderer.color = newColor;

        // Print RGB values to the Console
        Debug.Log(newColor);

        // STEP 8 -------------------------------------------------------------
        // Calculate brightness as the average of R, G, and B
        float brightness = (r + g + b) / 3f;
        // STEP 8 -------------------------------------------------------------

        // STEP 9 -------------------------------------------------------------
        // Display the brightness value on screen
        _brightnessText.text = "Brightness = " + brightness.ToString("F2");
        // STEP 9 -------------------------------------------------------------
    }
}