using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2f;
    public float patrolDistance = 3f;

    private Rigidbody2D rb;
    private Vector2 startPosition;
    private int direction = 1;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(direction * speed, rb.velocity.y);

        if (Mathf.Abs(transform.position.x - startPosition.x) >= patrolDistance)
        {
            Flip();
        }
    }

    void Flip()
    {
        direction *= -1;
        transform.localScale = new Vector3(direction, 1, 1);
    }
}
