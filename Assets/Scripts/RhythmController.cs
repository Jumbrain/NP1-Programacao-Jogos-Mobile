using System;
using TMPro;
using UnityEngine;

public class RhythmController : MonoBehaviour
{
    public bool correctTiming = false;
    public GameObject currentBeat;
    public int pontos;
    public TextMeshProUGUI tmp;

    void Start()
    {
        
    }

    void Update()
    {
        tmp.text = "pontos " + pontos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Ritmo"))
        {
            correctTiming = true;
            currentBeat = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ritmo"))
        {
            correctTiming = false;
        }
    }
}