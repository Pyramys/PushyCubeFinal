using UnityEngine;
using System.Collections;

public class StatueAI : MonoBehaviour {
	public bool active=false;
	public Vector3 movementDirection;
	public Vector3 playerPosition;
	public float speed=1.0f;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		{
			if(active)
			{
				playerPosition = GameObject.Find("Player").transform.position;
				movementDirection= playerPosition-transform.position;
				transform.position += movementDirection*speed*Time.deltaTime;
			}
		}
	}
	
	void Activate()
	{
		active=true;
		gameObject.rigidbody.isKinematic=false;
	}
	
	void Deactivate()
	{
		active=false;
		gameObject.rigidbody.isKinematic=true;
	}
}
