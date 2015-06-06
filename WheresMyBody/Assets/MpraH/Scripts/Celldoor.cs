using UnityEngine;
using System.Collections;

public class Celldoor : MonoBehaviour {
	//private Animator animator;
	private bool open=false;
	private float turnSpeed=30f;
	
	void Start(){
		//animator=GetComponent<Animator>();
	}
	
	void Update(){
		if(open && transform.eulerAngles.y<160){
			transform.Rotate(new Vector3(0,1,0), turnSpeed*Time.deltaTime);
		}
	}
	
	void OnMouseDown(){
		//animator.Play("Open");
		open=true;
	}
	
}
