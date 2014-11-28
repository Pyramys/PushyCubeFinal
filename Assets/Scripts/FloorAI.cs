using UnityEngine;
using System.Collections;

public class FloorAI : MonoBehaviour {
	public Vector3 up;
	public bool goingUp;
	
	// Use this for initialization
	void Start () {
		 up = new Vector3(0,0.1f,0);
	}
	
	// Update is called once per frame
	void Update () {
		goUp ();
	}
	
	void Activate()
	{
		Debug.Log("GoingUp");
		goingUp=true;
	}
	
	void goUp()
	{
		if(goingUp)
		{
		transform.position 	+= up;
		}
		if(transform.position.y >=23.0f)
		{
			Application.LoadLevel("Ending");	
		}
	}
}
