using UnityEngine;
using System.Collections;

/*
 * Script that opens the forge door
 */
public class Forgedoor : MonoBehaviour {
	//private Animator animator;
	private bool open=false;
	private float turnSpeed=20f;
	
	void Start(){
		//animator=GetComponent<Animator>();
	}
	
	void Update(){
		if(open && transform.eulerAngles.y<90){
			transform.Rotate(new Vector3(0,1,0), turnSpeed*Time.deltaTime);
		}
	}
	
	public void OpenDoor(){
		open=true;
	}
	
}
