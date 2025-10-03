using UnityEngine;
using UnityEngine.UI;

public class ChangeBackground : MonoBehaviour
{
    private RawImage rawImage;
    private int index;
    public Texture[] texturas;
    private float timerInicial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rawImage = GetComponent<RawImage>();
        timerInicial = 2;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeScreen();
    }

    void ChangeScreen()
    {
        timerInicial -= Time.deltaTime;

        if(timerInicial < 0)
        {
            rawImage.texture = texturas[Random.Range(0, 2)];

            float timerRandomizer = Random.Range(2, 3);
            timerInicial = timerRandomizer;
        }
    }
}
