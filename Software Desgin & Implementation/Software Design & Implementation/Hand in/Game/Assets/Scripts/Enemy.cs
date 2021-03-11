//using UnityEngine;
//using System.Collections;
//
//public class Enemy : MonoBehaviour {
//
//	public int speed = 5;					//Distance player can move
//	public int startHealth = 4;				//Starting Health of the player
//	public int currentHealth;			//current health of player
//	public int enemyDefence (Game defenceRoll);		//This will get the amount of defence gained from the dice roll for defence
//	public int enemyAttack (Game attackRoll);		//This will get the amount of attck gained from the dice roll for attack
//	bool playerInRange = false;                         // Whether player is within the trigger collider and can be attacked.
//	bool playerTurn;
//
//	GameObject enemy;
//	GameObject player;
//	bool isDead;
//
//	void Awake()
//	{
//		startHealth = currentHealth;								//set the starting health as current health when the game starts
//		enemy = GameObject.FindGameObjectWithTag ("Enemy");			//get reference to the enemy object 
//		player = GameObject.FindGameObjectWithTag ("Player");		//get reference to the player object 
//	}
//
//
//	void Update()
//	{
//		if (currentHealth <= 0) 				//if enemy health is smaller or equal to 1....
//		{ 			
//			Destroy (enemy);					// destroy the enemy object
//			isDead = true;						//set the death flag so this can only happen once
//
//		if(playerInRange && currentHealth > 0)
//			{
//				// ... attack.
//				Attack ();
//			}
//		}
//
//	}
//
//	void OnTriggerEnter (Collider other)
//	{
//		// If the entering collider is the player...
//		if(other.gameObject == player)
//		{
//			// ... the player is in range.
//			playerInRange = true;
//		}
//	}
//	
//	
//	void OnTriggerExit (Collider other)
//	{
//		// If the exiting collider is the player...
//		if(other.gameObject == player)
//		{
//			// ... the player is no longer in range.
//			playerInRange = false;
//		}
//	}
//
//
//	public void TakeDamage (int amount)
//	{
//		currentHealth -= amount;			//reduce the current health by damage amount
//	}
//
//	public void Attack()
//	{
//		// If the player has health to lose...
//		if(player.GetComponent<LeoricCode>().currentHealth > 0)
//		{
//			// ... damage the player.
//			player.GetComponent<LeoricCode>().TakeDamage(enemyAttack);
//		}
//	}
//
//	public void Move ()
//	{
//		if (transform.position = 0 && playerTurn) 
//		{
//			transform.position += 1;
//		}
//
//	}
//
//}
