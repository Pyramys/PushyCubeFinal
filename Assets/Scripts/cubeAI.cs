using UnityEngine;
using System.Collections;

public class cubeAI : MonoBehaviour {
	
	public Vector3 setPosition;
	public bool isChild=false;
	public Vector3 currentTransform;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		checkBounds();
	}
	
	void OnTriggerEnter(Collider col)
	{
		if(col.name == "RedSwitch" && gameObject.name == "RedCube")
		{
			isChild= false;
			gameObject.rigidbody.isKinematic = true;
			transform.parent=null;
			Deactivate();
		}
		if(col.name == "BlueSwitch" && gameObject.name == "BlueCube")
		{
			isChild= false;
			gameObject.rigidbody.isKinematic = true;
			transform.parent=null;
			Deactivate();
		}
		if(col.name == "YellowSwitch" && gameObject.name == "YellowCube")
		{
			isChild= false;
			gameObject.rigidbody.isKinematic = true;	
			transform.parent=null;
			Deactivate();
		}
		if(col.name == "GreenSwitch" && gameObject.name == "GreenCube")
		{
			isChild= false;
			gameObject.rigidbody.isKinematic = true;
			transform.parent=null;
			Deactivate();
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
	
	void SetChild()
	{
			
			
			isChild=true;
		
	}
	
	void unChild()
	{
		isChild=false;
		transform.parent=null;
	}
	
	void checkBounds()
	{
		if(isChild)
		{
			currentTransform = transform.localPosition;
			if(currentTransform.x != .026f)
			{
				currentTransform.x = .26f;	
			}
			if(currentTransform.y !=.4f)
			{
				currentTransform.y = .4f;
			}
			if(currentTransform.z !=.85f)
			{
				currentTransform.z = .85f;
			}
			transform.localPosition = currentTransform;	
			transform.rotation = Quaternion.identity;
		}
	}
}
