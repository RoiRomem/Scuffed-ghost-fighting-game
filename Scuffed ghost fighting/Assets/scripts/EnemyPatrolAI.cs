using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolAI : MonoBehaviour
{
    private Transform Player;
    public float moveSpeed = 1f;

    // Start is called before the first frame update
    void Awake()
    {
        Player = GameObject.Find("Player").transform;
    }

    
    void FixedUpdate()
    {
        transform.LookAt(Player);
        transform.position += transform.forward * moveSpeed;
    }
}
