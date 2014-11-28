using UnityEngine;
using System.Collections;

public class switchAI : MonoBehaviour {
	
	public string colorName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	

	
	void OnCollisionEnter(Collision col)
	{
		
	}
	
	void Activate()
	{
		gameObject.renderer.enabled = true;
		gameObject.collider.enabled = true;
	}
}
