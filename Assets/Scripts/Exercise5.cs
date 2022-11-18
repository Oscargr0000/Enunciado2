using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Exercise5 : MonoBehaviour
{
    public TMP_InputField yearInput;
    public TextMeshProUGUI text;
    public Image imagen;
    public Sprite[] horoscopo;
    public string[] nombres;

    public void CalculateYear()
    {
        int numInput = int.Parse(yearInput.text);

        int resultCalcul = numInput % 12;

        imagen.sprite = horoscopo[resultCalcul];
        text.text = "Your sign in the Chinese horoscope is " + nombres[resultCalcul];
    }
}
