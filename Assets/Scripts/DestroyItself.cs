using UnityEngine;
using System.Collections;

public class DestroyItself : MonoBehaviour {

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void DestroyParent()
	{
		
		Destroy(gameObject);	
	}
}
