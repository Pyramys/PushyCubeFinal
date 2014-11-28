using UnityEngine;
using System.Collections;

public class getPlayerPosition : MonoBehaviour {
	Vector3 touchPosition;
		

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	/*void OnMouseDown()
	{
		touchPosition = camera.ScreenToWorldPoint( new Vector3 (Input.mousePosition.x,Input.mousePosition.y,Camera.main.nearClipPlane));
		GameObject.FindGameObjectWithTag("Player").SendMessage("newTouchPosition", touchPosition);
	}*/
	
}
