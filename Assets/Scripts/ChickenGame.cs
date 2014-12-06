using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChickenGame : MonoBehaviour {
	
	public GameObject gato;
	public GameObject pato;
	public GameObject gallina;
	public Text texto;
	public AudioSource audioAnimal;
	public AudioSource audioError;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTouchDown(int valor) {
		if (valor == 1)	
		{

			if(texto.text.Equals("¿Quien pone huevos?")) {
				audioAnimal.Play();
				texto.text = "¿Quien es feo?";
			} else {
				audioError.Play();
			}
		}
		if (valor == 2)	
		{
			
		}
		if (valor == 3)
		{
			
		}
	}
	
}
