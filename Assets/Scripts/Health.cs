using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public int health = 0;

	public GameController gameController;
	public UIController uiController;

	public void TakeDamage(int damage)
	{
		//take damage away from health
		health -= damage;

		if(this.gameObject.tag == "Player")
			uiController.uiHUD.GetComponent<HUD>().HealthSlider (health);
	}
}
