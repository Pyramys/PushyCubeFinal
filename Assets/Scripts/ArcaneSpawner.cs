using UnityEngine;
using System.Collections;

public class ArcaneSpawner : MonoBehaviour {
	public GameObject projectile;
	
	

	//public Vector3 randomDirection;
	//public int randomX;
	//public int randomY;
	//public int randomZ;
	public bool randBool = true;
	public float randomY = 0;
	GameObject blast;

	
	
	void Awake(){
		//randomX = Random.Range(0,360);
		//randomY = Random.Range(0,360);
		//randomZ = Random.Range(0,360);
		//randomDirection = new Vector3(randomX, 0,randomZ);
		if (randBool) 
		{
			randomY = Random.Range (0, 360);
		}
		transform.Rotate (new Vector3 (0, randomY, 0));
	}
	
	// Use this for initialization
	void Start () {
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void spawnArcaneBlast()
	{
		//blast.rigidbody.AddForce(randomDirection * 5);
		
		blast = Instantiate(projectile,transform.position, transform.rotation) as GameObject;
		blast.rigidbody.AddForce(blast.transform.forward * 5);
		
		
	}
	
	void Deactivate()
	{
		gameObject.renderer.enabled=false;
		gameObject.collider.enabled=false;
		
	}
	
	void Activate()
	{
		
		spawnArcaneBlast();	
	}
	
}
