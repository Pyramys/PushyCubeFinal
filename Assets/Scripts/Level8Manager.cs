using UnityEngine;
using System.Collections;

public class Level8Manager : MonoBehaviour {
	public bool red = false;
	public bool yellow = false;
	public bool blue = false;
	public bool ryb = false;
	
	// Use this for initialization
	void Start () {
		//GameObject.Find("Statue").SendMessage("Activate");
	}
	
	// Update is called once per frame
	void Update () {
		Ryb();
	}
	
	void RestartLevel()
	{
		Application.LoadLevel("LevelEight");	
	}
	
	void NextLevel()
	{
		
		
			Application.LoadLevel("LevelNine");	
		
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
}
