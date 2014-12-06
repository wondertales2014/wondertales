using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WolfGame : MonoBehaviour {
	
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

			if(texto.text.Equals("¿Quien es astuto y malvado?")) {
				audioAnimal.Play();
				texto.text = "Excelente! Has acertado todas las respuestas. Continua leyendo para conocer el final de esta maravillosa historia.";
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
