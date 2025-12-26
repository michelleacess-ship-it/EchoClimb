using UnityEngine;

public class HazardTile : MonoBehaviour
{
    public int damage = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        if (GameManager.Instance != null)
        {
            GameManager.Instance.LoseLife();
        }
    }
}
