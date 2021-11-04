using System.Collections.Generic;
using UnityEngine;

public class CheckButtonLogic : MonoBehaviour
{
    public GameObject lastInteracedBox = null;

    public List<GameObject> listOfBoxes = new List<GameObject>();

    private List<bool> temp = new List<bool>();

    private void OnMouseDown()
    {

        if (lastInteracedBox)
        {
            lastInteracedBox.GetComponent<BoxScoreLogic>().CheckForComplition();
        }

        foreach(GameObject box in listOfBoxes)
        {
            if (box.GetComponent<BoxScoreLogic>().isComplete)
            {
                temp.Add(true);
            }
        }

        if (listOfBoxes.Count == temp.Count)
        {
            Debug.Log("You won!");
        }

        temp = new List<bool>();
    }
}
