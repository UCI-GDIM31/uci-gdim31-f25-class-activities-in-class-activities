using TMPro;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class BallW3 : MonoBehaviour
{
    public SpriteRenderer ballRenderer;

    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speedMultiplier = 1.0f;
    [SerializeField] private float _speedThreshold = 10.0f;
    [SerializeField] private float _brightnessIncrement = 0.1f; // New: How much the color brightens per fast bounce

    private void Awake()
    {
        // Silently ensure a collider exists (no Unity warning)
        if (GetComponent<Collider2D>() == null)
        {
            gameObject.AddComponent<CircleCollider2D>();
        }

        if (_rigidbody == null) _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 🔹 Make the ball faster each bounce
        _rigidbody.linearVelocity *= _speedMultiplier;
        _speedMultiplier += 0.05f; // Slightly increase after each collision

        // 🔹 Color multiplier based on speed
        float colorMult = GetColorMultiplier(Mathf.Abs(_rigidbody.linearVelocity.x), Mathf.Abs(_rigidbody.linearVelocity.y));

        // Apply brightness increment if moving fast
        if (colorMult > 1.0f)
        {
            // Gradually brighten the ball
            Color currentColor = ballRenderer.color;
            currentColor.r = Mathf.Clamp01(currentColor.r + _brightnessIncrement);
            currentColor.g = Mathf.Clamp01(currentColor.g + _brightnessIncrement);
            currentColor.b = Mathf.Clamp01(currentColor.b + _brightnessIncrement);
            ballRenderer.color = currentColor;
        }
        else
        {
            // Apply normal color multiplier for slower bounces
            ballRenderer.color *= colorMult;
        }
    }

    private float GetColorMultiplier(float xSpeed, float ySpeed)
    {
        float avgSpeed = (xSpeed + ySpeed) / 2f;
        return avgSpeed > _speedThreshold ? 1.5f : 1.0f;
    }
}