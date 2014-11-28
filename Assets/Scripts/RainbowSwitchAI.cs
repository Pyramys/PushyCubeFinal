using UnityEngine;
using System.Collections;

public class RainbowSwitchAI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider col)
	{
		if(col.name == "RainbowCube" && gameObject.name == "RainbowSwitch")
		{
			gameObject.renderer.enabled = false;
			GameObject.Find("LevelManager").SendMessage("setRainbow");
		}
		
	}
	
	void Activate()
	{
		gameObject.renderer.enabled = true;
		gameObject.collider.enabled = true;
	}
}
