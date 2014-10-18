using UnityEngine;
using System.Collections;

public class LoadAtStart : MonoBehaviour {

	public string sceneName;
	// Use this for initialization
	void Start () {
		Application.LoadLevel (sceneName);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
