using UnityEngine;
using System.Collections;

public class HideEgg : MonoBehaviour {

	void Start() {
	}

	void OnTouchDown() {
		//mat.color = selectedColour;
		Animator.Play ("Blackout");
	}

	void OnTouchUp() {
		//mat.color = defaultColour;
	}

	void OnTouchStay() {
		//mat.color = selectedColour;
	}

	void OnTouchExit() {
		//mat.color = defaultColour;
	}

}
