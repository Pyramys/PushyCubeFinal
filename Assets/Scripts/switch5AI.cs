using UnityEngine;
using System.Collections;

public class switch5AI : MonoBehaviour {

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
			GameObject.Find("Wall2").SendMessage("Switch");
			GameObject.Find("Wall3").SendMessage("Switch");
			GameObject.Find("LevelManager").SendMessage("setRed");
		}
		if(col.name == "BlueCube" && gameObject.name == "BlueSwitch")
		{
			GameObject.Find("Wall1").SendMessage("Switch");
			GameObject.Find("Wall3").SendMessage("Switch");
			GameObject.Find("LevelManager").SendMessage("setBlue");
		}
		if(col.name == "YellowCube" && gameObject.name == "YellowSwitch")
		{
			
			GameObject.Find("Wall2").SendMessage("Switch");
			GameObject.Find("LevelManager").SendMessage("setYellow");
		}
		if(col.name == "GreenCube" && gameObject.name == "GreenSwitch")
		{
			
			GameObject.Find("LevelManager").SendMessage("setGreen");
		}
	}
	
	void Activate()
	{
		gameObject.renderer.enabled = true;
		gameObject.collider.enabled = true;
	}
}

