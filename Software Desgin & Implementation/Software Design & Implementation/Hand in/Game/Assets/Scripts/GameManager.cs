 using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Author: Connor Gamble
//Student Number: 1400730

public class GameManager : MonoBehaviour {

    public bool heroTurn, overlordWin;
    public int escapedEnemies, gobSpawn = 1;
    public GameObject Goblin;
    public GameObject[] gobArray;


    //public GameObject[] GobArray;
    //public List<GameObject> gobList;


	// Use this for initialization
	void Start () 
    {
        heroTurn = true;
        //gobList = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if(heroTurn == false)
        {
            OverLordTurn();
        }

        else if (heroTurn == true)
        {
            HeroTurn();
        }

        if (GameObject.Find("GameManager").GetComponent<GameManager>().escapedEnemies >= 5)
        {
            //overlord has won
            overlordWin = true;
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(heroTurn)
            {
                heroTurn = false;
            }
            else
            {
                heroTurn = true;
            }
        }
	}

    void OverLordTurn()
    {
        //instantiate a goblin here
        if (gobSpawn < 1)
        {
            Instantiate(Goblin);
            //gobList.Add((GameObject)Instantiate(Goblin));
            //Debug.Log(gobList.Count);
            gobSpawn++;
        }
        GameObject.Find("Player").GetComponent<Movement>().AP = 0;
    }

    void HeroTurn()
    {
        //GameObject.Find("Goblin").GetComponent<EnemyAI>().movement = 0;
        //GameObject.Find("Goblin(Clone)").GetComponent<EnemyAI>().movement = 0;
        //GameObject.FindGameObjectsWithTag("Goblin").GetComponents<EnemyAI>().movement = 0;
        //The original way to tackle the resetting of the movment would have just been to access the variable through the component 

        gobArray = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (var obj in gobArray)
        {
            obj.GetComponent<EnemyAI>().movement = 0;
            gobSpawn = 0;
            obj.GetComponent<EnemyAI>().haveHitThisTurn = false;
            //goes through all of the objects with the tag goblin and resets the movement to 0 so it can move again next turn

        }
    }


}
