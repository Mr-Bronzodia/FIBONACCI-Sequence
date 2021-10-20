using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckButtonLogic : MonoBehaviour
{
    public GameObject lastInteracedBox = null;

    private void OnMouseDown()
    {
        if (lastInteracedBox)
        {
            lastInteracedBox.GetComponent<BoxScoreLogic>().CheckForComplition();
        }
    }
}
