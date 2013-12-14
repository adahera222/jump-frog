using UnityEngine;
using System.Collections;

public class JumpFrogBehavior : MonoBehaviour {
	protected GameController game;

	// Use this for initialization
	void Start () {
		game = GameObject.FindWithTag("GameController").GetComponent<GameController>();
	}
}
