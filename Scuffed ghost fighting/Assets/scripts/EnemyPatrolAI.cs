using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolAI : MonoBehaviour
{
    private GameObject Player;
    public float moveSpeed = 0.5f;
    int MinDist = 5;
    private AudioSource AtkSfx;
    public float fireRate = 0.5f;
    private float nextFire;


    // Start is called before the first frame update
    void Awake()
    {
        Player = GameObject.Find("Player");
        AtkSfx = gameObject.GetComponent<AudioSource>();
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
            if (Time.time > nextFire)
            {
                // Update the time when the ghost can fire next
                nextFire = Time.time + fireRate;
                // play damage dealing sound
                AtkSfx.Play();
                // deal damage to player
                PlayerHealthManagement PHM = Player.GetComponent<PlayerHealthManagement>();
                PHM.takeDamage(1f); 
            }
        }
    }
}
