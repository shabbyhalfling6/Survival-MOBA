using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUD : MonoBehaviour {

	public Slider healthSlider;
	public Text money;

	void Start()
	{
		healthSlider = GetComponentInChildren<Slider> ();
		money = GetComponentInChildren<Text> ();
	}

	public void HealthSlider(int health)
	{
		healthSlider.value = health;
	}
}
