using UnityEngine;
using System.Collections;

/*
 * Script for rotating the cogs in the forge eastwards
 */
public class CogE : MonoBehaviour {

	private bool run=true;
	private float turnSpeed=40f;
	private CogDeath cg;
	
	// Use this for initialization
	void Start () {
		cg=GameObject.FindObjectOfType(typeof(CogDeath)) as CogDeath;
	}
	
	// Update is called once per frame
	// FixedUpdate instead of Update so that all cogs move at the same speed
	void FixedUpdate () {
		if(cg.died)
			run=false;
		if(run)
			transform.Rotate(new Vector3(0,0,-1), turnSpeed*Time.smoothDeltaTime);
	}
}
