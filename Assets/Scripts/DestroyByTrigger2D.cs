using UnityEngine;

public class DestroyByTrigger2D : MonoBehaviour
{
    public RhythmController rhythmController;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        rhythmController.combo = 0;
        rhythmController.comboFalho = true;
    }
}
