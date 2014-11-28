using UnityEngine;
using System.Collections;

public class Level9Manager : MonoBehaviour {
	public bool red = false;
	public bool yellow = false;
	public bool blue = false;
	public bool green = false;
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
		Application.LoadLevel("LevelNine");	
	}
	
	void NextLevel()
	{
		
		
			Application.LoadLevel("LevelTen");	
		
	}
	void setRed()
	{
		red=true;
		GameObject.Find("Zombie").SendMessage("Activate");
		
	}
	
	void setBlue()
	{
		blue=true;
		GameObject.Find("LightningTrap1").SendMessage("Activate");
		GameObject.Find("LightningTrap2").SendMessage("Activate");
		GameObject.Find("LightningTrap3").SendMessage("Activate");
		GameObject.Find("LightningTrap4").SendMessage("Activate");
		
	}
	
	void setYellow()
	{
		yellow=true;	
		GameObject.Find("FireballSpawner1").SendMessage("Activate");
		GameObject.Find("FireballSpawner2").SendMessage("Activate");
		GameObject.Find("FireballSpawner3").SendMessage("Activate");
		GameObject.Find("FireballSpawner4").SendMessage("Activate");
		GameObject.Find("FireballSpawner5").SendMessage("Activate");
		GameObject.Find("FireballSpawner6").SendMessage("Activate");
		GameObject.Find("FireballSpawner7").SendMessage("Activate");
		GameObject.Find("FireballSpawner8").SendMessage("Activate");
		GameObject.Find("FireballSpawner9").SendMessage("Activate");
		
		
		
	}
	
	void setGreen()
	{
		green=true;
		GameObject.Find("ArcaneSpawner1").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner2").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner3").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner4").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner5").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner6").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner7").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner8").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner9").SendMessage("Activate");
	}
	void Ryb()
	{
		if( red && yellow && blue && green)
		{
			NextLevel();
		}	
	}
}
