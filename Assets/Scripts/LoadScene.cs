using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	public void load(string sceneName) {
		Application.LoadLevel (sceneName);
	}

	public void load(int sceneNumber) {
		Application.LoadLevel (sceneNumber);
	}

	public void close() {
		Application.Quit ();
	}
}
