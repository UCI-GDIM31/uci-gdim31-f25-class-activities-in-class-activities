using UnityEngine;

public class CatW6 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private float _jump = 5.0f;

    private bool _facingLeft;
    private bool _isGrounded = true;

    private void Update()
    {
        // Move left/right
        float move = Input.GetAxis("Horizontal");
        _rigidbody.linearVelocity = new Vector2(move * _speed, _rigidbody.linearVelocity.y);

        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rigidbody.linearVelocity = new Vector2(_rigidbody.linearVelocity.x, _jump);
            _isGrounded = false;
        }

        // Flip sprite
        if (move < 0 && !_facingLeft)
        {
            _spriteRenderer.flipX = true;
            _facingLeft = true;
        }
        else if (move > 0 && _facingLeft)
        {
            _spriteRenderer.flipX = false;
            _facingLeft = false;
        }

        _animator.SetBool("walking", move != 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
            _isGrounded = true;
    }
}
