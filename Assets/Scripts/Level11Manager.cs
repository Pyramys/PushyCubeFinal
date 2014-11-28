using UnityEngine;
using System.Collections;

public class Level11Manager : MonoBehaviour {
	public bool ryb = false;
	public bool blue = false;
	
	// Use this for initialization
	void Start () {
		GameObject.Find("ArcaneSpawner1").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner5").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner3").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner4").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner5").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner6").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner7").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner8").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner9").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner10").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner11").SendMessage("Activate");
		GameObject.Find("ArcaneSpawner12").SendMessage("Activate");
		
	}
	
	// Update is called once per frame
	void Update () {
		Ryb();
	}
	
	void setBlue()
	{
		blue=true;
		
		
	}
	void RestartLevel()
	{
		Application.LoadLevel("LevelTen");	
	}
	
	void NextLevel()
	{
		
			Application.LoadLevel("LevelTwelve");	
		
	}
	void Ryb()
	{
		if(blue)
		{
			NextLevel();
		}	
	}
}
