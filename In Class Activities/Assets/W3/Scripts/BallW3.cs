using TMPro;
using UnityEngine;

public class BallW3 : MonoBehaviour
{
    public SpriteRenderer ballRenderer;
    private Rigidbody2D _rigidbody;
    private float _speedMultiplier = 1.15f;
    private float _speedThreshold = 10.0f;

    public Color CurrentColor
    {
        get
        {
            var sr = ballRenderer != null ? ballRenderer : GetComponent<SpriteRenderer>();
            return sr != null ? sr.color : Color.white;
        }
    }
    private void Awake()
    {
        if (_rigidbody == null) _rigidbody = GetComponent<Rigidbody2D>();
        if (ballRenderer == null) ballRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_rigidbody != null)
            _rigidbody.linearVelocity *= _speedMultiplier;

        if (ballRenderer != null)
        {
            float mult = GetColorMultiplier(
                Mathf.Abs(_rigidbody.linearVelocity.x),
                Mathf.Abs(_rigidbody.linearVelocity.y)
            );
            ballRenderer.color *= mult;  // > 1 会变亮，=1 不变
        }
    }

    private float GetColorMultiplier(float speedX, float speedY)
    {
        float avg = (speedX + speedY) * 0.5f;
        return (avg > _speedThreshold) ? 1.5f : 1.0f;

    }
}
