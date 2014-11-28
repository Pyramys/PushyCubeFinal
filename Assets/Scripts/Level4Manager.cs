using UnityEngine;
using System.Collections;

public class Level4Manager : MonoBehaviour {
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
		Application.LoadLevel("LevelFour");	
	}
	
	void NextLevel()
	{
		
			Application.LoadLevel("LevelFive");	
		
	}
	
	void setRed()
	{
		red=true;
		GameObject.Find("BlueSwitch").SendMessage("Activate");
		GameObject.Find("YellowSwitch").SendMessage("Activate");
		GameObject.Find("LightningTrap1").SendMessage("Activate");
		GameObject.Find("LightningTrap2").SendMessage("Activate");
		GameObject.Find("LightningTrap3").SendMessage("Activate");
		GameObject.Find("LightningTrap4").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner1").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner2").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner3").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner4").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner5").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner6").SendMessage("Activate");
		GameObject.Find("BlueCube").SendMessage("Activate");
		GameObject.Find("YellowCube").SendMessage("Activate");
	}
	
	void setBlue()
	{
		blue=true;
		GameObject.Find("PopDownWall").SendMessage("Activate");
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
