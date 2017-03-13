using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideControllers : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("SteamVR_RenderModel") != null) {
			if (GameObject.Find ("SteamVR_RenderModel").activeSelf) {
				GameObject.Find ("SteamVR_RenderModel").SetActive (false);
			}
		}
	}
}
