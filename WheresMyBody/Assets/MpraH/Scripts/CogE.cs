using UnityEngine;
using System.Collections;

public class CogE : MonoBehaviour {

	private bool run=true;
	private float turnSpeed=40f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(run)
			transform.Rotate(new Vector3(0,0,-1), turnSpeed*Time.smoothDeltaTime);
	}
}
