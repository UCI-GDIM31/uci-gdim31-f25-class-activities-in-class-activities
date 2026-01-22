using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
public class DeerW5 : MonoBehaviour
{
    [SerializeField] private Transform _transform;

    private void Start()
    {
        NavMeshAgent _navMeshAgent = GetComponent<NavMeshAgent>();

        _navMeshAgent.SetDestination(_transform.position);
    }
//private void Update ()

}

// public class DeerW5 : MonoBehaviour
// If you copied the class declaration from CatW5, you'd only need to change one thing...