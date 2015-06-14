using UnityEngine;
using System.Collections;

public class Fencedoor : MonoBehaviour {

	//private Animator animator;
	private bool open=false;
	private float turnSpeed=40f;
	
	void Start(){
	}
	
	void Update(){
		if(open && transform.eulerAngles.y>90){
			transform.RotateAround(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(0,-1,0), turnSpeed*Time.deltaTime);
		}
	}

	public void OpenDoor(){
		open=true;
	}
}
