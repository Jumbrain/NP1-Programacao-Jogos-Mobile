using UnityEngine;

public class DestroyByTriggerLongMiddleNote : MonoBehaviour
{
     public RhythmController rhythmController;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NotaMeio"))
        {
            Destroy(collision.gameObject);
            rhythmController.combo = 0;
            rhythmController.comboFalho = true;

        }
    }
}

//Eu criando um script diferente só por causa de uma barra:
//bleeeeeeeh d: