using UnityEngine;
using System.Collections;

public class LevelTenRedCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider col)
	{
		if(col.name == "RedSwitch" && gameObject.name == "RedCube")
		{
			gameObject.rigidbody.isKinematic = true;	
		}
		if(col.name == "BlueSwitch" && gameObject.name == "BlueCube")
		{
			gameObject.rigidbody.isKinematic = true;	
		}
		if(col.name == "YellowSwitch" && gameObject.name == "YellowCube")
		{
			gameObject.rigidbody.isKinematic = true;	
		}
		if(col.name == "GreenSwitch" && gameObject.name == "GreenCube")
		{
			gameObject.rigidbody.isKinematic = true;	
		}
	}
	
	void Activate()
	{
		gameObject.renderer.enabled=true;
		gameObject.collider.enabled=true;
		gameObject.rigidbody.useGravity=true;
	}
	
	void Deactivate()
	{
		gameObject.renderer.enabled=false;
		gameObject.collider.enabled=false;
		gameObject.rigidbody.useGravity=false;
	}
}
