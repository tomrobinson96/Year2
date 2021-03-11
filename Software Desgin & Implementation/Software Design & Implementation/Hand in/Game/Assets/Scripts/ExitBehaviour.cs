using UnityEngine;
using System.Collections;

//Author: Connor Gamble
//SID: 1400730

public class ExitBehaviour : MonoBehaviour {


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().escapedEnemies++;
            Destroy(other.gameObject);
        }
    }
}