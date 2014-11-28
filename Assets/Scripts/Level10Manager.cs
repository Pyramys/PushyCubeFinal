using UnityEngine;
using System.Collections;

public class Level10Manager : MonoBehaviour {
	public bool green = false;
	public bool ryb = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Ryb();
	}
	
	void setGreen()
	{
		green=true;
		
		
	}
	void RestartLevel()
	{
		Application.LoadLevel("LevelTen");	
	}
	
	void NextLevel()
	{
		
			Application.LoadLevel("LevelEleven");	
		
	}
	void Ryb()
	{
		if( green)
		{
			NextLevel();
		}	
	}
}
