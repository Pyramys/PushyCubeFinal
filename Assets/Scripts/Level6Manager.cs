using UnityEngine;
using System.Collections;

public class Level6Manager : MonoBehaviour {
	public bool red = false;
	public bool yellow = false;
	public bool blue = false;
	public bool green = false;
	public bool ryb = false;
	
	// Use this for initialization
	void Start () {
		GameObject.Find("LightningTrap1").SendMessage("Activate");
		GameObject.Find("LightningTrap2").SendMessage("Activate");
		GameObject.Find("LightningTrap3").SendMessage("Activate");
		GameObject.Find("LightningTrap4").SendMessage("Activate");
		GameObject.Find("LightningTrap5").SendMessage("Activate");
		GameObject.Find("LightningTrap6").SendMessage("Activate");
		GameObject.Find("PermanentLightningTrap1").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner1").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner2").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner3").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner4").SendMessage("Activate");
		
	}
	
	// Update is called once per frame
	void Update () {
		Ryb();
	}
	void RestartLevel()
	{
		Application.LoadLevel("LevelSix");	
	}
	
	void NextLevel()
	{
		
		
			Application.LoadLevel("LevelSeven");	
		
	}
	
	void setRed()
	{
		red=true;
		
	}
	
	void setBlue()
	{
		blue=true;
		
	}
	
	void setYellow()
	{
		yellow=true;	
	}
	
	void setGreen()
	{
		green=true;	
	}
	void Ryb()
	{
		if(red && green)
		{
			GameObject.Find("PermanentLightningTrap1").SendMessage("Deactivate");	
		}
		if( red && yellow && blue && green)
		{
			NextLevel();
		}	
	}
}
