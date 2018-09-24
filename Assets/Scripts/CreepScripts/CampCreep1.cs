using UnityEngine;
using System.Collections;

public class  CampCreep1: CampCreep {

	protected int thisCreepHealth = 150;
	private int damage = 5;
	private int reward = 20;
	
	private float agroRange = 20.0f;
	private float attackRange = 2.0f;
	private float attackSpeed = 0.75f;

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
