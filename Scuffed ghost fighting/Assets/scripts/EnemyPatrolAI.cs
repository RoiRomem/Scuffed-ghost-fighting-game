using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolAI : MonoBehaviour
{
    private GameObject Player;
    public float moveSpeed = 0.5f;
    int MinDist = 5;    

    // Start is called before the first frame update
    void Awake()
    {
        Player = GameObject.Find("Player");
    }

    
    void FixedUpdate()
    {
        transform.LookAt(Player.transform);

        if (Vector3.Distance(transform.position, Player.transform.position) >= MinDist)
        {
            transform.position += transform.forward * moveSpeed;
        } 
        else
        {
            //deal damage to player
        }
    }
}
