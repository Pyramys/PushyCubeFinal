using UnityEngine;
using System.Collections;

public class AnimTriggers : MonoBehaviour
{	
	// Create a reference to the animator component
	private Animator animator;
	
	
	void Start ()
	{
		// initialise the reference to the animator component
		animator = gameObject.GetComponent<Animator>();
	}

	void Update()
	{
		animator.SetBool("Run", true);	

	}

	// check for colliders with a Trigger collider
	// if we are entering something called JumpTrigger, set a bool parameter called JumpDown to true..
	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.name == "JumpTrigger")
		{
			animator.SetBool("JumpDown", true);	
		}
	}
	
	// ..and when leaving the trigger, reset it to false
	void OnTriggerExit(Collider col)
	{
		if(col.gameObject.name == "JumpTrigger")
		{
			animator.SetBool("JumpDown", false);
		}
	}
}
