using UnityEngine;

public class BeatDestroyer : MonoBehaviour
{
    private RhythmController rhythmController;

    void Start()
    {
        rhythmController = GetComponent<RhythmController>();
    }

    void Update()
    {
        if (rhythmController.correctTiming && Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                rhythmController.index++;
                AddPoints();
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
