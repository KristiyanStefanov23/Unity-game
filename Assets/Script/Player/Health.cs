using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int maxHealth = 400;
    public int currentHealth;
    public int damage = 0;

    public Health_Bar healthBar;

    public bool attacked = false;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
            Die();
    }

    public void Die()
    {
        SceneManager.LoadScene("Dungeon_1");
    }
}
