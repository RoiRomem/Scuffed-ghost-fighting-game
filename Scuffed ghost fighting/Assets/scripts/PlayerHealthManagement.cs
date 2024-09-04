using UnityEngine;

public class PlayerHealthManagement : MonoBehaviour
{
    public float playerHealth = 10;

    public void takeDamage(float damage)
    {
        playerHealth = playerHealth - damage;

        if (playerHealth <= 0)
        {
            //kill player
            Debug.Log("player is dead");
        }
    }
}
