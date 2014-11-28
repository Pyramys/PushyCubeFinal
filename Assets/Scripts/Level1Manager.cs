using UnityEngine;
using System.Collections;

public class Level1Manager : MonoBehaviour {
	public bool red = false;
	public bool yellow = false;
	public bool blue = false;
	public bool ryb = false;
	public float textTop;
	public float textLeft;
	public float textWidth=240;
	public float textHeight;

	
	public string watchTime = "Watch the Timer in the top right corner!";
	
	
	
	// Use this for initialization
	void Start () {
		GameObject.Find("ArcaneSpawner1").SendMessage("spawnArcaneBlast");
		GameObject.Find("ArcaneSpawner2").SendMessage("spawnArcaneBlast");
		GameObject.Find("ArcaneSpawner3").SendMessage("spawnArcaneBlast");
		GameObject.Find("ArcaneSpawner4").SendMessage("spawnArcaneBlast");
		GameObject.Find("ArcaneSpawner5").SendMessage("spawnArcaneBlast");
		GameObject.Find("Singleton").SendMessage("startTimer");
	}
	
	// Update is called once per frame
	void Update () {
		Ryb();

	}
	
	void RestartLevel()
	{
		Application.LoadLevel("LevelOne");	
	}
	
	void NextLevel()
	{
		
			Application.LoadLevel("LevelTwo");	
		
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

		GUI.TextField(new Rect(Screen.width-textWidth,50,textWidth,25), watchTime);
	}

}
