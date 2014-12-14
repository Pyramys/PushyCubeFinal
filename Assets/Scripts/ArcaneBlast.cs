using UnityEngine;
using System.Collections;

public class ArcaneBlast : MonoBehaviour {
	public float speed;
	
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		rigidbody.velocity = speed *(rigidbody.velocity.normalized);

	}
}
