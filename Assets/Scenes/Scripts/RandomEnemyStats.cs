using UnityEngine;
using UnityEngine.AI;

public class RandomEnemyStats : MonoBehaviour
{
    private NavMeshAgent agent;

    public float minSpeed = 3f;
    public float maxSpeed = 6f;

    public float minAcceleration = 4f;
    public float maxAcceleration = 3f;

    public float minAngularSpeed = 5f;
    public float maxAngularSpeed = 4f;

    public float minStoppingDistance = 0.5f;
    public float maxStoppingDistance = 2f;

    public int minPriority = 2;
    public int maxPriority = 8;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.speed = Random.Range(minSpeed, maxSpeed);
        agent.acceleration = Random.Range(minAcceleration, maxAcceleration);
        agent.angularSpeed = Random.Range(minAngularSpeed, maxAngularSpeed);
        agent.stoppingDistance = Random.Range(minStoppingDistance, maxStoppingDistance);
        agent.avoidancePriority = Random.Range(minPriority, maxPriority);
    }
}
