using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour {
	private Animator animator;
	public Transform left;
	public Transform right;
	private bool active=false;
	private Vector3 startr;
	
	void Start(){
		animator=GetComponent<Animator>();
	}
	
	void Update(){
		if(active){
			moveDoors(startr, 10);
		}
	}
	
	void OnMouseDown(){
		//print ("Play animation & do something");
		animator.Play("Down");
		startr=right.position;
		active=true;
	}
	
	private void moveDoors(Vector3 startr, int distance) {
		if(Vector3.Distance(right.position, startr+new Vector3(distance,0,0))>.1f){
			right.Translate(new Vector3(1,0,0)*Time.deltaTime);
			left.Translate(new Vector3(-1,0,0)*Time.deltaTime);
		}
	}
	
}
