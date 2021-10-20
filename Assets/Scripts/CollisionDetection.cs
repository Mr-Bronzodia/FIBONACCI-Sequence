using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject Rock;
    public GameObject ScoreText;
    public GameObject Button;
    public int CurrentScore { get; private set; } = 0;

    
    //This function detects if the rock hit the crate
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Rock_02" | collision.gameObject.name == "Rock_02(Clone)") //This is hardcoded and has to be changed for final version 
        {
            CurrentScore++;
            ScoreText.GetComponent<TextMeshPro>().text = CurrentScore.ToString();
            Destroy(collision.gameObject);
            gameObject.GetComponent<BoxScoreLogic>().UpdateScore(CurrentScore);
            Button.GetComponent<CheckButtonLogic>().lastInteracedBox = gameObject;
        }        
    }
}
