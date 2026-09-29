using UnityEngine;

public class MuskratW7 : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Collider _collider;
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _rotationSpeed = 100f;
    [SerializeField] private float _jumpForce = 5.0f;

    private bool _orbitMode;
    private Transform _sphereTransform;

    // ------------------------------------------------------------------------
    private void Update()
    {
        if (_orbitMode)
        {
            MoveOrbitMode();
        }
        else
        {
            MoveNormal();
        }

        Jump();
    }

    // ------------------------------------------------------------------------
    private void MoveOrbitMode()
    {
        // STEP 3 -------------------------------------------------------------
        float leftright = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");

        // Rotate Muskrat around the sphere
        Vector3 axis = transform.TransformDirection(Vector3.right);
        transform.RotateAround(
            _sphereTransform.position,
            axis,
            forward * _rotationSpeed * Time.deltaTime
        );

        // Rotate around the bubble's surface horizontally
        transform.RotateAround(
            _sphereTransform.position,
            transform.up,
            leftright * _rotationSpeed * Time.deltaTime
        );

        // STEP 5 -------------------------------------------------------------
        // Animate running or idle on bubble (no flying here)
        bool isMoving = Mathf.Abs(forward) > 0.1f || Mathf.Abs(leftright) > 0.1f;
        _animator.SetBool("running", isMoving);
        _animator.SetBool("flying", false);
        // STEP 5 -------------------------------------------------------------
    }

    // ------------------------------------------------------------------------
    private void MoveNormal()
    {
        // STEP 1 -------------------------------------------------------------
        float leftright = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, leftright * _rotationSpeed * Time.deltaTime);
        // STEP 1 -------------------------------------------------------------

        // STEP 2 -------------------------------------------------------------
        float movement = Input.GetAxis("Vertical");
        Vector3 moveDirection = transform.forward * movement * _moveSpeed * Time.deltaTime;
        transform.position += moveDirection;
        // STEP 2 -------------------------------------------------------------

        // STEP 4 -------------------------------------------------------------
        // Update animation states
        float verticalVelocity = _rigidbody.linearVelocity.y;
        bool isFlying = Mathf.Abs(verticalVelocity) > 0.1f && !_orbitMode;

        // Use input magnitude instead of rigidbody velocity for running
        bool isRunning = (Mathf.Abs(movement) > 0.1f || Mathf.Abs(leftright) > 0.1f) && !_orbitMode;

        _animator.SetBool("flying", isFlying);
        _animator.SetBool("running", isRunning);
        // STEP 4 -------------------------------------------------------------
    }

    // ------------------------------------------------------------------------
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.isKinematic = false;
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);

            if (_sphereTransform != null)
            {
                Destroy(_sphereTransform.gameObject);
                _sphereTransform = null;
            }

            _orbitMode = false;
        }
    }

    // ------------------------------------------------------------------------
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            _orbitMode = true;
            _rigidbody.isKinematic = true;

            _sphereTransform = collision.transform;

            ContactPoint contact = collision.GetContact(0);
            Vector3 tangent = Vector3.Cross(Vector3.right, contact.normal);

            transform.SetPositionAndRotation(
                contact.point,
                Quaternion.LookRotation(tangent, contact.normal)
            );
        }
    }
}