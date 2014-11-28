using UnityEngine;
using System.Collections;

public class rotatingScript : MonoBehaviour {

	public float speed = 120f;
	
	
	void Update ()
	{
		transform.Rotate(Vector3.left, speed * Time.deltaTime);
		transform.Rotate(Vector3.down, speed * Time.deltaTime);
	}
}

