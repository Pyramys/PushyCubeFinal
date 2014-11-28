using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {
	public Transform target;
	NavMeshAgent agent;
	public bool active = false;
	
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		if(active)
		{
		agent.SetDestination(target.position);
		}
	}

	public void Activate()
	{
		active=true;
	}
}
