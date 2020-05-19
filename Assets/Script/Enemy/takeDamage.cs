using UnityEngine;

public class takeDamage : MonoBehaviour
{
    public int health = 1;

    public void SetMaxHealthEnemy(int setHealth)
    {
        health = setHealth;
    }

    public void Hit(int damageTaken)
    {
        health -= damageTaken;

        if (health <= 0)
            Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }
}