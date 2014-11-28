using UnityEngine;
using System.Collections;

public class WallAI : MonoBehaviour {
	public bool state=true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Switch()
	{
		state = !state;
		if(state)
		{
			gameObject.collider.enabled=true;
			gameObject.renderer.enabled=true;
		}
		else
		{
			gameObject.collider.enabled=false;
			gameObject.renderer.enabled=false;
		}
	}
}
