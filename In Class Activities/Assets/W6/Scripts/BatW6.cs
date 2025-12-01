using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    private GameObject _cat;
    private bool _isChasing = false;

    void Start()
    {
        _cat = GameObject.Find("Cat");
        StartChasing();
    }

    void Update()
    {
        if (_isChasing && _cat != null)
        {
            Vector3 direction = _cat.transform.position - transform.position;
            direction.Normalize();
            transform.position += direction * _speed * Time.deltaTime;            
        }
    }
    public void StartChasing()
    {
        _isChasing = true;
    }

    public void StopChasing()
    {
        _isChasing = false;
    }
}
