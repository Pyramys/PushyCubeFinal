using UnityEngine;
using System.Collections;

public class Level7Manager : MonoBehaviour {
	public bool red = false;
	public bool yellow = false;
	public bool blue = false;

	public bool ryb = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ryb();
	}
	
	void RestartLevel()
	{
		Application.LoadLevel("LevelSeven");	
	}
	
	void NextLevel()
	{
		 
			Application.LoadLevel("LevelEight");	
		
	}
	
	void setRed()
	{
		red=true;
		GameObject.Find("ArcaneSpawner1").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner2").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner3").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner4").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner5").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner6").SendMessage("Activate");
		GameObject.Find("LightningTrap1").SendMessage("Activate");
		GameObject.Find("LightningTrap2").SendMessage("Activate");
		
	}
	
	void setBlue()
	{
		blue=true;
		GameObject.Find("Zombie").SendMessage("Activate");
	}
	
	void setYellow()
	{
		yellow=true;	
	}
	void Ryb()
	{
		if( red && yellow && blue)
		{
			Application.LoadLevel("LevelEight");	
		}	
	}
}
