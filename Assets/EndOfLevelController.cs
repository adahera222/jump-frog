using UnityEngine;
using System.Collections;

public class EndOfLevelController : MonoBehaviour {
	public int level;

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
			Mixpanel.SendEvent("Completed level " + level);
		}
	}
}
