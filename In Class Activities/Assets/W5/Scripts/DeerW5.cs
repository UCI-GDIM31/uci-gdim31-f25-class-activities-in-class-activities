using UnityEngine;
using UnityEngine.AI;

public class DeerW5 : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private NavMeshAgent _agent;
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        if (_agent == null)
        {
            Debug.LogWarning("DeerW5: No NavMeshAgent found on this Deer.");
            return;
        }
        if (_target == null)
        {
            Debug.LogWarning("DeerW5: No target assigned for the Deer to walk toward.");
            return;
        }
        _agent.SetDestination(_target.position);
    }
}

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...