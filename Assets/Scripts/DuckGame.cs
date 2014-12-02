using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DuckGame : MonoBehaviour {
	
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
			
			Collider[] patoColliderComponents = pato.GetComponents<Collider>();
			// Disable colliders:
			foreach (Collider component in patoColliderComponents)
			{
				component.enabled = false;
			}

			if(texto.text.Equals("¿Quien es feo?")) {
				audioAnimal.Play();
				texto.text = "Muy bien! Nunca nos dejemos llevar por las apariencias. Veamos que sucede...";
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
