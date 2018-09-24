using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour {

	public GameController gameController;
	public GameObject uiGameOverMenu;
	public GameObject uiPauseMenu;
	public GameObject uiHUD;

	void Start()
	{
		Time.timeScale = 1.0f;
	}

	void Update()
	{
		//pauses the game if the pause button is pressed
		if (Input.GetKeyDown (KeyCode.Escape))
			Pause ();

		if (gameController.gameOver) 
			GameOver ();
	}

	void GameOver()
	{
		Time.timeScale = 0.0f;
		uiGameOverMenu.SetActive (true);
	}

	void Pause()
	{
		//pause time toggler thing
		if (Time.timeScale == 1.0f)
		{
			//stops run time
			Time.timeScale = 0.0f;
			//activates the pause menu in the ui
			uiPauseMenu.SetActive (true);
		} 
		else
		{
			Time.timeScale = 1.0f;
			uiPauseMenu.SetActive (false);
		}
	}
}
