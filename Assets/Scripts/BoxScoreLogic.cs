using TMPro;
using UnityEngine;

public class BoxScoreLogic : MonoBehaviour
{
    public int correnctScore = 0;
    public int CurrentScore { get; private set; }

    public bool isComplete { get; private set; } = false;

    public GameObject ScoreText;


    public void UpdateScore()
    {
        CurrentScore++;
        ScoreText.GetComponent<TextMeshPro>().text = CurrentScore.ToString();
    }

    public void CheckForComplition()
    {

        if (CurrentScore == correnctScore)
        {
            Debug.Log("Correct");
            isComplete = true;
        }
        else
        {
            CurrentScore = 0;
            ScoreText.GetComponent<TextMeshPro>().text = CurrentScore.ToString();
            Debug.Log("Wrong");
        }
    }

}
