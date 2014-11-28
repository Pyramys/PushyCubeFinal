using UnityEngine;
using System.Collections;

public class FireballSpawner : MonoBehaviour {
	public GameObject projectile;
	public float startTime;
	public float fireRate;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Activate()
	{
		InvokeRepeating("spawnFireball",startTime,fireRate);	
	}
	
	void Deactivate()
	{
		CancelInvoke("spawnFireball");
		
	}
	
	void spawnFireball()
	{
		GameObject ball = Instantiate(projectile,transform.position,transform.rotation) as GameObject;	
		
	}
	
	
}
