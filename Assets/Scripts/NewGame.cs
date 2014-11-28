using UnityEngine;
using System.Collections;

public class NewGame : MonoBehaviour {
	public Vector3 mouseOver;
	public Vector3 Origin;
	
	// Use this for initialization
	void Start () {
		mouseOver = new Vector3(-0.0352497f,1.852718f, -2.2f);
		Origin = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseOver()
	{
		transform.position = mouseOver; 
	}
	
	void OnMouseExit()
	{
		transform.position=Origin;
	}
	
	void OnMouseDown()
	{
		Application.LoadLevel("IntroLevel");	
	}
}
