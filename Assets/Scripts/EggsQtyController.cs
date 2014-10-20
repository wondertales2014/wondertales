using UnityEngine;
using System.Collections;

public class EggsQtyController : MonoBehaviour {

	private int eggQty;
	public GUIText gameMessage;
	// Use this for initialization
	void Start () {
		this.eggQty = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addCrackedEgg(){
		this.eggQty++;
	}

	public bool checkCrackedEgg(){
		if (this.eggQty < 6) {
			gameMessage.text = "Primero debes romper los huevos blancos!";
			return false;
		} else {
			return true;
		}
	}
}
