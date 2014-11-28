using UnityEngine;
using System.Collections;

public class PopupWallAI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Activate()
	{
		gameObject.renderer.enabled = true;
		gameObject.collider.enabled = true;
	}
	void Deactivate()
	{
		gameObject.renderer.enabled = false;
		gameObject.collider.enabled = false;
	}
}
