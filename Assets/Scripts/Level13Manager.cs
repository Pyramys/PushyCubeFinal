using UnityEngine;
using System.Collections;

public class Level13Manager : MonoBehaviour {
	public bool ryb = false;
	public bool red = false;
	
	// Use this for initialization
	void Start () {
		GameObject.Find("FireballSpawner1").SendMessage("Activate");
		GameObject.Find("FireballSpawner2").SendMessage("Activate");
		GameObject.Find("FireballSpawner3").SendMessage("Activate");
		GameObject.Find("FireballSpawner4").SendMessage("Activate");
		GameObject.Find("FireballSpawner5").SendMessage("Activate");
		GameObject.Find("FireballSpawner6").SendMessage("Activate");
		GameObject.Find("FireballSpawner7").SendMessage("Activate");
		GameObject.Find("FireballSpawner8").SendMessage("Activate");
		GameObject.Find("FireballSpawner9").SendMessage("Activate");
		GameObject.Find("FireballSpawner10").SendMessage("Activate");
		GameObject.Find("FireballSpawner11").SendMessage("Activate");
		GameObject.Find("FireballSpawner12").SendMessage("Activate");
		GameObject.Find("FireballSpawner13").SendMessage("Activate");
		GameObject.Find("FireballSpawner14").SendMessage("Activate");
		GameObject.Find("FireballSpawner15").SendMessage("Activate");
		GameObject.Find("FireballSpawner16").SendMessage("Activate");
		GameObject.Find("FireballSpawner17").SendMessage("Activate");
		GameObject.Find("FireballSpawner18").SendMessage("Activate");
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		Ryb();
	}
	
	void setRed()
	{
		red=true;
		
		
	}
	void RestartLevel()
	{
		Application.LoadLevel("LevelTen");	
	}
	
	void NextLevel()
	{
		
			Application.LoadLevel("LevelFourteen");	
		
	}
	void Ryb()
	{
		if(red)
		{
			NextLevel();
		}	
	}
}
