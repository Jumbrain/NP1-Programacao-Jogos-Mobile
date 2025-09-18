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
                AddPoints();
            }
        }
    }

    void AddPoints()
    {
        Destroy(rhythmController.currentBeat);
        rhythmController.pontos += 10;
    }
}
