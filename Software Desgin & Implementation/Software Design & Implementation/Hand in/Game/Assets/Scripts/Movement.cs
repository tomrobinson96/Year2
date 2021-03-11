using UnityEngine;
using System.Collections;

//Author: Connor Gamble
//Student Number: 1400730

public class Movement : MonoBehaviour
{
    public Transform startPosition, endPosition, objTransform;
    public float speed, moveStat;
    public int AP = 0;
    public static int playerHealth = 10;

    void Start()
    {
        SetStartPosition();
    }

    void Update()
    {
        OnClick();
        Debug.Log("PlayerHealth = " + playerHealth);
    }

    void OnClick()
    {
        if (GameObject.Find("GameManager").GetComponent<GameManager>().heroTurn)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Map" && AP < 2) //Uses a raycast to detect whether the mouse is clicking on the map and check action points --NEED TO ADD IN MOVE ACTION CHECKED--
                {
                    Debug.Log("HIT THE MAP");
                    GetTransform();
                    endPosition = hit.transform; //gets the transform which the player wants to move to
                    AP++;
                    MoveObj(); //moves the object to the obtained transform
                }
                else
                {
                    Debug.Log("No AP remaining");
                    return; //--Need to display that the player has no AP remaining--
                }
            }
            //method to gain a new position for the player to move to
            //call a method checks the movement stat of the player along with the action points
            MovementCheck();
        }
    }

    void MovementCheck()
    {
        moveStat = 5f; //--INSERT HERO DATABASE LINK HERE--
        //check the movement stat of a hero along with the amount of actions which have been performed for that move

    }
    Transform GetTransform()
    {
        objTransform = this.transform; //returns the transform of the object
        return objTransform;
    }

    void SetStartPosition()
    {
        startPosition = this.transform;
    }

    void MoveObj()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPosition.position, speed * Time.deltaTime);
    }

    void EndTurn()
    {

    }

    void OnTriggerEnter(Collider other)
    {

    }
}






//   -------------------------- OLD CODE SNIPPET HERE -----------------------------------------
//public Transform startPositionGo, endPositionGo; //The position you move from and to
//float startTime, totalDistanceToDestination;

//// Use this for initialization
//void Start () 
//{
//    startTime = Time.time;
//    totalDistanceToDestination = Vector3.Distance(startPositionGo.position, endPositionGo.position);
//}

//// Update is called once per frame
//void Update () 
//{
//    float currentDuration = Time.time - startTime;
//    float journeyFraction = currentDuration / totalDistanceToDestination; //Lerping is a constant rate and needs to compare time to distance
//    transform.position = Vector3.Lerp(startPositionGo.position, endPositionGo.position, journeyFraction); //Current position, where you are going, how long it will take to get there
//}
