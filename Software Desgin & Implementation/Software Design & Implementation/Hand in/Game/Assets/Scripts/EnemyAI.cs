using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{


    //Author: Connor Gamble
    //Student Number: 1400730

    public int movement, dmgDealt, health;
    public bool overLordWin, heroWin, heroInTrig, haveHitThisTurn;

    void Start()
    {
        movement = 0;
        health = 4;
        haveHitThisTurn = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("GameManager").GetComponent<GameManager>().heroTurn)
        {
            if (heroInTrig == false)
            {
                if (movement < 2 && tag == "Enemy")
                {
                    if (transform.position.x > -4.6)
                    {
                        transform.Translate(Vector3.left * Time.deltaTime, Camera.main.transform);
                    }
                    else if (transform.position.x <= -4.5)
                    {
                        transform.Translate(Vector3.up * Time.deltaTime, Camera.main.transform);
                    }
                    //Move the transform of the object minus one on the x axis
                    //when it is less then -3
                    //then it is to move up on the y axis 
                }
            }
            else
            {
                if (!haveHitThisTurn)
                {
                    dmgDealt = Random.Range(0, 4);
                    if (dmgDealt <= 1)
                    {
                        dmgDealt = dmgDealt - 1;
                    }
                    Movement.playerHealth = Movement.playerHealth - dmgDealt;
                    haveHitThisTurn = true;
                }   
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Map")
        {
            //Debug.Log("movement++");
            movement++;
        }
        if(other.tag == "Player")
        {
            heroInTrig = false;
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            heroInTrig = true; 
        }
    }
}
