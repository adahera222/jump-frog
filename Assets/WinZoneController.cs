using UnityEngine;
using System.Collections;

public class WinZoneController : JumpFrogBehavior {
	void OnTriggerEnter(Collider other) {
		game.Winner ();
	}
}
