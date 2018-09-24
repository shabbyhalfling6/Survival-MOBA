using UnityEngine;
using System.Collections;

public class MenuNavigations : MonoBehaviour {


	public void OnClickPlay()
	{
		Application.LoadLevel ("Survival MOBA");
	}

	public void OnClickMainMenu()
	{
		Application.LoadLevel ("Main Menu");
	}

	public void OnClickExit()
	{
		Application.Quit ();
	}

}
