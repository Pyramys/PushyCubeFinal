﻿using UnityEngine;
using System.Collections;
 
public class move : MonoBehaviour {
	
	private Transform myTransform;				// this transform
	private Vector3 destinationPosition;		// The destination Point
	public float destinationDistance;			// The distance between myTransform and destinationPosition
	PlayerAI Player;
	public bool Run;
	//public static Vector3 passDestination;
   private Animator anim;
 
	public float moveSpeed;						// The Speed the character will move
 
 
 
	void Start () {

		myTransform = transform;							// sets myTransform to this GameObject.transform
		destinationPosition = myTransform.position;			// prevents myTransform reset

        anim = GetComponent<Animator>();
	}
 
	void Update () {
 
		// keep track of the distance between this gameObject and destinationPosition
		destinationDistance = Vector3.Distance(destinationPosition, myTransform.position);
 
		if(destinationDistance < .1f){		// To prevent shakin behavior when near destination
			moveSpeed = 0;
			Run=false;
			
		}
		else if(destinationDistance > .1f){			// To Reset Speed to default
			moveSpeed = 5;
			Run=true;
		}
        anim.SetBool("Run", Run);
 
		// Moves the Player if the Left Mouse Button was clicked
		if (Input.GetMouseButtonDown(0)&& GUIUtility.hotControl ==0) {
 
			Plane playerPlane = new Plane(Vector3.up, myTransform.position);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			float hitdist = 0.0f;
			Run=true;
			if (playerPlane.Raycast(ray, out hitdist)) {
				Vector3 targetPoint = ray.GetPoint(hitdist);
				destinationPosition = ray.GetPoint(hitdist);
				//passDestination=destinationPosition;
				Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
				myTransform.rotation = targetRotation;
				
			}
		}
 
		// Moves the player if the mouse button is hold down
		else if (Input.GetMouseButton(0)&& GUIUtility.hotControl ==0) {
 			
			Plane playerPlane = new Plane(Vector3.up, myTransform.position);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			float hitdist = 0.0f;
			Run=true;
 
			if (playerPlane.Raycast(ray, out hitdist)) {
				Vector3 targetPoint = ray.GetPoint(hitdist);
				destinationPosition = ray.GetPoint(hitdist);
				//passDestination=destinationPosition;
				Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
				myTransform.rotation = targetRotation;
				
			}
			
		//	myTransform.position = Vector3.MoveTowards(myTransform.position, destinationPosition, moveSpeed * Time.deltaTime);
		}
 
		// To prevent code from running if not needed
        if (destinationDistance > .5f)
        {
            myTransform.position = Vector3.MoveTowards(myTransform.position, destinationPosition, moveSpeed * Time.deltaTime);
        }
        else 
        {
            myTransform.position = Vector3.MoveTowards(myTransform.position, destinationPosition, destinationDistance);
        }
	}
	
	/*static public Vector3 getDestinationPoint()
	{
		return Vector3.Normalize(passDestination);	
	}*/
}