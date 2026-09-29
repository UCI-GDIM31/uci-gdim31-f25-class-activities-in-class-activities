using UnityEngine;
using UnityEngine.AI;

// A minimal DeerW5 component that uses a NavMeshAgent.
// This keeps the class structure similar to CatW5 (it's a MonoBehaviour),
// but uses NavMesh functionality instead of manual Translate.
public class DeerW5 : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private Transform _target; // optional: assign a target in Inspector

    private void Reset()
    {
        // Try to auto-assign a NavMeshAgent if one exists on the same GameObject
        if (_agent == null)
        {
            _agent = GetComponent<NavMeshAgent>();
        }
    }

    private void Update()
    {
        // If a target is provided, continuously set the agent's destination to it.
        // This is a simple, clear behavior and demonstrates usage of NavMeshAgent.
        if (_agent != null && _target != null)
        {
            _agent.SetDestination(_target.position);
        }

        // If you want wandering behavior instead, you can implement a random
        // destination picker here (not included because the instructions were minimal).
    }
}