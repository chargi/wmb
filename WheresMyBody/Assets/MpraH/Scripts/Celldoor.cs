using UnityEngine;
using System.Collections;

/*
 * Script to open a door
 * Used transform.Rotate instead of created animation
 */
public class Celldoor : MonoBehaviour {
	//private Animator animator;
	private bool open=false;
	private float turnSpeed=40f;
	public GameObject player;
	
	void Start(){
		//animator=GetComponent<Animator>();
	}
	
	void Update(){
		if(open && transform.eulerAngles.y<160){
			transform.Rotate(new Vector3(0,1,0), turnSpeed*Time.deltaTime);
		}
		if( Input.GetKeyDown(KeyCode.E))
			OpenDoor();
	}
	
	void OnMouseDown(){
		OpenDoor();
		//animator.Play("Open");
	}

	void OpenDoor(){
		if(Vector3.Distance(this.transform.position, player.transform.position)<10)
			open=true;
	}
}
