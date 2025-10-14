using TMPro;
using UnityEngine;

public class CatW3 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private SpriteRenderer catRenderer;
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _jump = 8f;
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private TMP_Text _speechText;
    [SerializeField] private float _maxHealth = 10f;
    [SerializeField] private int damagePerHit = 1;
    [SerializeField] private bool _destroyCatWhenDead = true;

    private bool _facingLeft;
    private bool _isGrounded = true;
    private int _points = 0;
    private float _health;

    private void Start ()
    {
        _health = _maxHealth;
        if (_healthText) _healthText.text = "health = " + _health;
        if (_speechText) _speechText.text = "ouch";
    }

    private void Update()
    {
        if (_rigidbody)
        _rigidbody.linearVelocity = new Vector2(
            Input.GetAxis("Horizontal") * _speed,
            _rigidbody.linearVelocity.y
        );

        if (Input.GetAxis("Vertical") > 0 && _isGrounded)
        {
            _isGrounded = false;

            _rigidbody.linearVelocity = new Vector2(
                _rigidbody.linearVelocity.x,
                _jump
            );
        }

        if (Input.GetAxis("Horizontal") < 0 && !_facingLeft)
        {
            _spriteRenderer.flipX = true;
            _facingLeft = true;
        }
        else if (Input.GetAxis("Horizontal") > 0 && _facingLeft)
        {
            _spriteRenderer.flipX = false;
            _facingLeft = false;
        }

        _animator.SetBool("walking", _rigidbody.linearVelocity.x != 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Item"))
        {
            _points++;
            _pointsText.text = "points: " + _points;
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("ground"))
        {
            _isGrounded = true;
        }

        BallW3 ball = collision.gameObject.GetComponent<BallW3>();
        if (ball != null)
        {
            ChangeColor(ball);
            
            DecreaseHealth();

            if (_health <= 0f && _destroyCatWhenDead)
                Destroy(gameObject);

        }
    }

    private void DecreaseHealth()
    {
        _health -= damagePerHit;            
        _health = Mathf.Max(0, _health);

        if (_healthText) _healthText.text = "health = " + _health;
        if (_speechText) _speechText.text = GetHealthSpeechText(); ;
    }

    private string GetHealthSpeechText()
    {
        return (_health < _maxHealth * 0.5f) ? "OH NO!!" : "ouch";
    }
    private void ChangeColor(BallW3 ball)
    {
        if (catRenderer) catRenderer.color = ball.CurrentColor;
    }
}