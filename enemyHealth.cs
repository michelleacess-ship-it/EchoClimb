using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 1;

    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector2 contactPoint = collision.contacts[0].normal;

            // Se o jogador vier de cima
            if (contactPoint.y < -0.5f)
            {
                TakeDamage(1);
            }
        }
    }
}
