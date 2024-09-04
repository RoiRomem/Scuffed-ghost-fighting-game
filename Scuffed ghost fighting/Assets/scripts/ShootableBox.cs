using UnityEngine;
using System.Collections;

public class ShootableBox : MonoBehaviour
{
    public GameObject gotodestroy;
    //The box's current health point total
    public int currentHealth = 3;
    public int scoreGiven = 200;

    public void Damage(int damageAmount)
    {
        //subtract damage amount when Damage function is called
        currentHealth -= damageAmount;

        //Check if health has fallen below zero
        if (currentHealth <= 0)
        {
            //give score on death
            GameObject.Find("Player").GetComponent<PlayerScoreManagement>().AddScore(scoreGiven);
            //if health has fallen below zero, deactivate it 
            Destroy(gotodestroy);
        }
    }
}