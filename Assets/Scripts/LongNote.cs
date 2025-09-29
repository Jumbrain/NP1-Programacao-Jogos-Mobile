using UnityEngine;

public class LongNote : MonoBehaviour
{
    public bool canBePressed;
    public bool canBeReleased;

    private LongNoteEsquerda longNoteEsquerda;
    //public GameObject middle;
    //public GameObject rightNote;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        longNoteEsquerda = gameObject.GetComponentInChildren<LongNoteEsquerda>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canBePressed == true && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            HoldingNote();
        }
    }

    void HoldingNote()
    {
        longNoteEsquerda.rb.constraints = RigidbodyConstraints2D.FreezePosition;

        if (canBeReleased == true && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            ReleaseNoteCorrectly();
        }
    }

    void ReleaseNoteCorrectly()
    {
        Destroy(gameObject);
    }
}
