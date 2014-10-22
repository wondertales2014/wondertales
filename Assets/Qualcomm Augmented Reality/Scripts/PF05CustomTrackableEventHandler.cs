using UnityEngine;
using System.Collections;

public class PF05CustomTrackableEventHandler : MonoBehaviour,
ITrackableEventHandler, IVirtualButtonEventHandler
{
	#region PRIVATE_MEMBER_VARIABLES
	
	private TrackableBehaviour mTrackableBehaviour;
	public Canvas screenController;
	public Canvas loadingController;
	public Canvas pageController;
	public AudioSource audioPato;
	public GameObject grass1;
	public GameObject grass2;
	public GameObject grass3;
	public GameObject grass4;
	public GameObject esfera1;
	public GameObject esfera2;
	public GameObject esfera3;
	public GameObject esfera4;
	public GameObject pato;
	
	#endregion // PRIVATE_MEMBER_VARIABLES
	
	
	#region UNTIY_MONOBEHAVIOUR_METHODS
	
	void Start()
	{
		//	this.screenController = GameObject.Find ("ScreenController");
		//	this.loadingController = GameObject.Find ("LoadingController");
		
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
		
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		foreach (VirtualButtonBehaviour vbb in vbs)
		{
			vbb.RegisterEventHandler(this);
		}
	}
	
	#endregion // UNTIY_MONOBEHAVIOUR_METHODS
	
	
	
	#region PUBLIC_METHODS
	
	/// <summary>
	/// Implementation of the ITrackableEventHandler function called when the
	/// tracking state changes.
	/// </summary>
	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
		    newStatus == TrackableBehaviour.Status.TRACKED ||
		    newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			OnTrackingFound();
		}
		else
		{
			OnTrackingLost();
		}
	}
	
	#endregion // PUBLIC_METHODS
	
	
	
	#region PRIVATE_METHODS
	
	
	private void OnTrackingFound()
	{
		//Target
		this.screenController.enabled = false;
		this.loadingController.enabled = true;
		this.pageController.enabled = true;
		
		Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
		Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);
		Terrain[]  terrainComponents = GetComponentsInChildren<Terrain>(true);
		
		
		// Enable rendering:
		foreach (Renderer component in rendererComponents)
		{
			component.enabled = true;
		}
		
		// Enable colliders:
		foreach (Collider component in colliderComponents)
		{
			component.enabled = true;
		}
		
		// Enable terrain:
		foreach (Terrain terrain in terrainComponents)
		{
			terrain.enabled = true;
		}
		
		this.loadingController.enabled = false;
		
		Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
	}
	
	
	private void OnTrackingLost()
	{
		//Target
		this.screenController.enabled = true;
		this.loadingController.enabled = false;
		this.pageController.enabled = false;
		pato.SetActive (false);
		
		Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
		Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);
		Terrain[]  terrainComponents = GetComponentsInChildren<Terrain>(true);
		
		// Disable rendering:
		foreach (Renderer component in rendererComponents)
		{
			component.enabled = false;
		}
		
		// Disable colliders:
		foreach (Collider component in colliderComponents)
		{
			component.enabled = false;
		}
		
		// Disable terrain:
		foreach (Terrain terrain in terrainComponents)
		{
			terrain.enabled = false;
		}
		
		
		
		Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
	}
	
	public void OnButtonPressed( VirtualButtonAbstractBehaviour vb ){
		
		if(string.Compare(vb.name,"Grass1")==1) {
			grass1.SetActive(false);
			esfera1.SetActive(false);
		}
		if(string.Compare(vb.name,"Grass2")==1) {
			grass2.SetActive(false);
			esfera2.SetActive(false);
		}
		if(string.Compare(vb.name,"Grass3")==1) {
			grass3.SetActive(false);
			esfera3.SetActive(false);
		}
		if(string.Compare(vb.name,"Grass4")==1) {
			grass4.SetActive(false);
			esfera4.SetActive(false);
			pato.SetActive(true);
			audioPato.Play();
		}
	}
	
	public void OnButtonReleased( VirtualButtonAbstractBehaviour vb ){
		
		Debug.Log( vb.name +" Released" );
		
	}
	
	#endregion // PRIVATE_METHODS
}
