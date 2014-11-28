using UnityEngine;
using System.Collections;

public class LightningTrap : MonoBehaviour {
	public GameObject projectile;
	public float fireRate=2.5f;
	public float fireStart=1.0f;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Activate()
	{
		gameObject.renderer.enabled=true;
		gameObject.collider.enabled=true;
		InvokeRepeating("Fire",fireStart,fireRate);
	}
	
	void Fire()
	{
		GameObject lightning = Instantiate(projectile,transform.position, transform.rotation) as GameObject;	
	}
	
	void Deactivate()
	{
		CancelInvoke("Fire");
		gameObject.renderer.enabled=false;
		gameObject.collider.enabled=false;
	}
}

