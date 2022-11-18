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

    void Start()
    {
        currentTime = maxTime; // The max time is set in the inspector
    }

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
