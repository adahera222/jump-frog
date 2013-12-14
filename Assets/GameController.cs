using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public bool PlayerHasPreviouslyDied() {
		return false;
		return PlayerPrefs.HasKey ("PlayerHasPreviouslyDied");
	}

	public void Start() {
		SetupMixpanel ();

		if (PlayerHasPreviouslyDied ()) {
			Mixpanel.SendEvent("Tried to restart");
			GameOver ();
			return;
		}

		Mixpanel.SendEvent("Started game");
	}

	public void SetupMixpanel() {
		Mixpanel.Token = "f792f223b1632465191da18a668c2ea3";

		Mixpanel.SuperProperties.Add("Platform", Application.platform.ToString());
		Mixpanel.SuperProperties.Add("Quality", QualitySettings.names[QualitySettings.GetQualityLevel()]);
		Mixpanel.SuperProperties.Add("Fullscreen", Screen.fullScreen);
		Mixpanel.SuperProperties.Add("Screen Height", Screen.height);
		Mixpanel.SuperProperties.Add("Screen Width", Screen.width);
		Mixpanel.SuperProperties.Add("Resolution", Screen.width + "x" + Screen.height);

		Mixpanel.SendEvent("Ran program");
	}
	
	public void GameOver() {
		PlayerPrefs.SetInt("PlayerHasPreviouslyDied", 1);
		PlayerPrefs.Save ();

		Application.LoadLevel (1);
	}

	public void Winner() {
		Mixpanel.SendEvent("Did the smart thing");
		Application.LoadLevel (2);
	}
}
