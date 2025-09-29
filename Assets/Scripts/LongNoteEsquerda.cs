using UnityEngine;

public class LongNoteEsquerda : MonoBehaviour
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
            longNote.canBePressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Colisao"))
        {
            longNote.canBePressed = false;
        }
    }
}
