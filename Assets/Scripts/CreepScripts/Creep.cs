using UnityEngine;
using System.Collections;

public class CampCreep: Health {
	
	protected float distanceToTarget = 0.0f;
	private float attackDelay = 0.0f;

	protected GameObject player;
	protected NavMeshAgent agent;
	private Vector3 home;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		home = transform.position;
		agent = this.gameObject.GetComponent<NavMeshAgent>();
	}

	//stopped working just before I submitted, I didn't change anything, the player isn't being set to this instance of player
	//PS. this really pissed me off because it was a big part of the game and it just randomly stopped working
	/*public void CurrentState(Vector3 thisCreepPosition, float agroRange, float attackRange, float attackSpeed, int damage)
	{
		float distance = Vector3.Distance(thisCreepPosition, player.transform.position);

		if (distance  <= attackRange)
		{
			agent.Stop ();
			Attack (attackSpeed, damage);
		} 
		else if (distance  <= agroRange) 
		{
			agent.Resume ();
			agent.SetDestination (player.transform.position);
		}
		else
			agent.SetDestination (home);
	}*/


	public void Attack(float attackSpeed, int damage)
	{
		if(Time.time >= attackDelay)
		{
			attackDelay = Time.time + attackSpeed;
			player.GetComponent<Player> ().TakeDamage(damage);
		}
	}
}
