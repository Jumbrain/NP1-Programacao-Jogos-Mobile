using UnityEngine;

public class LongNoteDireita : MonoBehaviour
{
    private LongNote longNote;

    void Start()
    {
        longNote = gameObject.GetComponentInParent<LongNote>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Colisao"))
        {
            longNote.canBeReleased = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Colisao"))
        {
            longNote.canBeReleased = false;
        }
    }
}
