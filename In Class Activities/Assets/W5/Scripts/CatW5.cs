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
        // STEP 1
        Vector3 translation = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            translation += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            translation += Vector3.back;
        }

        if (_flipWSControls)
        {
            translation *= -1f;
        }

        translation *= _moveSpeed * Time.deltaTime;

        transform.Translate(translation, Space.World);

        // STEP 1 & 2 ---------------------------------------------------------

        float rotation = Input.GetAxis("Horizontal") * _turnSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

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
