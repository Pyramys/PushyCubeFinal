using UnityEngine;
using System.Collections;

public class cube5AI : MonoBehaviour {
	public Vector3 startPosition;
	public float startx;
	public float starty;
	public float startz;
	
	// Use this for initialization
	void Start () {
		startx= transform.position.x;
		starty=transform.position.y;
		startz=transform.position.z;
		startPosition.x=startx;
		startPosition.y=starty;
		startPosition.z=startz;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col)
	{
		if(col.name == "RedSwitch" && gameObject.name == "RedCube")
		{
			transform.parent=null;
			transform.position=startPosition;
			
		}
		if(col.name == "BlueSwitch" && gameObject.name == "BlueCube")
		{
			transform.parent=null;
			transform.position=startPosition;	
			
		}
		if(col.name == "YellowSwitch" && gameObject.name == "YellowCube")
		{
			transform.parent=null;
			transform.position=startPosition;	
			
		}
	}
	
	void Activate()
	{
		gameObject.renderer.enabled=true;
		gameObject.collider.enabled=true;
		gameObject.rigidbody.useGravity=true;
	}
	
	void Deactivate()
	{
		gameObject.renderer.enabled=false;
		gameObject.collider.enabled=false;
		gameObject.rigidbody.useGravity=false;
	}
}

