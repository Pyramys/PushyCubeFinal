using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour {
	public Vector3 mouseOver;
	public Vector3 Origin;

	// Use this for initialization
	void Start () {
		mouseOver = new Vector3(-0.03524969f,-0.1806164f, -2.0f);
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
		Application.Quit();
	}
}
