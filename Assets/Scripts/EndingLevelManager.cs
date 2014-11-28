using UnityEngine;
using System.Collections;

public class EndingLevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void RestartLevel()
	{
		Application.LoadLevel("LevelTen");	
	}
	
	void NextLevel()
	{
		
			Application.LoadLevel("TitleScreen");	
		
	}
}
