using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour {
	public Vector3 distanceFromPlayer;
	public Vector3 distanceFromNodes;
	public Vector3 distanceFromNearestNode;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/*void buildNodeArray()
	{
		Collider[] nodes = Physics.OverlapSphere(transform.position, 200.0f);
		foreach(Collider node in nodes)
		{
			if(node.tag == "Node")
			{
				for(int i =0; i <nodes.Length; i++)
				{
					if((nodes[i].transform.position- transform.position) < distanceFromNearestNode)
					{
							distanceFromNearestNode= nodes[i].transform.position - transform.position;
					}
				}
			}
			else if(node.tag == "Player")
			{
				distanceFromPlayer = node.transform.position;	
			}
		}
	}*/
	
}
