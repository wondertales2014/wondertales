using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CatGame : MonoBehaviour {

	public GameObject gato;
	public GameObject pato;
	public GameObject gallina;
	public Text texto;
	public AudioSource audioAnimal;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTouchDown(int valor) {
		if (valor == 1)	
		{
			Collider[] gatoColliderComponents = gato.GetComponentsInChildren<Collider>(true);

			// Disable colliders:
			foreach (Collider component in gatoColliderComponents)
			{
				component.enabled = false;
			}

			Collider[] gallinaColliderComponents = gallina.GetComponentsInChildren<Collider>(true);
			// Disable colliders:
			foreach (Collider component in gallinaColliderComponents)
			{
				component.enabled = true;
			}

			audioAnimal.Play();
			texto.text = "¿Quien pone huevos?";
		}
		if (valor == 2)	
		{

		}
		if (valor == 3)
		{
			
		}
	}

}
