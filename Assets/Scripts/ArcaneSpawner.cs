using UnityEngine;
using System.Collections;

public class ArcaneSpawner : MonoBehaviour {
	public GameObject projectile;
	
	
	
	public Vector3 randomDirection;
	public int randomX;
	public int randomY;
	public int randomZ;
	
	
	void Awake(){
		randomX = Random.Range(0,360);
		randomY = Random.Range(0,360);
		randomZ = Random.Range(0,360);
		randomDirection = new Vector3(randomX, 0,randomZ);
	}
	
	// Use this for initialization
	void Start () {
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void spawnArcaneBlast()
	{
		GameObject blast = Instantiate(projectile,transform.position, transform.rotation) as GameObject;
		blast.rigidbody.AddForce(randomDirection * 5);
		
		
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
