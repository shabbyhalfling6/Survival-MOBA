using UnityEngine;
using System.Collections;

public class Base : Health {

	public int baseHealth = 5000;

	void Start()
	{
		health = baseHealth;
	}


}
