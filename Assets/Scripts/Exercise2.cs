using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise2 : MonoBehaviour
{
    public float maxTime;
    private float currentTime;

    public Image backgroundCrono;
    public TextMeshProUGUI cronoText;

    // Start is called before the first frame update
    void Start()
    {

        currentTime = maxTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        cronometro();
    }

    void cronometro()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0f)
        {
            currentTime = 0f;
        }

        cronoText.text = currentTime.ToString("f2");

        backgroundCrono.fillAmount = currentTime / maxTime;

        
    }
}
