﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AbuelitaGame : MonoBehaviour {
	
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

			Collider[] gallinaColliderComponents = gallina.GetComponents<Collider>();
			// Disable colliders:
			foreach (Collider component in gallinaColliderComponents)
			{
				component.enabled = false;
			}

			Collider[] patoColliderComponents = pato.GetComponents<Collider>();
			// Disable colliders:
			foreach (Collider component in patoColliderComponents)
			{
				component.enabled = true;
			}
			if(texto.text.Equals("¿Quien regalo una caperusa roja a su nieta?")) {
				audioAnimal.Play();
				texto.text = "¿Quien es astuto y malvado?";
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
