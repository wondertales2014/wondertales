/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Qualcomm Connected Experiences, Inc.
==============================================================================*/

using UnityEngine;

/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
/// </summary>
public class TCP6TrackableEventHandler : MonoBehaviour,
ITrackableEventHandler
{
	#region PRIVATE_MEMBER_VARIABLES
	
	private TrackableBehaviour mTrackableBehaviour;
	
	#endregion // PRIVATE_MEMBER_VARIABLES
	
	public Canvas screenController;
	public AudioSource aullido;
	public Animator loboAnim;
	
	#region UNTIY_MONOBEHAVIOUR_METHODS
	
	void Start()
	{
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
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
		this.screenController.enabled = false;
		
		Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
		Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);
		Terrain[]  terrainComponents  = GetComponentsInChildren<Terrain>(true);
		//		Canvas[]   canvasComponents   = GetComponentsInChildren<Canvas>(true);
		
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
		
		// Enable Canvas:
		//		foreach (Canvas canvas in canvasComponents)
		//		{
		//			canvas.enabled = true;
		//		}
		
		//Enable Halos
		//GameObject.Find ("HaloLight_PF_07_01").SetActive(true);
		//GameObject.Find ("HaloLight_PF_05_01").SetActive(true);
		//GameObject.Find ("HaloLight_PF_05_02").SetActive(true);
		//GameObject.Find ("HaloLight_PF_05_03").SetActive(true);
		//GameObject.Find ("HaloLight_PF_05_04").SetActive(true);
		//GameObject.Find ("HaloLight_PF_03_01").SetActive(true);
		
		Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
	}
	
	
	private void OnTrackingLost()
	{
		this.screenController.enabled = true;
		if (aullido.isPlaying) {
			aullido.Stop ();
		}

		loboAnim.SetBool("aullar",false);

		Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
		Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);
		Terrain[]  terrainComponents  = GetComponentsInChildren<Terrain>(true);
		Canvas[]   CanvasComponents   = GetComponentsInChildren<Canvas>(true);
		
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
		
		// Disable Canvas:
		foreach (Canvas canvas in CanvasComponents)
		{
			canvas.enabled = false;
		}
		
		//Disable Halos
		//GameObject.Find ("HaloLight_PF_07_01").SetActive(false);
		//GameObject.Find ("HaloLight_PF_05_01").SetActive(false);
		//GameObject.Find ("HaloLight_PF_05_02").SetActive(false);
		//GameObject.Find ("HaloLight_PF_05_03").SetActive(false);
		//GameObject.Find ("HaloLight_PF_05_04").SetActive(false);
		//GameObject.Find ("HaloLight_PF_03_01").SetActive(false);
		
		Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
	}
	
	#endregion // PRIVATE_METHODS
}
