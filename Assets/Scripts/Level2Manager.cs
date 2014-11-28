using UnityEngine;
using System.Collections;

public class Level2Manager : MonoBehaviour {
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
		Application.LoadLevel("LevelTwo");	
	}
	
	void NextLevel()
	{
		
			Application.LoadLevel("LevelThree");	
		
	}
	
	void setRed()
	{
		red=true;
		GameObject.Find("BlueSwitch").SendMessage("Activate");
		GameObject.Find("YellowSwitch").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner1").SendMessage("spawnArcaneBlast");
		GameObject.Find("ArcaneSpawner2").SendMessage("spawnArcaneBlast");
		GameObject.Find("ArcaneSpawner3").SendMessage("spawnArcaneBlast");
		GameObject.Find("ArcaneSpawner4").SendMessage("spawnArcaneBlast");
		GameObject.Find("ArcaneSpawner5").SendMessage("spawnArcaneBlast");
		
	}
	
	void setBlue()
	{
		blue=true;	
	}
	
	void setYellow()
	{
		yellow=true;	
	}
	void Ryb()
	{
		if( red && yellow && blue)
		{
			NextLevel();
		}	
	}
}
