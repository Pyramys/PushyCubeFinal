using UnityEngine;
using System.Collections;

public class ProjectileAI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	StartCoroutine("waitOneSecond");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	/*void OnTriggerEnter(Collider col)
	{
		Debug.Log(col);
		col.SendMessage("HitIceCone", SendMessageOptions.DontRequireReceiver);
	}
	*/
	IEnumerator waitOneSecond()
	{
		yield return new WaitForSeconds(1);
		transform.parent.SendMessage("DestroyParent");
		Destroy(gameObject);
	}
}
