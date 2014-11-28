using UnityEngine;
using System.Collections;

public class RainbowCubeAI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider col)
	{
		if(col.name == "RainbowSwitch" && gameObject.name == "RainbowCube")
		{
			gameObject.rigidbody.isKinematic = true;	
		}
		
	}
}
