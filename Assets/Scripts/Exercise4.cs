using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise4 : MonoBehaviour
{
    private int correctCounter;
    private int mistakeCounter;
    private int roundCounter = 1;

    private int randomNum;

    public TextMeshProUGUI roundText;
    public TextMeshProUGUI correctText;
    public TextMeshProUGUI incorrectText;

    public GameObject resumeCanvas;

    private void Start()
    {
        SelectCorrect();
        roundText.text = roundCounter.ToString();
        resumeCanvas.SetActive(false);
    }

    private void Update()
    {
        //BORRAR
        if (Input.GetKeyDown(KeyCode.F))
        {
            SelectCorrect();
        }
    }


    private void SelectCorrect()
    {
        randomNum = Random.Range(1, 3);
    }


    public void Selection(int value)
    {
        if (roundCounter < 10)
        {
            if (randomNum == value)
            {
                correctCounter++;
                Debug.Log("Correcto" + correctCounter);
            }
            else
            {
                mistakeCounter++;
                Debug.Log("Incorrecto" + mistakeCounter);
            }

            SelectCorrect();
            roundCounter++;
            if (roundCounter >= 10)
            {
                InstantiateResult();
            }
        }
       
        roundText.text = roundCounter.ToString();
    }

    private void InstantiateResult()
    {
        resumeCanvas.SetActive(true);
        correctText.text = correctCounter.ToString();
        incorrectText.text = mistakeCounter.ToString();

    }
}
