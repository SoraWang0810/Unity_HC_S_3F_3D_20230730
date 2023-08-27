using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public Animator ani;

    private string parRun = "開關跑步";

    private void Awake()
    {
        float ramdomSpeed = Random.Range(3f, 6f);
        agent.speed = ramdomSpeed;
    }

    private void Start()
    {
        ani.SetBool(parRun, true);
    }

    private void Update()
    {
        agent.SetDestination(player.position);
    }
}
