using UnityEngine;
using System.Collections;

public class PlayerAI : MonoBehaviour {
	public static int hp=3;
	public static float speed;
	//public Vector3 destinationPoint;		//Vector to where the mouse was/is clicked
	//public Vector3 collideVector;   		//Vector when the player collided with key
	//public float maxAngleSeparation;		//Max angle until separation occurs
	//public float minAngleSeparation;		//Min angle until separation occurs
	public bool isPushing;					//If there is an object attached to the player
	//public float currentAngle;				//calculates current angle of movement
	public Vector3 currentTransform;
	public Vector3 Origin;
	public GameObject hurt;
	GameObject singleton;

	public float timeInvincible = 3.0f;
	bool isInvincible = false;
	float invincibleTill;

	// Use this for initialization
	void Start () {
		Origin = new Vector3(0,0,0);
		isInvincible=true;
		singleton = GameObject.Find ("Singleton");
	}
	
	// Update is called once per frame
	void Update () 
	{
		currentTransform=transform.position;
		checkMovement();
		//destinationPoint=move.getDestinationPoint();   		//update the destinationpoint vector with the mouse click position
		checkHP();
		checkBounds();
		//checkAngle();						//Check to see if the angle is greater or less than the max and min angle of separation


		if (isInvincible && Time.time > invincibleTill) 
		{
			isInvincible = false;
		}
	}
	
	void OnCollisionEnter(Collision col)
	{
		
		if(col.gameObject.tag=="Trap")
		{
			if(!isInvincible)
			{
				transform.position=transform.position;
				hp--;									//if collide with trap -1 HP
				GameObject hurtEffect = Instantiate(hurt,transform.position, transform.rotation) as GameObject;
				singleton.SendMessage("wasHurt");
				isInvincible = true;
				invincibleTill = Time.time + timeInvincible;
			}

		}
		if(col.gameObject.tag=="Key" && isPushing==false)			//Check if collision is with key, and make sure not already carrying something
		{
			
			//collideVector = Vector3.Normalize(transform.position); 		//Store the vector at which the player collided with key
			col.transform.parent=gameObject.transform;					// turn the collision into a child
			//maxAngleSeparation = getAngle(collideVector, destinationPoint)+.4f;		// Max angle is the collide vector + 30 degrees
			//minAngleSeparation = getAngle(collideVector, destinationPoint)-.4f;		// Min angle is the collide vector - 30 degrees
			isPushing=true;	
			Transform[] allChildren = GetComponentsInChildren<Transform>();		//Build an array of all children
			foreach(Transform child in allChildren)								//For every child
			{
				if(child.tag=="Key")
				{
					child.SendMessage("SetChild");	
				}
			}
			
		}	
	}
	
	public static int getHp()
	{
		return hp;	
	}
	
	void checkHP()
	{

			
			if(hp<=0)
			{
				GameObject.Find("LevelManager").SendMessage("RestartLevel");	
				hp=3;
			}
		

		
	}
	
	void OnMouseDown()
	{
			Transform[] allChildren = GetComponentsInChildren<Transform>();		//Build an array of all children
			foreach(Transform child in allChildren)								//For every child
			{
				if(child.tag=="Key")
				{
					child.SendMessage("unChild");
					//child.transform.parent = null;									//unchild
					isPushing=false;										//set IsPushing to false
				}											
			}
		
	}
	
	public void dropCrystal()
	{
		Transform[] allChildren = GetComponentsInChildren<Transform>();		//Build an array of all children
			foreach(Transform child in allChildren)								//For every child
			{
				if(child.tag=="Key")
				{
					//child.SendMessage("UnChild");
					//child.transform.parent = null;									//unchild
					isPushing=false;												//set IsPushing to false
				}						
			}	
	}

	public void checkMovement()
	{
		if(Input.GetMouseButton(0))
		{
			isInvincible=false;

		}
	}
	void calculateSpeed()
	{
		
	}
	public static float getSpeed()
	{

		return speed;
	}

	void checkBounds()
	{
			
		if(currentTransform.x >= 13 || currentTransform.x <= -13)
		{
			transform.position = Origin;	
		}
		if(currentTransform.y >= 1 || currentTransform.y <= 0)
		{
			transform.position = new Vector3(currentTransform.x, Origin.y, currentTransform.z);	
		}
		if(currentTransform.z >= 13 || currentTransform.z <= -13)
		{
			transform.position = Origin;	
		}
	}

	public void setHP()
	{
		hp=3;
	}
}
