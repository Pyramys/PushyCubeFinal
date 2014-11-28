using UnityEngine;
using System.Collections;

public class EndingThanks : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find("Singleton").SendMessage("setLastLevel");
		GameObject.Find("Singleton").SendMessage("stopTimer");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUI.TextField(new Rect(0,0,500,50), "Special Thanks to My wife and daughter for helping me finish my first game!");
		GUI.TextField(new Rect(0,50,500,50), "Thanks to PushyPixels for helping me get started with Unity.");
		GUI.TextField(new Rect(0,100,500,50), "Thanks to Unluck Software for the models. ");
		GUI.TextField(new Rect(0,150,500,50), "Thanks to the SGDA gang and Servus for testing my game.");
		GUI.TextField(new Rect(0,200,500,50), "Thanks to Ikonradx for the Heart Design.");
		GUI.TextField(new Rect(0,250,500,50), "Special Thanks to you for playing! I hope you enjoyed it!");
		GUI.TextField(new Rect(0,300,500,50), "Music by DST, http://www.nosoapradio.us Thanks for the free music!");
		GUI.TextField(new Rect(0,350, 500, 50), "Send questions, praise, complaints, requests, to HarraldofFun@gmail.com");
	
	}
}
