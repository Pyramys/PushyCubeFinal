using UnityEngine;
using System.Collections;

public class WaveScript : MonoBehaviour {

    Animator anim;
    public float chance = 0.0f;
    public bool Wave = false;
    public bool roll = true;
	// Use this for initialization
	void Start () 
    {
        anim = GetComponent<Animator>();
        InvokeRepeating("ChanceWave", 0, 3);
	}
	
	// Update is called once per frame
	void ChanceWave () {
        if (roll)
        {
            chance = Random.Range(0, 99);
            if (chance > 70)
            {
                anim.SetTrigger("Wave");
            }
        }
	}
}
