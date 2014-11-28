using UnityEngine;
using System.Collections;

public class switchAI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider col)
	{
		if(col.name == "RedCube" && gameObject.name == "RedSwitch")
		{
			gameObject.renderer.enabled = false;
			GameObject.Find("LevelManager").SendMessage("setRed");
			GameObject.Find("Player").SendMessage("dropCrystal");
			gameObject.collider.enabled = false;
			GameObject.Find("Singleton").SendMessage("playLockSound");
		}
		if(col.name == "BlueCube" && gameObject.name == "BlueSwitch")
		{
			gameObject.renderer.enabled = false;
			GameObject.Find("LevelManager").SendMessage("setBlue");
			GameObject.Find("Player").SendMessage("dropCrystal");
			gameObject.collider.enabled = false;
			GameObject.Find("Singleton").SendMessage("playLockSound");
		}
		if(col.name == "YellowCube" && gameObject.name == "YellowSwitch")
		{
			gameObject.renderer.enabled = false;
			GameObject.Find("LevelManager").SendMessage("setYellow");
			GameObject.Find("Player").SendMessage("dropCrystal");
			gameObject.collider.enabled = false;
			GameObject.Find("Singleton").SendMessage("playLockSound");
		}
		if(col.name == "GreenCube" && gameObject.name == "GreenSwitch")
		{
			gameObject.renderer.enabled = false;
			GameObject.Find("LevelManager").SendMessage("setGreen");
			GameObject.Find("Player").SendMessage("dropCrystal");
			gameObject.collider.enabled = false;
			GameObject.Find("Singleton").SendMessage("playLockSound");
		}
	
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
