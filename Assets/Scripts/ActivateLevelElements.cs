using UnityEngine;
using System.Collections;

public class ActivateLevelElements : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("LevelManager").SendMessage("levelElements");
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
