using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CaperucitaGame : MonoBehaviour {

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
			Collider[] gatoColliderComponents = gato.GetComponents<Collider>();

			// Disable colliders:
			foreach (Collider component in gatoColliderComponents)
			{
				component.enabled = false;
			}

			Collider[] gallinaColliderComponents = gallina.GetComponents<Collider>();
			// Disable colliders:
			foreach (Collider component in gallinaColliderComponents)
			{
				component.enabled = true;
			}

			if(texto.text.Equals("¿Quién lleva pasteles y zumo de manzana a su abuelita?")) {
			audioAnimal.Play();
			texto.text = "¿Quien regalo una caperusa roja a su nieta?";
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
