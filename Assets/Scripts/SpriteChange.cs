using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] sprites;
    public RhythmController rhythmController;
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        AlterarSprite();

        if (rhythmController.index > 1)
        {
            rhythmController.index = 0;
        }
    }

    void AlterarSprite()
    {
        spriteRenderer.sprite = sprites[rhythmController.index];
    }
}
