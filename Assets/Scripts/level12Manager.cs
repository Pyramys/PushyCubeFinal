using UnityEngine;
using System.Collections;

public class level12Manager : MonoBehaviour {
	public bool ryb = false;
	public bool yellow = false;
	
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
		
		
	}
	
	// Update is called once per frame
	void Update () {
		Ryb();
	}
	
	void setYellow()
	{
		yellow=true;
		
		
	}
	void RestartLevel()
	{
		Application.LoadLevel("LevelTen");	
	}
	
	void NextLevel()
	{
		
			Application.LoadLevel("LevelThirteen");	
		
	}
	void Ryb()
	{
		if( yellow)
		{
			NextLevel();
		}	
	}
}
