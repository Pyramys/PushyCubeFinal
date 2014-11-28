using UnityEngine;
using System.Collections;

public class Level14Manager : MonoBehaviour {
	public bool rainbow=false;
	public bool ryb = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ryb();
	}
	
	void setRainbow()
	{
		GameObject.Find("Plane").SendMessage("Activate");
	}
	
	void RestartLevel()
	{
		Application.LoadLevel("LevelTen");	
	}
	
	void NextLevel()
	{
		Application.LoadLevel("Ending");
	}
	void Ryb()
	{
		if(rainbow)
		{
			NextLevel();
		}	
	}
}
