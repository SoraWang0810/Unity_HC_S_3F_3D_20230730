using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public Animator ani;

    private string PARAMRUN = "¶}Ãö¶]¨B";

    private void Awake()
    {
        float randomSpeed = Random.Range(2f, 5f);
        //print($"{randomSpeed}");
        agent.speed = randomSpeed;
    }

    private void Start()
    {
        ani.SetBool(PARAMRUN, true);
    }

    private void Update()
    {
        agent.SetDestination(player.position);
    }
}
