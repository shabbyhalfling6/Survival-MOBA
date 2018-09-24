using UnityEngine;
using System.Collections;

public class Tower : Health {

	private int towerHealth = 2500;

	void Start()
	{
		health = towerHealth;
	}
}
