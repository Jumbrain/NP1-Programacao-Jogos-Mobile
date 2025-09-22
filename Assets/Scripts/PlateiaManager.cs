using Unity.Burst.Intrinsics;
using UnityEngine;

public class PlateiaManager : MonoBehaviour
{
    private Animator animator;
    private GameObject plateia;
    public RhythmController rhythmController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        plateia = gameObject.GetComponent<GameObject>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Plateia();
    }

    void Plateia()
    {
        if(rhythmController.combo >= 10)
        {
            animator.SetBool("ComboIniciar", true);
        }

        if(rhythmController.combo == 0)
        {
            animator.SetBool("ComboIniciar", false);
            animator.SetBool("ComboFalho", true);
        }

    }
}
