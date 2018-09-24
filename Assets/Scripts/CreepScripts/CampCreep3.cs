using UnityEngine;
using System.Collections;

public class CampCreep3 : CampCreep {

	protected int thisCreepHealth = 200;
	private int damage = 30;
	private int reward = 50;
	
	private float agroRange = 15.0f;
	private float attackRange = 3.0f;
	private float attackSpeed = 1.25f;

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
