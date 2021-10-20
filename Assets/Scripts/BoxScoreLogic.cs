using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScoreLogic : MonoBehaviour
{
    public int correnctScore = 0;
    public int CurrentScore { get; private set; }

    public void UpdateScore(int score)
    {
        CurrentScore = score;
    }

    public void CheckForComplition()
    {
        if(CurrentScore == correnctScore)
        {
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log("Wrong");
        }
    }

}
