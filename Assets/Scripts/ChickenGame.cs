using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChickenGame : MonoBehaviour {
	
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

			Collider[] gallinaColliderComponents = gallina.GetComponentsInChildren<Collider>(true);
			// Disable colliders:
			foreach (Collider component in gallinaColliderComponents)
			{
				component.enabled = false;
			}

			Collider[] patoColliderComponents = pato.GetComponentsInChildren<Collider>(true);
			// Disable colliders:
			foreach (Collider component in patoColliderComponents)
			{
				component.enabled = true;
			}

			audioAnimal.Play();
			texto.text = "¿Quien es feo?";
		}
		if (valor == 2)	
		{
			
		}
		if (valor == 3)
		{
			
		}
	}
	
}
