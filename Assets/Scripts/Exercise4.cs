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


    // Select a random number (1 or 2) to select the rigth answer;
    private void SelectCorrect()
    {
        randomNum = Random.Range(1, 3);
    }


    //When the button is pressed, validates if the answer is rigth, and create another random answer for the next round
    public void Selection(int value)
    {
        if (roundCounter < 10)
        {
            if (randomNum == value)
            {
                correctCounter++;
            }
            else
            {
                mistakeCounter++;
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

    //When the rounds are completed, ativate the finish board and show the results;
    private void InstantiateResult()
    {
        resumeCanvas.SetActive(true);
        correctText.text = correctCounter.ToString();
        incorrectText.text = mistakeCounter.ToString();

    }
}
