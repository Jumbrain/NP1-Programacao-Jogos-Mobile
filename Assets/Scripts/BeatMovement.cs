using UnityEngine;

public class BeatMovement : MonoBehaviour
{
    public Vector2 destino = Vector2.zero;
    public float velocity;


    public Rigidbody2D rb;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.interpolation = RigidbodyInterpolation2D.Interpolate;
    }

    private void FixedUpdate()
    {
        Vector2 direction = (destino - (Vector2)transform.position).normalized;
        rb.linearVelocity = velocity * direction;
    }
}
