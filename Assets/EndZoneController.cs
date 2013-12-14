using UnityEngine;
using System.Collections;

public class EndZoneController : MonoBehaviour {
	public GameObject respawnPoint;

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Car")) {
			other.transform.position = respawnPoint.transform.position;
		}
	}
}
