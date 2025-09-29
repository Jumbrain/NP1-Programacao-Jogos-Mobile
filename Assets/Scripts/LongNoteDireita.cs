using UnityEngine;

public class LongNoteDireita : MonoBehaviour
{
    private LongNote longNote;
    public Rigidbody2D rb;

    void Start()
    {
        longNote = gameObject.GetComponentInParent<LongNote>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Colisao"))
        {
            longNote.canBeReleased = true;
        }
    }
}
