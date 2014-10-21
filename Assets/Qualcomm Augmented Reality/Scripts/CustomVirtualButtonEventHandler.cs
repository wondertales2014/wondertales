using UnityEngine;
using System.Collections;

public class CustomVirtualButtonEventHandler : MonoBehaviour , 
IVirtualButtonEventHandler {
	
	public GameObject smoke;
	
	void Start()
	{
		
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < vbs.Length; ++i)
		{
			vbs[i].RegisterEventHandler(this);
		}

	}
	
	
	void Update () {
		
	}

	public void OnButtonPressed( VirtualButtonAbstractBehaviour vb ){
		
		Debug.Log( vb.name +" Pressed" );
		
		smoke.SetActive (true);
	}
	
	public void OnButtonReleased( VirtualButtonAbstractBehaviour vb ){
		
		Debug.Log( vb.name +" Released" );
		
	}
}