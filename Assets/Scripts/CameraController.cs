using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	private float moveSpeed = 30.0f;

	void Update()
	{
		if (Input.GetKey("a"))
			transform.Translate (Vector3.right * -moveSpeed * Time.deltaTime);
		
		if (Input.GetKey ("d"))
			transform.Translate (Vector3.right * moveSpeed * Time.deltaTime);
		
		if (Input.GetKey("s"))
			transform.Translate (transform.forward * -moveSpeed * Time.deltaTime);
		
		if (Input.GetKey("w"))
			transform.Translate (transform.forward * moveSpeed * Time.deltaTime);
	}

}
