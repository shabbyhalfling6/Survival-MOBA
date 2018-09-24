using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player: Health {

	private int playerMoney = 200;
	private int playerHealth = 1000;
	private int damage = 100;

	private float attackRange = 5.0f;

	public GameObject spawnPosition;
	private Vector3 playerPosition;
	private Vector3 mousePosition;
	
	private NavMeshAgent agent;

	private Ray ray;
	private RaycastHit hit;

	public Camera camera;
	
	void Start()
	{
		camera = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera> ();
		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController>();
		uiController = GameObject.FindGameObjectWithTag ("UIController").GetComponent<UIController>();
		health = playerHealth;

		agent = this.gameObject.GetComponent<NavMeshAgent>();
	}

	void Update () 
	{
		Move ();
		Attack ();

		if (health <= 0)
		{
			Instantiate (this.gameObject, spawnPosition.transform.position, spawnPosition.transform.rotation);
			Destroy (this.gameObject);
		}
	}

	private void Move()
	{
		ray = camera.ScreenPointToRay (Input.mousePosition);
		
		if (Physics.Raycast (ray, out hit))
			mousePosition = hit.point;

		if (Input.GetMouseButton (1)) 
			agent.SetDestination (mousePosition);
	}
	
	private void Attack()
	{
		Debug.DrawLine (camera.transform.position, mousePosition, Color.green);

		if (Input.GetMouseButton (0) && hit.transform.gameObject.tag == "Enemy") 
		{
			float distance = Vector3.Distance(this.gameObject.transform.position, hit.transform.position);
			Debug.Log ("TEST");
			if(distance <= attackRange)
			{

				hit.transform.gameObject.GetComponent<Health> ().health -= damage;
			}
			else
				agent.SetDestination(hit.transform.position);
		}
	}

	public void RewardMoney(int value)
	{
		//adds the value passed to the function to the players total money
		playerMoney += value;
		//update players money in the ui
		uiController.uiHUD.GetComponent<HUD> ().money.text = playerMoney.ToString();
	}
}