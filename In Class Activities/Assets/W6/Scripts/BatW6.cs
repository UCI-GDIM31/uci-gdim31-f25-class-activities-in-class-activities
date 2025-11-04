using UnityEngine;

public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;
    private Transform _playerTransform;
    private bool _isChasing = false;

    public bool IsChasing => _isChasing;

    public void SetPlayer(Transform player)
    {
        _playerTransform = player;
    }

    public void StartChasing() => _isChasing = true;

    public void StopChasing() => _isChasing = false;

    private void Update()
    {
        if (_isChasing && _playerTransform != null)
        {
            Vector3 direction = (_playerTransform.position - transform.position).normalized;
            transform.position += direction * _speed * Time.deltaTime;
        }
    }
}
