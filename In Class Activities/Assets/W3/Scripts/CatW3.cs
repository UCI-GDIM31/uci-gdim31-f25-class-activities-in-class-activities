using TMPro;
using UnityEngine;

public class CatW3 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _jump = 10f;
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private TMP_Text _speechText;
    [SerializeField] private float _maxHealth = 5f;

    private bool _facingLeft;
    private bool _isGrounded = true;
    private int _points = 0;
    private float _health;
    private bool _isDead = false;

    // ------------------------------------------------------------------------
    private void Awake()
    {
        if (_rigidbody == null)
            _rigidbody = GetComponent<Rigidbody2D>();

        if (_animator == null)
            _animator = GetComponent<Animator>();

        if (_spriteRenderer == null)
            _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // ------------------------------------------------------------------------
    private void Start()
    {
        _health = _maxHealth;
        UpdateUI();
    }

    // ------------------------------------------------------------------------
    private void Update()
    {
        if (_rigidbody == null || _isDead) return;

        float moveX = 0f;

        if (Input.GetKey(KeyCode.A)) moveX = -1f;
        else if (Input.GetKey(KeyCode.D)) moveX = 1f;

        _rigidbody.linearVelocity = new Vector2(moveX * _speed, _rigidbody.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.W) && _isGrounded)
        {
            _isGrounded = false;
            _rigidbody.linearVelocity = new Vector2(_rigidbody.linearVelocity.x, _jump);
        }

        if (moveX < 0 && !_facingLeft) { _spriteRenderer.flipX = true; _facingLeft = true; }
        else if (moveX > 0 && _facingLeft) { _spriteRenderer.flipX = false; _facingLeft = false; }

        if (_animator != null)
            _animator.SetBool("walking", Mathf.Abs(moveX) > 0.01f);
    }

    // ------------------------------------------------------------------------
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            _points++;
            if (_pointsText != null) _pointsText.text = "points: " + _points;
            Destroy(other.gameObject);
        }
    }

    // ------------------------------------------------------------------------
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
            _isGrounded = true;

        BallW3 ball = collision.gameObject.GetComponent<BallW3>();
        if (ball != null)
        {
            ChangeColor(ball);
            DecreaseHealth();
        }
    }

    // ------------------------------------------------------------------------
    private void DecreaseHealth()
    {
        if (_isDead) return;

        _health--;
        UpdateUI();

        if (_health <= 0)
        {
            Die();
        }
    }

    private void UpdateUI()
    {
        if (_healthText != null) _healthText.text = "health = " + _health;
        if (_speechText != null) _speechText.text = GetHealthSpeechText();
    }

    // ------------------------------------------------------------------------
    private string GetHealthSpeechText()
    {
        return _health < _maxHealth / 2f ? "OH NO!!" : "ouch";
    }

    private void ChangeColor(BallW3 ball)
    {
        if (_spriteRenderer != null && ball != null && ball.ballRenderer != null)
            _spriteRenderer.color = ball.ballRenderer.color;
    }

    // ------------------------------------------------------------------------
    private void Die()
    {
        _isDead = true;
        if (_rigidbody != null)
            _rigidbody.linearVelocity = Vector2.zero;

        // ✅ Destroy the GameObject immediately
        Destroy(gameObject);
    }
}
