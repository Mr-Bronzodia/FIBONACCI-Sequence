using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject Rock;
    public GameObject Button;

    public void Start()
    {
        Button.GetComponent<CheckButtonLogic>().listOfBoxes.Add(gameObject);
    }

    //This function detects if the rock hit the crate
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Rock_02" | collision.gameObject.name == "Rock_02(Clone)") //This is hardcoded and has to be changed for final version 
        {
            if (!gameObject.GetComponent<BoxScoreLogic>().isComplete)
            {
                Destroy(collision.gameObject);
                gameObject.GetComponent<BoxScoreLogic>().UpdateScore();
                Button.GetComponent<CheckButtonLogic>().lastInteracedBox = gameObject;
            }
        }        
    }
}
