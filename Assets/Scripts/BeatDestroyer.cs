using UnityEngine;

public class BeatDestroyer : MonoBehaviour
{
    private RhythmController rhythmController;

    [Header("Animação")]
    public GameObject hud;
    public Animator animator;

    void Start()
    {
        rhythmController = GetComponent<RhythmController>();
        animator = hud.GetComponent<Animator>();
    }

    void Update()
    {
        if (rhythmController.correctTiming && Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                rhythmController.index++;
                AddPoints();
                animator.Play("ClickAnimation");
            }
        }
    }

    void AddPoints()
    {
        Destroy(rhythmController.currentBeat);
        rhythmController.combo++;
        rhythmController.comboFalho = false;

        float comboPoints = new float();
        comboPoints = rhythmController.combo * 5;
        rhythmController.pontos += 10.0f + comboPoints;
    }
}
