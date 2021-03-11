//using UnityEngine;
//using System.Collections;
//
//public class LeoricCode : MonoBehaviour {
//
//
//	public int speed = 4;					//Distance player can move
//	public int startHealth = 8;				//Starting Health of the player
//	public int currentHealth;			//current health of player
//	public int startStamina = 5;		//Strating Stamina of player
//	public void defence (Game defenceRoll);		//This will get the amount of defence gained from the dice roll for defence
//	public void attack (Game attackRoll);		//This will get the amount of attack gained from the dice roll for attack
//
//	GameObject enemy;
//	bool enemyInRange;
//	bool isDead;
//
//	void Awake()
//	{
//		startHealth = currentHealth;			//set the starting health as current health when the game starts
//		enemy = GameObject.FindGameObjectWithTag ("Enemy");			//get reference to the enemy object 
//		player = GameObject.FindGameObjectWithTag ("Player");		//get reference to the player object 
//
//	}
//
//	public void TakeDamage (int amount)
//	{
//		currentHealth -= amount;			//reduce the current health by damage amount
//	}
//
//
//
//	void OnTriggerEnter(Collider other)
//	{
//		if (other.gameObject == enemy) { 			//if the entering collider is the enemy
//			enemyInRange = true;				//the enemy is in range
//		}
//	}
//
//	void OnTriggerExit (Collider other)
//	{
//		if (other.gameObject == enemy) { 			//if the exiting collider is the enemy
//			enemyInRange = false;				//the enemy is not in range
//		}
//	}
//
//	void Update()
//	{
//		if (currentHealth <= 0) 			//if player health is smaller or equal to 1....
//		{
//			Destroy (GameObject.player);		// destroy the player object
//			isDead = true;						//set the death flag so this can only happen once    
//		}
//
//
//		if (enemyInRange  && currentHealth > 0)			//if enemy is in range and player is alive....
//		{
//			Special ();			// use special ability
//		}
//
//	}
//
//	void Special ()
//	{
//		if (enemy.GetComponent<Enemy> ().enemyAttack > 1)	//if attack amount is greater than 1....
//		{
//			enemy.GetComponent<Enemy> ().enemyAttack -= 1;				// reduce the enemy attack by 1
//		}
//	}
//}
//
//
//
//
