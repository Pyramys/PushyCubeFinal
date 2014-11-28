using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public bool red = false;
	public bool yellow = false;
	public bool blue = false;
	public bool ryb = false;
	
	public string tapToMove = "Tap to Move";
	public string tapPlayer = "Tap player to drop crystal";
	public string placeCrystals = "Move crystals to their position to advance";
	public string avoidTraps = "Avoid everything!";
	public string musicVolume = "Change Volume with this slider";

	
	
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ryb ();
	}
	
	void RestartLevel()
	{
		Application.LoadLevel("IntroLevel");	
	}
	
	void NextLevel()
	{
		
		Application.LoadLevel("LevelOne");
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
	
	void Ryb()
	{
		if( red && yellow && blue)
		{
			NextLevel();
		}	
	}
	
	void OnGUI()
	{
		GUI.TextField(new Rect(0, 300, 200, 40), musicVolume);
		GUI.TextField(new Rect(0, 350, 140, 40), tapToMove);
		GUI.TextField(new Rect(0, 400, 180, 40), tapPlayer); 	
		GUI.TextField(new Rect(0, 450, 250, 40), placeCrystals); 	
		GUI.TextField(new Rect(0, 500, 140, 40), avoidTraps); 

	}
}
