using UnityEngine;
using System.Collections;

public class  CampCreep2 : CampCreep {

	protected int thisCreepHealth = 100;
	private int damage = 10;
	private int reward = 35;
	
	private float agroRange = 18.0f;
	private float attackRange = 8.0f;
	private float attackSpeed = 1.0f;

	void Start()
	{
		health = thisCreepHealth;
	}

	void Update()
	{
		//CurrentState (this.gameObject.transform.position, agroRange, attackRange, attackSpeed, damage);
		
		//tests if the enemy is dead
		if (health <= 0)
		{
			Destroy (this.gameObject);
			//reward money to player
			player.GetComponent<Player>().RewardMoney(reward);
		}

		if (health <= 0) 
		{
			player.GetComponent<Player>().RewardMoney(reward);
		}
	}	
}
