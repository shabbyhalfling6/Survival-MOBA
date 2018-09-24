using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
	public GameObject playerBase;
	public GameObject enemyBase;
	public GameObject player;

	public bool gameOver = false;
	public bool won = false;

	public GameObject[] creepWaves = new GameObject[6];

	void Start()
	{
		InvokeRepeating ("SpawnEnemies", 0.0f, 30.0f);
		Instantiate (player);
	}

	void Update()
	{
		if (playerBase.GetComponent<Base> ().health <= 0) {
			gameOver = true;
			won = true;
		} else if (enemyBase.GetComponent<Base> ().health <= 0)
			gameOver = true;
	}

	void SpawnEnemies()
	{
		for (int index = 0; index < creepWaves.Length; index++)
		{
			Instantiate(creepWaves[index]);
		}
	}


}
