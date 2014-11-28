using UnityEngine;
using System.Collections;

public class Level3Manager : MonoBehaviour {
	public bool red = false;
	public bool yellow = false;
	public bool blue = false;
	public bool green = false;
	public bool ryb = false;
	public bool wall1Up =false;
	public bool wall2Up = false;
	
	
	
	// Use this for initialization
	void Start () {
		GameObject.Find("LightningTrap1").SendMessage("Activate");
		GameObject.Find("LightningTrap2").SendMessage("Activate");
		GameObject.Find("LightningTrap3").SendMessage("Activate");
		GameObject.Find("LightningTrap4").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner1").SendMessage("spawnArcaneBlast");
		GameObject.Find("ArcaneSpawner2").SendMessage("spawnArcaneBlast");
		GameObject.Find("ArcaneSpawner3").SendMessage("spawnArcaneBlast");
		GameObject.Find("ArcaneSpawner4").SendMessage("spawnArcaneBlast");
		GameObject.Find("ArcaneSpawner5").SendMessage("spawnArcaneBlast");
	}
	
	// Update is called once per frame
	void Update () {
		Ryb();
	}
	
	void RestartLevel()
	{
		Application.LoadLevel("LevelThree");	
	}
	
	void NextLevel()
	{
		
			Application.LoadLevel("LevelFour");	
		
	}
	
	void setRed()
	{
		red=true;
		if(wall1Up)
		{
			GameObject.Find("PopupWall1").SendMessage("Deactivate");
			wall1Up=false;
		}
		else if(!wall1Up)
		{
			GameObject.Find("PopupWall1").SendMessage("Activate");
			wall1Up=true;
		}

		
		
	}
	
	void setBlue()
	{
		blue=true;
		if(wall1Up)
		{
			GameObject.Find("PopupWall1").SendMessage("Deactivate");
			wall1Up=false;
		}
		else if(!wall1Up)
		{
			GameObject.Find("PopupWall1").SendMessage("Activate");
			wall1Up = true;
		}
		
	}
	
	void setYellow()
	{
		yellow=true;
		if(wall1Up)
		{
			GameObject.Find("PopupWall1").SendMessage("Deactivate");
			wall1Up=false;
		}
		else if(!wall1Up)
		{
			GameObject.Find("PopupWall1").SendMessage("Activate");
			wall1Up=true;
		}
	}
	
	void setGreen()
	{
		green=true;	
		if(wall1Up)
		{
			GameObject.Find("PopupWall1").SendMessage("Deactivate");
			wall1Up=false;
		}
		else if(!wall1Up)
		{
			GameObject.Find("PopupWall1").SendMessage("Activate");
			wall1Up=true;
		}
	}
	
	void Ryb()
	{
		if( red && yellow && blue && green)
		{
			NextLevel();
		}	
	}
}
