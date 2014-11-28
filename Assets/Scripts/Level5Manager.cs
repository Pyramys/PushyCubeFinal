using UnityEngine;
using System.Collections;

public class Level5Manager : MonoBehaviour {
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
		GameObject.Find("LightningTrap7").SendMessage("Activate");
		GameObject.Find("LightningTrap8").SendMessage("Activate");
		GameObject.Find("LightningTrap9").SendMessage("Activate");
		GameObject.Find("LightningTrap10").SendMessage("Activate");
		GameObject.Find("LightningTrap11").SendMessage("Activate");
		GameObject.Find("LightningTrap12").SendMessage("Activate");
		GameObject.Find("LightningTrap13").SendMessage("Activate");
		GameObject.Find("LightningTrap14").SendMessage("Activate");
		GameObject.Find("LightningTrap15").SendMessage("Activate");
		GameObject.Find("LightningTrap16").SendMessage("Activate");
		GameObject.Find("LightningTrap17").SendMessage("Activate");
		GameObject.Find("LightningTrap18").SendMessage("Activate");
		
	}
	
	// Update is called once per frame
	void Update () {
		Ryb();
	}
	
	void RestartLevel()
	{
		Application.LoadLevel("LevelFive");	
	}
	
	void NextLevel()
	{
		
		Application.LoadLevel("LevelSix");	
		
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
		if( red && yellow && blue && green)
		{
			NextLevel();
		}	
	}
}
