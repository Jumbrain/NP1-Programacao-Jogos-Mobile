using System;
using TMPro;
using UnityEngine;

public class RhythmController : MonoBehaviour
{
    public bool correctTiming = false;
    public GameObject currentBeat;
    public float pontos;
    public int combo = 0;
    public bool comboFalho;

    [SerializeField] private TextMeshProUGUI tmpPonto;
    [SerializeField] private TextMeshProUGUI tmpCombo;

    void Start()
    {

    }

    void Update()
    {
        tmpPonto.text = pontos.ToString();
        tmpCombo.text = combo.ToString();
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