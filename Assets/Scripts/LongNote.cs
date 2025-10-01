using UnityEngine;

public class LongNote : MonoBehaviour
{
    public bool canBePressed;
    public bool canBeReleased;
    private Rigidbody2D rb;

    public GameObject hudMenor;
    private RhythmController rhythmController;
    private LongNoteEsquerda longNoteEsquerda;
    public GameObject ritmoControlador;


    void Awake()
    {
        hudMenor = GameObject.FindGameObjectWithTag("HUDLongNote");
    }

    void Start()
    {
        ritmoControlador = GameObject.Find("Colisão");
        rb = gameObject.GetComponent<Rigidbody2D>();
        longNoteEsquerda = gameObject.GetComponentInChildren<LongNoteEsquerda>();
        rhythmController = ritmoControlador.GetComponent<RhythmController>();

        hudMenor.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:

                    if (canBePressed)
                        {
                            rhythmController.index++;
                            HoldingNote();
                        }
                    ;
                    break;

                case TouchPhase.Ended:
                    if (canBeReleased)
                        {
                            rhythmController.index++;
                            ReleaseNoteCorrectly();
                        }

                    if (canBeReleased == false && canBePressed)
                    {
                        ReleaseNoteIncorrectly();
                    }
                    break;
            }
        }
    }


    void HoldingNote()
    {
        longNoteEsquerda.rb.constraints = RigidbodyConstraints2D.FreezePosition;
        hudMenor.SetActive(true);
    }

    void ReleaseNoteCorrectly()
    {
        AddPoints();
        Destroy(gameObject);
        hudMenor.SetActive(false);
    }

    void AddPoints()
    {
        rhythmController.combo++;
        rhythmController.comboFalho = false;

        float comboPoints = new float();
        comboPoints = rhythmController.combo * 5;
        rhythmController.pontos += 20.0f + comboPoints;
    }

    void ReleaseNoteIncorrectly()
    {
        hudMenor.SetActive(false);
        Destroy(gameObject);
        rhythmController.combo = 0;
    }
}