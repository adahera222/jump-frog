using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CarController : JumpFrogBehavior {
	public float speed;
	public int level;

	void Update () {
		Vector3 movement = new Vector3 (speed, 0.0f, 0.0f);

		transform.Translate (movement * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			Mixpanel.SendEvent("Got hit by a car", new Dictionary<string, object> {
				{ "Level", level }
			});
			game.GameOver();
		}
	}
}
