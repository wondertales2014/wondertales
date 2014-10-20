/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Qualcomm Connected Experiences, Inc.
==============================================================================*/

using UnityEngine;

/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
/// </summary>
public class CustomTrackableEventHandler : MonoBehaviour,
ITrackableEventHandler
{
	#region PRIVATE_MEMBER_VARIABLES
	
	private TrackableBehaviour mTrackableBehaviour;
	public Canvas screenController;
	public Canvas loadingController;
	public Canvas pageController;

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
	
	#endregion // PRIVATE_METHODS
}
