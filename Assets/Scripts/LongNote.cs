using UnityEngine;

public class LongNote : MonoBehaviour
{
    public bool canBePressed;
    public bool canBeReleased;
    private Rigidbody2D rb;

    private RhythmController rhythmController;
    private LongNoteEsquerda longNoteEsquerda;
    public GameObject ritmoControlador;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ritmoControlador = GameObject.Find("Colisão");
        rb = gameObject.GetComponent<Rigidbody2D>();
        longNoteEsquerda = gameObject.GetComponentInChildren<LongNoteEsquerda>();
        rhythmController = ritmoControlador.GetComponent<RhythmController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (canBePressed && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            HoldingNote();
        }

        if (canBeReleased && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            ReleaseNoteCorrectly();
        }
    }


    void HoldingNote()
    {
        longNoteEsquerda.rb.constraints = RigidbodyConstraints2D.FreezePosition;
    }

    void ReleaseNoteCorrectly()
    {
        AddPoints();
        Destroy(gameObject);
    }

    void AddPoints()
    {
        rhythmController.combo++;
        rhythmController.comboFalho = false;

        float comboPoints = new float();
        comboPoints = rhythmController.combo * 5;
        rhythmController.pontos += 20.0f + comboPoints;
    }
}