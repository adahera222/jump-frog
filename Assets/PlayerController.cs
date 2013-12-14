using UnityEngine;
using System.Collections;

public class PlayerController : JumpFrogBehavior {
	public float speed;
	
	// Update is called once per frame
	void Update () {
		float axisSpeed = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (0.0f, 0.0f, axisSpeed * speed);
		transform.Translate (movement * Time.deltaTime);
	}
}
