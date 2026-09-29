using UnityEngine;

public class CatW5 : MonoBehaviour
{
    [SerializeField] private bool _flipWSControls;
    [SerializeField] private float _moveSpeed = 1.0f;
    [SerializeField] private float _turnSpeed = 1.0f;
    [SerializeField] private Animator _animator;

    private string _isWalkingName = "IsWalking";

    private void Update()
    {
        // STEP 1 & 2 ---------------------------------------------------------
        // STEP 1:
        // Move forwards/backwards with W and S (Vertical axis).
        // Use Vector3.forward/back (static Vector3 properties) and Translate
        // together with _moveSpeed and Time.deltaTime.

        Vector3 translation = Vector3.zero;

        // Get vertical input (W / S)
        float vertical = Input.GetAxis("Vertical"); // W = +1, S = -1

        // Use Vector3.forward (local forward) scaled by input
        translation = Vector3.forward * vertical;

        // STEP 2:
        // If _flipWSControls is true, interpret the translation as the opposite value.
        if (_flipWSControls)
        {
            // Multiply translation by -1 to flip controls
            translation *= -1f;
        }

        // Apply movement: translation defines direction, multiply by speed and deltaTime
        transform.Translate(translation * _moveSpeed * Time.deltaTime);

        // Rotation (unchanged)
        float rotation = Input.GetAxis("Horizontal") * _turnSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

        // Animator: walking if moving or rotating
        if (translation.magnitude != 0.0f || rotation != 0.0f)
        {
            _animator.SetBool(_isWalkingName, true);
        }
        else
        {
            _animator.SetBool(_isWalkingName, false);
        }
    }
}
