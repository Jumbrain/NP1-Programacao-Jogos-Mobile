using UnityEngine;

public class LongNoteEsquerda : MonoBehaviour
{
    private LongNote longNote;
    public Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        longNote = gameObject.GetComponentInParent<LongNote>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Colisao"))
        {
            longNote.canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Colisao"))
        {
            longNote.canBePressed = false;
        }
    }
}
